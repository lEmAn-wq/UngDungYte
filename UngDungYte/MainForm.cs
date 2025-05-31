namespace UngDungYte
{
    public partial class MainForm : Form
    {
        DatasetView datasetView = new DatasetView();
        PatientSegmentationView patientSegmentationView = new PatientSegmentationView();
        AssociationRuleMiningView associationRuleMiningView = new AssociationRuleMiningView();
        CreateDiagnosisModelView createDiagnosisModelView = new CreateDiagnosisModelView();
        public MainForm()
        {
            InitializeComponent();
        }

        #region Điều hướng
        private Dictionary<string, UserControl> loadedViews = new Dictionary<string, UserControl>();

        private void fileCleaningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Làm sạch dữ liệu";
            UIHelper.LoadUserControlToPanel(panel1, new FileCleaningView());
        }

        private void datasetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Bộ dữ liệu";
            UIHelper.LoadUserControlToPanel(panel1, datasetView);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Chẩn đoán tiểu đường";
            UIHelper.LoadUserControlToPanel(panel1, new TestView());
        }

        private void dataSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Biểu đồ thống kê";
            UIHelper.LoadUserControlToPanel(panel1, new DataSummaryView());
        }

        private void patientSegmentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Phân khúc dữ liệu y khoa – Chọn thuật toán && Đầu ra";
            UIHelper.LoadUserControlToPanel(panel1, patientSegmentationView);
        }

        private void correlationAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Khám phá tương quan – Biểu đồ && bảng số liệu";
            UIHelper.LoadUserControlToPanel(panel1, new CorrelationAnalysisView());
        }

        private void associationRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Khai phá luật kết hợp – Từ dữ liệu đến luật";
            UIHelper.LoadUserControlToPanel(panel1, associationRuleMiningView);
        }

        private void diagnosisSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTieuDe.Text = "Xây dựng chẩn đoán – Chọn thuật toán && Kết quả";
            UIHelper.LoadUserControlToPanel(panel1, new CreateDiagnosisModelView());
        }

        #endregion
    }
}
