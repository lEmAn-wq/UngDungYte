using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace UngDungYte
{
    public partial class DatasetView : UserControl
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();

        public static DataTable dt;

        private List<string> conditions = new List<string>(); // Lưu các điều kiện tự chọn
        public DatasetView()
        {
            InitializeComponent();
            InitializeControls();
            //cboLuaChon
            //cboDieuKienLocTuChon
            //cboDieuKien
            //cboThuocTinh
            //txtGiaTri
        }

        private void InitializeControls()
        {
            // Khởi tạo cboLuaChon
            cboLuaChon.Items.Clear();
            cboLuaChon.Items.AddRange(new string[] { "Tất cả", "Bị tiểu đường", "Không bị tiểu đường", "Lọc theo điều kiện tự chọn" });
            cboLuaChon.SelectedIndex = -1;

            // Khởi tạo cboThuocTinh với các cột từ DataTable (sẽ cập nhật khi load file)
            cboThuocTinh.Items.Clear();

            // Khởi tạo cboDieuKien
            cboDieuKien.Items.Clear();
            cboDieuKien.Items.AddRange(new string[] { ">", "<" });
            cboDieuKien.SelectedIndex = -1;

            // Ẩn các điều khiển lọc tự chọn ban đầu
            flpDieuKien.Visible = false;
            grboxDKLocTuChon.Visible = false;
            btnXacNhan.Visible = false;
            grboxLuaChon.Visible = false;
            lblSoDong.Visible = false;
            btnXoa.Visible = false;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            var originalTable = UIHelper.SelectCsvAndLoadToTable();
            if (originalTable == null) return;

            // Tạo bảng mới
            DataTable newTable = new DataTable();

            // Xác định kiểu từng cột
            foreach (DataColumn col in originalTable.Columns)
            {
                bool isInt = true, isDouble = true;

                foreach (DataRow row in originalTable.Rows)
                {
                    var val = row[col].ToString();
                    if (!int.TryParse(val, out _)) isInt = false;
                    if (!double.TryParse(val, out _)) isDouble = false;
                }

                Type colType = typeof(string);
                if (isInt) colType = typeof(int);
                else if (isDouble) colType = typeof(double);

                newTable.Columns.Add(col.ColumnName, colType);
            }

            // Chuyển dữ liệu
            foreach (DataRow row in originalTable.Rows)
            {
                var newRow = newTable.NewRow();
                foreach (DataColumn col in originalTable.Columns)
                {
                    var value = row[col].ToString();
                    if (newTable.Columns[col.ColumnName].DataType == typeof(int))
                        newRow[col.ColumnName] = int.Parse(value);
                    else if (newTable.Columns[col.ColumnName].DataType == typeof(double))
                        newRow[col.ColumnName] = double.Parse(value);
                    else
                        newRow[col.ColumnName] = value;
                }
                newTable.Rows.Add(newRow);
            }

            dt = newTable;
            dgvDataset.DataSource = dt;

            lblSoDong.Text = "Số dòng: " + dt.Rows.Count.ToString();

            cboLuaChon.SelectedIndex = 0; // Chọn "Tất cả"
            btnXacNhan.Visible = true;
            grboxLuaChon.Visible = true;
            lblSoDong.Visible = true;

            // Cập nhật các thuộc tính từ DataTable vào cboThuocTinh
            cboThuocTinh.Items.Clear();
            foreach (DataColumn col in dt.Columns)
            {
                cboThuocTinh.Items.Add(col.ColumnName);
            }

            AllocConsole();
            foreach (DataColumn col in dt.Columns)
            {
                Console.WriteLine($"{col.ColumnName}: {col.DataType}");
            }
            Console.WriteLine("\n");
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cboLuaChon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một tùy chọn lọc.");
                return;
            }
            else if (cboLuaChon.SelectedIndex == 0) // Tất cả
            {
                dgvDataset.DataSource = dt;
                lblSoDong.Text = "Số dòng: " + dt.Rows.Count.ToString();
            }
            else if (cboLuaChon.SelectedIndex == 1) // Bị tiểu đường
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = "Outcome = 1"; // Lọc Outcome = 1
                dgvDataset.DataSource = dv;
                lblSoDong.Text = "Số dòng: " + dv.Count.ToString();
            }
            else if (cboLuaChon.SelectedIndex == 2) // Không bị tiểu đường
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = "Outcome = 0"; // Lọc Outcome = 0
                dgvDataset.DataSource = dv;
                lblSoDong.Text = "Số dòng: " + dv.Count.ToString();
            }
            else if (cboLuaChon.SelectedIndex == 3) // Lọc theo điều kiện tự chọn
            {
                if (cboDieuKienLocTuChon.Items.Count == 0)
                {
                    MessageBox.Show("Vui lòng nhập ít nhất một điều kiện để lọc.");
                    return;
                }
                DataTable filteredTable = dt.Copy();
                var rows = filteredTable.AsEnumerable();
                foreach (string condition in cboDieuKienLocTuChon.Items)
                {
                    string[] parts = condition.Split(new[] { ' ' }, 3);
                    if (parts.Length != 3)
                    {
                        MessageBox.Show("Định dạng điều kiện không hợp lệ: " + condition);
                        return;
                    }

                    string attribute = parts[0];
                    string operatorStr = parts[1];
                    if (!double.TryParse(parts[2], out double value))
                    {
                        MessageBox.Show("Giá trị điều kiện phải là số: " + parts[2]);
                        return;
                    }

                    try
                    {
                        if (operatorStr == ">")
                            rows = rows.Where(r => Convert.ToDouble(r[attribute]) > value);
                        else if (operatorStr == "<")
                            rows = rows.Where(r => Convert.ToDouble(r[attribute]) < value);
                        else
                        {
                            MessageBox.Show("Toán tử không hợp lệ: " + operatorStr);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi chuyển đổi giá trị cột " + attribute + ": " + ex.Message);
                        return;
                    }
                }
                if (rows.Any())
                    filteredTable = rows.CopyToDataTable();
                else
                    filteredTable = dt.Clone(); // Bảng rỗng nếu không có kết quả
                dgvDataset.DataSource = filteredTable;
                lblSoDong.Text = "Số dòng: " + filteredTable.Rows.Count.ToString(); // Cập nhật số dòng
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboThuocTinh.SelectedIndex == -1 || cboDieuKien.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtGiaTri.Text))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thuộc tính, toán tử và giá trị!");
                return;
            }

            if (!double.TryParse(txtGiaTri.Text, out _))
            {
                MessageBox.Show("Giá trị phải là số!");
                return;
            }

            string condition = $"{cboThuocTinh.SelectedItem} {cboDieuKien.SelectedItem} {txtGiaTri.Text}";
            if (!cboDieuKienLocTuChon.Items.Contains(condition))
            {
                cboDieuKienLocTuChon.Items.Add(condition);
            }
            txtGiaTri.Clear(); // Xóa giá trị sau khi thêm
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboDieuKienLocTuChon.SelectedIndex != -1)
            {
                cboDieuKienLocTuChon.Items.RemoveAt(cboDieuKienLocTuChon.SelectedIndex);
                cboDieuKienLocTuChon.SelectedIndex = -1; // Đặt lại chỉ mục đã chọn
                cboDieuKienLocTuChon.Text = ""; // Xóa văn bản hiển thị
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một điều kiện để xóa!");
            }
        }

        private void cboLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLuaChon.SelectedIndex == 3) // Lọc theo điều kiện tự chọn
            {
                flpDieuKien.Visible = true;
                grboxDKLocTuChon.Visible = true;
                btnXoa.Visible = true;
            }
            else
            {
                flpDieuKien.Visible = false;
                grboxDKLocTuChon.Visible = false;
                btnXoa.Visible = false;

                // Xóa các điều kiện lọc tự chọn
                cboThuocTinh.SelectedIndex = -1;
                cboDieuKien.SelectedIndex = -1;
                txtGiaTri.Clear();
                cboDieuKienLocTuChon.Items.Clear();
            }
        }
    }
}
