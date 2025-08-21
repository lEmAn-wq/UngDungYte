using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UngDungYte
{
    public partial class FileCleaningView : UserControl
    {
        private DataTable dtTam;
        private DataTable dt;
        private Dictionary<(DataRow Row, int ColumnIndex), string> originalCellValues = new Dictionary<(DataRow, int), string>();
        private ToolTip cellToolTip = new ToolTip();
        private int rightClickedRowIndex = -1;

        public FileCleaningView()
        {
            InitializeComponent();
        }

        public void btnLoadFile_Click(object sender, EventArgs e)
        {
            dtTam = UIHelper.SelectCsvAndLoadToTable();
            if (dtTam != null)
            {
                originalCellValues.Clear();

                if (!dtTam.Columns.Contains("Status"))
                    dtTam.Columns.Add("Status", typeof(int));

                foreach (DataRow r in dtTam.Rows)
                {
                    r["Status"] = 0;
                }

                dataGridView1.DataSource = dtTam.DefaultView;

                // Đếm tổng số dòng
                int soDong = dtTam.Rows.Count;

                // Đếm số dòng trùng lặp (dựa trên toàn bộ giá trị các cột, không tính cột Status)
                var colNames = dtTam.Columns.Cast<DataColumn>()
                                  .Where(c => c.ColumnName != "Status")
                                  .Select(c => c.ColumnName).ToList();

                var hashSet = new HashSet<string>();
                int soDongTrungLap = 0;

                foreach (DataRow row in dtTam.Rows)
                {
                    var key = string.Join("||", colNames.Select(col => row[col]?.ToString() ?? ""));
                    if (!hashSet.Add(key))
                        soDongTrungLap++;
                }

                dt = dtTam.Copy();

                lblSoDong.Text = $"Số dòng: {soDong}";
                lblSoDongTrungLap.Text = $"Số dòng trùng lặp: {soDongTrungLap}";
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (dtTam == null || dtTam.Rows.Count == 0)
            {
                UIHelper.ShowMessageError("Không có dữ liệu để lưu.");
                return;
            }

            // Kiểm tra nếu còn dòng có Status ≠ 0
            bool hasPendingChanges = dtTam.AsEnumerable().Any(r => r.Field<int>("Status") != 0);
            if (hasPendingChanges)
            {
                UIHelper.ShowMessage("Vui lòng xác nhận trước khi lưu (tất cả dòng phải có Status = 0).");
                return;
            }

            var dtCopy = dtTam.Copy();
            if (dtCopy.Columns.Contains("Status"))
                dtCopy.Columns.Remove("Status");

            UIHelper.ShowSaveFileDialogAndExportToCsv(dtCopy);
        }



        #region Sự kiện DataGridView (Xử lý xóa sửa và tô màu dòng)

        private void CapNhatThongTinDong()
        {
            int soDongXoa = dtTam.AsEnumerable().Count(r => r.Field<int>("Status") == 2);
            int soDongSua = dtTam.AsEnumerable().Count(r => r.Field<int>("Status") == 1);

            // Đếm dòng trùng lặp dựa trên giá trị toàn bộ cột (bỏ cột Status)
            var soCotThuc = dtTam.Columns.Count - 1;
            var keyRows = dtTam.AsEnumerable()
                .Where(r => Convert.ToInt32(r["Status"]) != 2)
                .Select(r => string.Join("|", r.ItemArray.Take(soCotThuc)));

            int soDongTrungLap = keyRows.GroupBy(k => k).Where(g => g.Count() > 1).Sum(g => g.Count() - 1);

            lblSoDongXoa.Text = $"Đã xoá: {soDongXoa}";
            lblSoDongSua.Text = $"Đã sửa: {soDongSua}";
            lblSoDongTrungLap.Text = $"Trùng lặp: {soDongTrungLap}";
        }


        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value != null)
            {
                // Lưu giá trị cũ tạm thời
                cell.Tag = cell.Value.ToString();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            var cell = row.Cells[e.ColumnIndex];
            string newValue = cell.Value?.ToString() ?? "";
            string oldValue = cell.Tag?.ToString() ?? "";

            if (newValue != oldValue && row.DataBoundItem is DataRowView drv)
            {
                int status = Convert.ToInt32(drv["Status"]);
                drv["Status"] = 1;
                DataRow dataRow = drv.Row;

                var key = (dataRow, e.ColumnIndex);
                originalCellValues[key] = oldValue;

                CapNhatThongTinDong();
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;

            if (e.Row.DataBoundItem is DataRowView drv)
            {
                if (Convert.ToInt32(drv["Status"]) != 2)
                {
                    drv["Status"] = 2;
                    CapNhatThongTinDong();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            if (!(row.DataBoundItem is DataRowView drv)) return;

            var key = (drv.Row, e.ColumnIndex);
            if (originalCellValues.TryGetValue(key, out string oldValue))
            {
                var cellRect = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                Point locationOnScreen = dataGridView1.PointToScreen(new Point(cellRect.X + 10, cellRect.Y + 10));
                cellToolTip.Show($"Giá trị cũ: {oldValue}", this, PointToClient(locationOnScreen), 3000);
            }
            else
            {
                cellToolTip.Hide(this);
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // 1. Bỏ qua header hoặc các hàng không hợp lệ
            if (e.RowIndex < 0) return;

            var grid = dataGridView1;
            var row = grid.Rows[e.RowIndex];
            if (!(row.DataBoundItem is DataRowView drv)) return;

            int status = Convert.ToInt32(drv["Status"]);
            DataRow dataRow = drv.Row;

            // 2. Nếu Status == 2 (dòng "đã xóa"), tô nền đỏ cho cả dòng
            if (status == 2)
            {
                row.DefaultCellStyle.BackColor = Color.LightCoral;

                // Nếu bạn có tô cell.Style riêng, hãy xóa nó để không ghi đè mặc định:
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Style.BackColor = Color.Empty;
            }
            // 3. Nếu Status == 1 (dòng "đã chỉnh sửa"), tô nền vàng nhạt cho cả dòng
            else if (status == 1)
            {
                // Gán nền vàng cho cả dòng
                row.DefaultCellStyle.BackColor = Color.LightYellow;

                // Duyệt qua từng cell trong dòng
                for (int col = 0; col < row.Cells.Count; col++)
                {
                    var key = (dataRow, col);
                    if (originalCellValues.ContainsKey(key))
                    {
                        // Nếu cell này có key trong originalCellValues → tô Tan
                        row.Cells[col].Style.BackColor = Color.Tan;
                    }
                }
            }
            // 4. Nếu Status == 0 (mặc định), trả về màu mặc định của DataGridView
            else
            {
                row.DefaultCellStyle.BackColor = grid.DefaultCellStyle.BackColor;
            }
        }

        private void undoDeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (rightClickedRowIndex < 0) return;

            var rowView = dataGridView1.Rows[rightClickedRowIndex].DataBoundItem as DataRowView;
            if (rowView == null) return;

            DataRow dataRow = rowView.Row;

            // Kiểm tra xem dòng này có ô nào đã từng chỉnh sửa hay không
            bool anyEditedCell = originalCellValues.Keys.Any(k => k.Row == dataRow);

            // Nếu có ô đã edit → status = 1, ngược lại → status = 0
            dataRow["Status"] = anyEditedCell ? 1 : 0;

            rightClickedRowIndex = -1;

            CapNhatThongTinDong();
        }

        private void dataGridView1_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var drv = dataGridView1.Rows[e.RowIndex].DataBoundItem as DataRowView;
            rightClickedRowIndex = e.RowIndex;
            if (drv == null) return;

            int status = Convert.ToInt32(drv["Status"]);
            if (status == 2)
                e.ContextMenuStrip = rowContextMenu;
            else
                e.ContextMenuStrip = null;
        }

        #endregion

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (dtTam == null) return;

            // Xóa các dòng có Status = 2
            var rowsToDelete = dtTam.AsEnumerable()
                .Where(r => r.Field<int>("Status") == 2)
                .ToList();

            foreach (var row in rowsToDelete)
                dtTam.Rows.Remove(row);

            // Xóa lịch sử giá trị cũ
            originalCellValues.Clear();

            // Reset lại Status = 0 cho các dòng còn lại
            foreach (DataRow row in dtTam.Rows)
                row["Status"] = 0;

            foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in dgvRow.Cells)
                {
                    cell.Style.BackColor = Color.Empty;
                }
                //dgvRow.DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
            }

            // Cập nhật lại các label nếu cần
            lblSoDong.Text = $"Số dòng: {dtTam.Rows.Count}";
            CapNhatThongTinDong();

            dt = dtTam.Copy();
        }

        private void btnTienXuLy_Click(object sender, EventArgs e)
        {
            if (dtTam == null) return;

            string[] columnsToClean = { "Glucose", "BloodPressure", "SkinThickness", "Insulin", "BMI" };

            foreach (string colName in columnsToClean)
            {
                if (!dtTam.Columns.Contains(colName)) continue;

                // Tính trung vị bỏ qua các giá trị 0
                var validValues = dtTam.AsEnumerable()
                                    .Select(r => Convert.ToDouble(r[colName]))
                                    .Where(v => v != 0)
                                    .OrderBy(v => v)
                                    .ToList();
                if (validValues.Count == 0) continue;

                double median = (validValues.Count % 2 == 0)
                    ? (validValues[validValues.Count / 2 - 1] + validValues[validValues.Count / 2]) / 2.0
                    : validValues[validValues.Count / 2];

                // Thay thế giá trị 0 và cập nhật status
                foreach (DataRow row in dtTam.Rows)
                {
                    double val = Convert.ToDouble(row[colName]);
                    if (val == 0)
                    {
                        object oldValue = row[colName];
                        row[colName] = median;

                        // Đánh dấu đã chỉnh sửa
                        if (Convert.ToInt32(row["Status"]) != 2)
                            row["Status"] = 1;

                        // Lưu lại giá trị cũ để hiển thị tooltip và tô màu cell
                        var key = (row, dtTam.Columns[colName].Ordinal);
                        if (!originalCellValues.ContainsKey(key))
                            originalCellValues[key] = oldValue.ToString();
                    }
                }
            }

            dataGridView1.Refresh();
            UIHelper.ShowMessage("Đã xử lý các giá trị 0 bằng trung vị và đánh dấu các dòng đã chỉnh sửa.");
            CapNhatThongTinDong();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            originalCellValues.Clear();

            dtTam = dt.Copy();
            dataGridView1.DataSource = dtTam.DefaultView;

            CapNhatThongTinDong();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (dtTam == null) return;

            StringBuilder sb = new StringBuilder();
            foreach (DataColumn col in dtTam.Columns)
            {
                string colName = col.ColumnName;
                if (colName == "Outcome" || colName == "Status") continue;

                int nullCount = dtTam.AsEnumerable().Count(r => string.IsNullOrWhiteSpace(r[col].ToString()));
                int zeroCount = dtTam.AsEnumerable().Count(r => r[col].ToString().Trim() == "0");

                sb.AppendLine($"{colName}: Null = {nullCount},\t 0 = {zeroCount}");
            }

            MessageBox.Show(sb.ToString(), "Thống kê dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}