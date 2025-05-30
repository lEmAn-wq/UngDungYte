namespace UngDungYte
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileCleaningToolStripMenuItem = new ToolStripMenuItem();
            datasetToolStripMenuItem = new ToolStripMenuItem();
            statisticalAnalysisToolStripMenuItem = new ToolStripMenuItem();
            dataSummaryToolStripMenuItem = new ToolStripMenuItem();
            patientSegmentationToolStripMenuItem = new ToolStripMenuItem();
            correlationAnalysisToolStripMenuItem = new ToolStripMenuItem();
            diagnosisSupportToolStripMenuItem = new ToolStripMenuItem();
            associationRulesToolStripMenuItem1 = new ToolStripMenuItem();
            testToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelTieuDe = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileCleaningToolStripMenuItem, datasetToolStripMenuItem, statisticalAnalysisToolStripMenuItem, testToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(850, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileCleaningToolStripMenuItem
            // 
            fileCleaningToolStripMenuItem.Name = "fileCleaningToolStripMenuItem";
            fileCleaningToolStripMenuItem.Size = new Size(87, 20);
            fileCleaningToolStripMenuItem.Text = "File Cleaning";
            fileCleaningToolStripMenuItem.Click += fileCleaningToolStripMenuItem_Click;
            // 
            // datasetToolStripMenuItem
            // 
            datasetToolStripMenuItem.Name = "datasetToolStripMenuItem";
            datasetToolStripMenuItem.Size = new Size(58, 20);
            datasetToolStripMenuItem.Text = "Dataset";
            datasetToolStripMenuItem.Click += datasetToolStripMenuItem_Click;
            // 
            // statisticalAnalysisToolStripMenuItem
            // 
            statisticalAnalysisToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dataSummaryToolStripMenuItem, patientSegmentationToolStripMenuItem, correlationAnalysisToolStripMenuItem, diagnosisSupportToolStripMenuItem, associationRulesToolStripMenuItem1 });
            statisticalAnalysisToolStripMenuItem.Name = "statisticalAnalysisToolStripMenuItem";
            statisticalAnalysisToolStripMenuItem.Size = new Size(84, 20);
            statisticalAnalysisToolStripMenuItem.Text = "Data Mining";
            // 
            // dataSummaryToolStripMenuItem
            // 
            dataSummaryToolStripMenuItem.Name = "dataSummaryToolStripMenuItem";
            dataSummaryToolStripMenuItem.Size = new Size(202, 22);
            dataSummaryToolStripMenuItem.Text = "Data Summary";
            dataSummaryToolStripMenuItem.Click += dataSummaryToolStripMenuItem_Click;
            // 
            // patientSegmentationToolStripMenuItem
            // 
            patientSegmentationToolStripMenuItem.Name = "patientSegmentationToolStripMenuItem";
            patientSegmentationToolStripMenuItem.Size = new Size(202, 22);
            patientSegmentationToolStripMenuItem.Text = "Patient Segmentation";
            patientSegmentationToolStripMenuItem.Click += patientSegmentationToolStripMenuItem_Click;
            // 
            // correlationAnalysisToolStripMenuItem
            // 
            correlationAnalysisToolStripMenuItem.Name = "correlationAnalysisToolStripMenuItem";
            correlationAnalysisToolStripMenuItem.Size = new Size(202, 22);
            correlationAnalysisToolStripMenuItem.Text = "Correlation Analysis";
            correlationAnalysisToolStripMenuItem.Click += correlationAnalysisToolStripMenuItem_Click;
            // 
            // diagnosisSupportToolStripMenuItem
            // 
            diagnosisSupportToolStripMenuItem.Name = "diagnosisSupportToolStripMenuItem";
            diagnosisSupportToolStripMenuItem.Size = new Size(202, 22);
            diagnosisSupportToolStripMenuItem.Text = "Create Diagnosis Model";
            diagnosisSupportToolStripMenuItem.Click += diagnosisSupportToolStripMenuItem_Click;
            // 
            // associationRulesToolStripMenuItem1
            // 
            associationRulesToolStripMenuItem1.Name = "associationRulesToolStripMenuItem1";
            associationRulesToolStripMenuItem1.Size = new Size(202, 22);
            associationRulesToolStripMenuItem1.Text = "Association Rule Mining";
            associationRulesToolStripMenuItem1.Click += associationRulesToolStripMenuItem_Click;
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(40, 20);
            testToolStripMenuItem.Text = "Test";
            testToolStripMenuItem.Click += testToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelTieuDe, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 108F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(850, 570);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // labelTieuDe
            // 
            labelTieuDe.BackColor = Color.WhiteSmoke;
            labelTieuDe.Dock = DockStyle.Fill;
            labelTieuDe.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTieuDe.ForeColor = Color.FromArgb(41, 128, 185);
            labelTieuDe.Location = new Point(3, 0);
            labelTieuDe.Name = "labelTieuDe";
            labelTieuDe.Size = new Size(844, 108);
            labelTieuDe.TabIndex = 10;
            labelTieuDe.Text = "Diabetes Insight: Ứng dụng phân tích, thống kê và chẩn đoán từ dữ liệu tiểu đường";
            labelTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 456);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(844, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 594);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileCleaningToolStripMenuItem;
        private ToolStripMenuItem datasetToolStripMenuItem;
        private ToolStripMenuItem statisticalAnalysisToolStripMenuItem;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem dataSummaryToolStripMenuItem;
        private ToolStripMenuItem patientSegmentationToolStripMenuItem;
        private ToolStripMenuItem correlationAnalysisToolStripMenuItem;
        private ToolStripMenuItem diagnosisSupportToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelTieuDe;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem associationRulesToolStripMenuItem1;
    }
}
