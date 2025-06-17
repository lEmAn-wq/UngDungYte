using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace UngDungYte
{
    public partial class FileCleaningView : UserControl
    {
        private DataTable dt;
        private Dictionary<(DataRow Row, int ColumnIndex), string> originalCellValues = new Dictionary<(DataRow, int), string>();
        private ToolTip cellToolTip = new ToolTip();
        private int rightClickedRowIndex = -1;

        public FileCleaningView()
        {
            InitializeComponent();
            //lblSoDong
            //lblSoDongSua
            //lblSoDongTrungLap
            //lblSoDongXoa
        }

        public void btnLoadFile_Click(object sender, EventArgs e)
        {
            dt = UIHelper.SelectCsvAndLoadToTable();
            if (dt != null)
            {
                originalCellValues.Clear();

                if (!dt.Columns.Contains("Status"))
                    dt.Columns.Add("Status", typeof(int));

                foreach (DataRow r in dt.Rows)
                {
                    r["Status"] = 0;
                }

                dataGridView1.DataSource = dt.DefaultView;

                // Đếm tổng số dòng
                int soDong = dt.Rows.Count;

                // Đếm số dòng trùng lặp (dựa trên toàn bộ giá trị các cột, không tính cột Status)
                var colNames = dt.Columns.Cast<DataColumn>()
                                  .Where(c => c.ColumnName != "Status")
                                  .Select(c => c.ColumnName).ToList();

                var hashSet = new HashSet<string>();
                int soDongTrungLap = 0;

                foreach (DataRow row in dt.Rows)
                {
                    var key = string.Join("||", colNames.Select(col => row[col]?.ToString() ?? ""));
                    if (!hashSet.Add(key))
                        soDongTrungLap++;
                }

                lblSoDong.Text = $"Số dòng: {soDong}";
                lblSoDongTrungLap.Text = $"Số dòng trùng lặp: {soDongTrungLap}";
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                UIHelper.ShowMessageError("Không có dữ liệu để lưu.");
                return;
            }

            // Kiểm tra nếu còn dòng có Status ≠ 0
            bool hasPendingChanges = dt.AsEnumerable().Any(r => r.Field<int>("Status") != 0);
            if (hasPendingChanges)
            {
                UIHelper.ShowMessage("Vui lòng xác nhận trước khi lưu (tất cả dòng phải có Status = 0).");
                return;
            }

            var dtCopy = dt.Copy();
            if (dtCopy.Columns.Contains("Status"))
                dtCopy.Columns.Remove("Status");

            UIHelper.ShowSaveFileDialogAndExportToCsv(dtCopy);
        }



        #region Sự kiện DataGridView (Xử lý xóa sửa và tô màu dòng)

        private void CapNhatThongTinDong()
        {
            int soDongXoa = dt.AsEnumerable().Count(r => r.Field<int>("Status") == 2);
            int soDongSua = dt.AsEnumerable().Count(r => r.Field<int>("Status") == 1);

            // Đếm dòng trùng lặp dựa trên giá trị toàn bộ cột (bỏ cột Status)
            var soCotThuc = dt.Columns.Count - 1;
            var keyRows = dt.AsEnumerable()
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
            if (dt == null) return;

            // Xóa các dòng có Status = 2
            var rowsToDelete = dt.AsEnumerable()
                .Where(r => r.Field<int>("Status") == 2)
                .ToList();

            foreach (var row in rowsToDelete)
                dt.Rows.Remove(row);

            // Xóa lịch sử giá trị cũ
            originalCellValues.Clear();

            // Reset lại Status = 0 cho các dòng còn lại
            foreach (DataRow row in dt.Rows)
                row["Status"] = 0;

            foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in dgvRow.Cells)
                {
                    cell.Style.BackColor = Color.Empty;
                }
                dgvRow.DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
            }

            // Cập nhật lại các label nếu cần
            lblSoDong.Text = $"Số dòng: {dt.Rows.Count}";
            CapNhatThongTinDong();
        }

        private void btnTienXuLy_Click(object sender, EventArgs e)
        {

        }
    }
}