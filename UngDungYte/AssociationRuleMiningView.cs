using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UngDungYte
{
    public partial class AssociationRuleMiningView : UserControl
    {
        public static List<(List<Condition> Antecedent,double SupportAB, double Confidence)> SavedRules = new();

        private int validRuleCount;

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();

        public record Condition(string Attribute, string Operator, double Value);

        // Định nghĩa kiểu dữ liệu của các thuộc tính
        private static readonly HashSet<string> IntegerAttributes = new() { "Pregnancies", "Age", "Glucose", "BloodPressure", "SkinThickness", "Insulin" };
        private static readonly HashSet<string> FloatAttributes = new(){ "BMI", "DiabetesPedigreeFunction" };

        private readonly Dictionary<string, HashSet<double>> _greaterDict = new();
        private readonly Dictionary<string, HashSet<double>> _lessDict = new();
        private readonly ComboItem[] _conditionItems =
        {
            new ComboItem { Text = "Lớn hơn", Value = ">" },
            new ComboItem { Text = "Nhỏ hơn", Value = "<" }
        };

        public AssociationRuleMiningView()
        {
            InitializeComponent();
            InitializeComboBox();
            InitializeDataGridView();

            lblSoLuat.Visible = lblSoLuatHopLe.Visible = false;
        }

        private void InitializeComboBox()
        {
            cboDieuKien.DisplayMember = "Text";
            cboDieuKien.ValueMember = "Value";
            cboDieuKien.DataSource = _conditionItems;
        }

        private void InitializeDataGridView()
        {
            dgvRoiRacGiaTri.Columns.Clear();
            dgvRoiRacGiaTri.ReadOnly = true;
            dgvRoiRacGiaTri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvRoiRacGiaTri.Columns.Add(new DataGridViewTextBoxColumn { Name = "AttributeType", HeaderText = "Loại thuộc tính" });
            dgvRoiRacGiaTri.Columns.Add(new DataGridViewTextBoxColumn { Name = "GreaterThan", HeaderText = "Lớn hơn" });
            dgvRoiRacGiaTri.Columns.Add(new DataGridViewTextBoxColumn { Name = "LessThan", HeaderText = "Nhỏ hơn" });

            // Khởi tạo dgvLKH
            dgvLKH.Columns.Clear();
            dgvLKH.ReadOnly = true;
            dgvLKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLKH.Columns.Add(new DataGridViewTextBoxColumn { Name = "LuatHop", HeaderText = "Luật kết hợp" });
            dgvLKH.Columns.Add(new DataGridViewTextBoxColumn { Name = "DoTinCay", HeaderText = "Độ tin cậy" });
        }

        private void AddCondition(string attribute, string operatorType, string valueText)
        {
            if (string.IsNullOrWhiteSpace(attribute) || string.IsNullOrWhiteSpace(valueText) || !double.TryParse(valueText, out var value))
                return;

            var dict = operatorType == ">" ? _greaterDict : _lessDict;
            dict.TryGetValue(attribute, out var values);
            values ??= dict[attribute] = new HashSet<double>();

            if (!values.Add(value)) return;
            UpdateDataGridRow(attribute);
        }

        private void RemoveCondition(string attribute, string operatorType, string valueText)
        {
            if (string.IsNullOrWhiteSpace(attribute) || string.IsNullOrWhiteSpace(valueText) || !double.TryParse(valueText, out var value))
                return;

            var dict = operatorType == ">" ? _greaterDict : _lessDict;
            if (!dict.TryGetValue(attribute, out var values) || !values.Remove(value))
                return;

            if (values.Count == 0)
                dict.Remove(attribute);

            UpdateDataGridRow(attribute);
        }

        private void UpdateDataGridRow(string attribute)
        {
            var greaterText = _greaterDict.TryGetValue(attribute, out var greaterValues)
                ? string.Join(", ", greaterValues.OrderBy(x => x))
                : string.Empty;
            var lessText = _lessDict.TryGetValue(attribute, out var lessValues)
                ? string.Join(", ", lessValues.OrderBy(x => x))
                : string.Empty;

            var row = dgvRoiRacGiaTri.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells["AttributeType"].Value?.ToString() == attribute);

            if (string.IsNullOrEmpty(greaterText) && string.IsNullOrEmpty(lessText))
            {
                if (row != null) dgvRoiRacGiaTri.Rows.Remove(row);
                return;
            }

            if (row == null)
            {
                var index = dgvRoiRacGiaTri.Rows.Add();
                row = dgvRoiRacGiaTri.Rows[index];
                row.Cells["AttributeType"].Value = attribute;
            }

            row.Cells["GreaterThan"].Value = greaterText;
            row.Cells["LessThan"].Value = lessText;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddCondition(cboThuocTinh.SelectedItem?.ToString(), cboDieuKien.SelectedValue?.ToString(), txtGiaTri.Text.Trim());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            RemoveCondition(cboThuocTinh.SelectedItem?.ToString(), cboDieuKien.SelectedValue?.ToString(), txtGiaTri.Text.Trim());
        }

        private void btnThucThi_Click(object sender, EventArgs e)
        {
            try
            {
                SavedRules.Clear(); // Xóa luật cũ

                if (!ValidateInput(out double minConf, out double minSup))
                    return;

                var conditions = GetAllConditions();
                var combos = GenerateAllValidCombos(conditions);

                int totalRows = DatasetView.dt.Rows.Count;

                //AllocConsole();
                //Console.WriteLine("Số dòng dgv: "+totalRows);

                SavedRules = GenerateAssociationRules(combos, totalRows, minSup, minConf);

                UpdateDataGridViewLKH(SavedRules, minConf);
                int totalRules = dgvLKH.Rows.Count -1; // Tổng số luật từ số dòng trong dgvLKH
                lblSoLuat.Text = $"Tổng số luật: {totalRules}";
                lblSoLuat.Visible = lblSoLuatHopLe.Visible = true;

                lblSoLuatHopLe.Text = $"Số luật hợp lệ: {validRuleCount}";
                AllocConsole();
                Console.WriteLine("=== Các combo hợp lệ ===");
                for (int i = 0; i < combos.Count; i++)
                    Console.WriteLine($"{i + 1}. {string.Join(" ∧ ", combos[i].Select(c => $"{c.Attribute}{c.Operator}{c.Value}"))}");
                Console.WriteLine("\n");
                UIHelper.ShowMessage("Thực thi thành công.");
            }
            catch (Exception ex)
            {
                UIHelper.ShowMessageError($"Lỗi: {ex.Message}");
            }
        }

        private bool ValidateInput(out double minConf, out double minSup)
        {
            minConf = minSup = 0;

            if (!double.TryParse(txtMinconf.Text, out minConf) || minConf < 0 || minConf > 1 ||
                !double.TryParse(txtMinsup.Text, out minSup) || minSup < 0 || minSup > 1)
            {
                UIHelper.ShowMessageError("MinConf và MinSup phải là số thực trong khoảng từ 0-1.");
                return false;
            }

            return true;
        }

        private List<Condition> GetAllConditions()
        {
            var conditions = new List<Condition>();
            foreach (var (attr, values) in _greaterDict)
                conditions.AddRange(values.Select(v => new Condition(attr, ">", v)));
            foreach (var (attr, values) in _lessDict)
                conditions.AddRange(values.Select(v => new Condition(attr, "<", v)));
            return conditions.OrderBy(c => c.Attribute).ThenBy(c => c.Operator).ThenBy(c => c.Value).ToList();
        }

        private List<List<Condition>> GenerateAllValidCombos(List<Condition> conditions)
        {
            var result = new List<List<Condition>>();
            var maxSize = conditions.Count;

            // Lưu trữ tổ hợp theo kích thước để tái sử dụng
            var comboCache = new Dictionary<int, List<List<Condition>>>
            {
                [1] = conditions.Select(c => new List<Condition> { c }).Where(IsValidCombo).ToList()
            };

            // Sinh tổ hợp từ mức 2 trở lên dựa trên mức trước đó
            for (int size = 2; size <= maxSize; size++)
            {
                var prevCombos = comboCache[size - 1];
                var newCombos = new List<List<Condition>>();

                foreach (var prevCombo in prevCombos)
                {
                    var lastCondition = prevCombo.Last();
                    var startIndex = conditions.FindIndex(c => c == lastCondition) + 1;

                    for (int i = startIndex; i < conditions.Count; i++)
                    {
                        var newCombo = new List<Condition>(prevCombo) { conditions[i] };
                        if (IsValidCombo(newCombo))
                            newCombos.Add(newCombo);
                    }
                }

                if (newCombos.Count == 0) break; // Thoát sớm nếu không còn tổ hợp hợp lệ
                comboCache[size] = newCombos;
                result.AddRange(newCombos);
            }

            result.AddRange(comboCache[1]); // Thêm tổ hợp mức 1
            return result.OrderBy(c => c.Count).ThenBy(c => string.Join(",", c.Select(x => $"{x.Attribute}{x.Operator}{x.Value}"))).ToList();
        }

        private bool IsValidCombo(List<Condition> combo)
        {
            var groups = combo.GroupBy(c => c.Attribute).ToList();
            foreach (var group in groups)
            {
                var attribute = group.Key;
                var greater = group.Where(c => c.Operator == ">").Select(c => c.Value).ToList();
                var less = group.Where(c => c.Operator == "<").Select(c => c.Value).ToList();

                // Không cho phép nhiều điều kiện cùng toán tử cho cùng thuộc tính
                if (greater.Count > 1 || less.Count > 1)
                    return false;

                // Kiểm tra mâu thuẫn giữa greater và less
                if (greater.Any() && less.Any())
                {
                    double maxGreater = greater.Max();
                    double minLess = less.Min();

                    // Với thuộc tính số nguyên, khoảng giữa maxGreater và minLess phải có ít nhất 1 số nguyên
                    if (IntegerAttributes.Contains(attribute))
                    {
                        if (Math.Ceiling(maxGreater) >= Math.Floor(minLess))
                            return false; // Không có số nguyên nào thỏa mãn
                    }
                    // Với thuộc tính số thực, chỉ cần maxGreater >= minLess là mâu thuẫn
                    else if (maxGreater >= minLess)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private List<(List<Condition> Antecedent, double SupportAB, double Confidence)> GenerateAssociationRules(
    List<List<Condition>> combos, int totalRows, double minSup, double minConf)
        {
            var rules = new List<(List<Condition> Antecedent, double SupportAB, double Confidence)>();

            foreach (var combo in combos)
            {
                // Lọc dataset theo các điều kiện của tổ hợp
                var matchingRows = DatasetView.dt.AsEnumerable()
                    .Where(r => combo.All(c =>
                        (c.Operator == ">" && Convert.ToDouble(r[c.Attribute]) > c.Value) ||
                        (c.Operator == "<" && Convert.ToDouble(r[c.Attribute]) < c.Value)));

                // Tính support(AB): số dòng có Outcome = 1 trong dataset đã lọc
                var matchingRowsWithOutcome = matchingRows.Where(r => Convert.ToInt32(r["Outcome"]) == 1);
                
                int count_matchingRowsWithOutcome = matchingRowsWithOutcome.Count();
                double supportAB = count_matchingRowsWithOutcome / (double)totalRows;

                //AllocConsole();
                //Console.WriteLine("Số dòng outcome = 1: " + matchingRowsWithOutcome.Count());

                // Nếu support(AB) < minSup, bỏ qua
                if (supportAB < minSup) continue;

                // Tính support(A): tổng số dòng trong dataset đã lọc
                //double supportA = matchingRows.Count() / (double)totalRows;

                //AllocConsole();
                //Console.WriteLine("Số dòng age>20: " + matchingRows.Count());

                // Tính confidence
                double confidence = (double)count_matchingRowsWithOutcome / matchingRows.Count();

                // Lưu kết quả với confidence làm tròn tối đa 10 chữ số thập phân
                rules.Add((combo, supportAB, Math.Round(confidence, 10)));
            }
            return rules;
        }

        private void UpdateDataGridViewLKH(List<(List<Condition> Antecedent, double SupportAB, double Confidence)> rules, double minConf)
        {
            dgvLKH.Rows.Clear();
            validRuleCount = 0; // Reset đếm
            foreach (var (antecedent, supportAB, confidence) in rules)
            {
                int rowIndex = dgvLKH.Rows.Add();
                var row = dgvLKH.Rows[rowIndex];

                // Cột "LuatHop": Hiển thị luật với confidence dưới dạng %
                double confidencePercentValue = confidence * 100; // Chuyển thành phần trăm
                string confidencePercent = confidencePercentValue.ToString("F2"); // Làm tròn 2 chữ số nếu cần
                if (confidencePercent.EndsWith(".00"))
                    confidencePercent = confidencePercent.Substring(0, confidencePercent.Length - 3); // Loại bỏ .00
                else if (confidencePercent.Length > confidencePercent.IndexOf('.') + 3)
                    confidencePercent = confidencePercent.Substring(0, confidencePercent.IndexOf('.') + 3); // Giới hạn 2 chữ số thập phân
                row.Cells["LuatHop"].Value = $"{string.Join(" ∧ ", antecedent.Select(c => $"{c.Attribute}{c.Operator}{c.Value}"))} --> Outcome = 1 ({confidencePercent.Replace(".", ",")}%) tiểu đường";

                // Cột "DoTinCay": Hiển thị confidence dưới dạng số thực, làm tròn tối đa 10 chữ số
                string confidenceRaw = confidence.ToString("F10"); // Làm tròn 10 chữ số nếu cần
                if (confidenceRaw.EndsWith(".0000000000"))
                    confidenceRaw = confidenceRaw.Substring(0, confidenceRaw.Length - 10); // Loại bỏ .0000000000
                else if (confidenceRaw.Length > confidenceRaw.IndexOf('.') + 11)
                    confidenceRaw = confidenceRaw.Substring(0, confidenceRaw.IndexOf('.') + 11); // Giới hạn 10 chữ số thập phân
                row.Cells["DoTinCay"].Value = confidenceRaw.Replace(",", ".");

                // Tô đỏ nếu confidence < minConf
                if (confidence < minConf)
                    row.DefaultCellStyle.BackColor = Color.Red;
                else
                {
                    validRuleCount++; // Tăng đếm nếu không bị bôi đỏ
                }
            }
        }
    }

    public class ComboItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }
}