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
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            UIHelper.ShowSaveFileDialogAndExportToCsv(dataGridView1);
        }

        #region Sự kiện DataGridView (Xử lý xóa sửa và tô màu dòng)

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
    }
}