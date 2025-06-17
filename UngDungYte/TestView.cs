using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static UngDungYte.AssociationRuleMiningView;

namespace UngDungYte
{
    public partial class TestView : UserControl
    {
        public TestView()
        {
            InitializeComponent();
        }
        private bool IsRuleMatch(List<Condition> input, List<Condition> rule)
        {
            return rule.All(r =>
            {
                var inputVal = input.FirstOrDefault(i => i.Attribute == r.Attribute)?.Value ?? double.NaN;
                return r.Operator switch
                {
                    ">" => inputVal > r.Value,
                    "<" => inputVal < r.Value,
                    _ => false
                };
            });
        }
        private bool IsSubset(List<Condition> subset, List<Condition> superset)
        {
            return subset.All(s =>
                superset.Any(ss =>
                    ss.Attribute == s.Attribute &&
                    ss.Operator == s.Operator &&
                    ss.Value == s.Value));
        }

        private void LKH()
        {
            string input = string.Join(",", new[] {
        txtPregnancies.Text, txtGlucose.Text, txtBloodPressure.Text, txtSkinThickness.Text,
        txtInsulin.Text, txtBMI.Text, txtDiabetesPedigreeFunction.Text, txtAge.Text
    });

            if (!AssociationRuleMiningView.SavedRules.Any())
            {
                lblLKH.Text = "Không có luật nào từ dữ liệu kết hợp để chẩn đoán.";
                return;
            }

            var inputValues = input.Split(',').Select(double.Parse).ToArray();
            var attributes = new[] { "Pregnancies", "Glucose", "BloodPressure", "SkinThickness", "Insulin", "BMI", "DiabetesPedigreeFunction", "Age" };
            var inputConditions = new List<Condition>();

            for (int i = 0; i < inputValues.Length; i++)
                inputConditions.Add(new Condition(attributes[i], "", inputValues[i]));

            // Lấy các luật phù hợp với input
            var matchingRules = AssociationRuleMiningView.SavedRules
                .Where(r => IsRuleMatch(inputConditions, r.Antecedent))
                .ToList();

            if (!matchingRules.Any())
            {
                lblLKH.Text = "Không có luật nào phù hợp từ dữ liệu kết hợp.";
                return;
            }

            // Lấy các luật có độ tin cậy cao nhất
            double maxConfidence = matchingRules.Max(r => r.Confidence);
            var topRules = matchingRules.Where(r => Math.Abs(r.Confidence - maxConfidence) < 1e-9).ToList();

            // Lọc bỏ các luật bị bao bởi luật khác
            var filteredRules = topRules
                .Where(r1 => !topRules.Any(r2 =>
                    r2 != r1 && IsSubset(r1.Antecedent, r2.Antecedent)))
                .ToList();

            string ruleText = string.Join(" or ", filteredRules.Select(r =>
                "(" + string.Join(" ∧ ", r.Antecedent.Select(c => $"{c.Attribute}{c.Operator}{c.Value}")) + ")"
            ));

            lblLKH.Text = $"Thống kê cho thấy, nếu {ruleText} thì {maxConfidence * 100:F2}% bị tiểu đường.";
        }
        private void logistic()
        {
            string input = string.Join(",", new[] {
            txtPregnancies.Text, txtGlucose.Text, txtBloodPressure.Text, txtSkinThickness.Text,
            txtInsulin.Text, txtBMI.Text, txtDiabetesPedigreeFunction.Text, txtAge.Text
        });

            string basePath = Path.Combine(Application.StartupPath, "script");
            string filepath = Path.Combine(basePath, "script.py");
            //string resultFilePath = Path.Combine(basePath, "result.txt");

            string pythonPath = @"C:\Users\Admin\AppData\Local\Programs\Python\Python312\python.exe";

            var startInfo = new ProcessStartInfo
            {
                FileName = pythonPath,
                Arguments = $"\"{filepath}\" {input}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            startInfo.StandardOutputEncoding = System.Text.Encoding.UTF8;
            startInfo.StandardErrorEncoding = System.Text.Encoding.UTF8;

            using var process = Process.Start(startInfo);
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            lblDuDoanLogistic.Text = output; // Gán kết quả trực tiếp

            //lblDuDoan.Text = File.Exists(resultFilePath) ? File.ReadAllText(resultFilePath) : "Không tìm thấy file kết quả";

            if (!string.IsNullOrWhiteSpace(error))
                UIHelper.ShowMessageError("Lỗi Python: " + error);
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                logistic();
                 LKH(); 
            }
            catch (Exception ex)
            {
                UIHelper.ShowMessageError("Lỗi: " + ex.Message);
            }
        }
    }
}
