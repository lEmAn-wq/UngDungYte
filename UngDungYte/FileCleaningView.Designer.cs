namespace UngDungYte
{
    partial class FileCleaningView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            Ti = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            btnSaveFile = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label1 = new Label();
            btnLoadFile = new Button();
            tableLayoutPanel1.SuspendLayout();
            Ti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Ti, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(btnSaveFile, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 113F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(844, 456);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Ti
            // 
            Ti.Controls.Add(checkedListBox1);
            Ti.Controls.Add(button1);
            Ti.Location = new Point(3, 3);
            Ti.Name = "Ti";
            Ti.Size = new Size(327, 107);
            Ti.TabIndex = 3;
            Ti.TabStop = false;
            Ti.Text = "Tiền xử lý";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Dock = DockStyle.Left;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Xử lý thiếu", "Xử lý nhiễu", "Xử lý trùng lặp" });
            checkedListBox1.Location = new Point(3, 19);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(181, 85);
            checkedListBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(246, 57);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Xử lý";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 2);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(838, 302);
            dataGridView1.TabIndex = 5;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(btnSaveFile, 2);
            btnSaveFile.Location = new Point(384, 424);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(75, 23);
            btnSaveFile.TabIndex = 6;
            btnSaveFile.Text = "Save file";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnLoadFile);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(425, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 107);
            panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 97);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chỉnh sửa";
            // 
            // button2
            // 
            button2.Location = new Point(40, 66);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 8;
            button2.Text = "Xác nhận thay đổi";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(194, 44);
            label1.TabIndex = 7;
            label1.Text = "Số dòng sửa: 10\r\nSố dòng xóa: 20";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLoadFile.Location = new Point(338, 81);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(75, 23);
            btnLoadFile.TabIndex = 5;
            btnLoadFile.Text = "Load file";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // FileCleaningView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "FileCleaningView";
            Size = new Size(844, 456);
            tableLayoutPanel1.ResumeLayout(false);
            Ti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox Ti;
        private Button button1;
        private DataGridView dataGridView1;
        private Button btnSaveFile;
        private Panel panel1;
        private Button btnLoadFile;
        private CheckedListBox checkedListBox1;
        private GroupBox groupBox1;
        private Button button2;
        private Label label1;
    }
}
