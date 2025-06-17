using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungYte
{
    public static class UIHelper
    {
        #region Message Helpers

        // Phương thức chung
        private static DialogResult Show(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(message, title, buttons, icon);
        }

        // Thông báo thông tin
        public static void ShowMessage(string message)
        {
            Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Thông báo lỗi
        public static void ShowMessageError(string message)
        {
            Show(message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Câu hỏi (Yes/No)
        public static DialogResult ShowMessageQuestion(string message)
        {
            return Show(message, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static DialogResult ShowMessageWarning(string message)
        {
            return Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region UI Controls
        public static void LoadUserControlToPanel(Panel panel, UserControl uc)
        {
            panel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel.Controls.Add(uc);
        }
        #endregion

        #region CSV Import

        public static DataTable SelectCsvAndLoadToTable()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = ReadCsvToDataTable(openFileDialog.FileName);
                return dt;
            }
            return null;
        }

        public static DataTable ReadCsvToDataTable(string filePath)
        {
            DataTable dt = null;

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    dt = new DataTable();
                    bool isFirstLine = true;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        var values = line.Split(',');

                        if (isFirstLine)
                        {
                            foreach (var header in values)
                                dt.Columns.Add(header.Trim());
                            isFirstLine = false;
                        }
                        else
                        {
                            dt.Rows.Add(values);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessageError("Lỗi đọc file CSV: " + ex.Message);
            }
            return dt;
        }

        #endregion

        #region CSV Export

        public static void ShowSaveFileDialogAndExportToCsv(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                ShowMessageWarning("Không có dữ liệu để lưu.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Lưu file CSV"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportDataTableToCsv(dt, saveFileDialog.FileName);
                    ShowMessage("Lưu file CSV thành công!");
                }
                catch (Exception ex)
                {
                    ShowMessageError("Lỗi khi lưu file: " + ex.Message);
                }
            }
        }

        public static void ExportDataTableToCsv(DataTable dt, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Ghi header
                writer.WriteLine(string.Join(",", dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName)));

                // Ghi dữ liệu
                foreach (DataRow row in dt.Rows)
                {
                    var values = dt.Columns.Cast<DataColumn>()
                        .Select(c => row[c]?.ToString()?.Replace(",", " ") ?? "");
                    writer.WriteLine(string.Join(",", values));
                }
            }
        }
        #endregion
    }
}