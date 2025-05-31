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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            Ti = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            btnSaveFile = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnLoadFile = new Button();
            rowContextMenu = new ContextMenuStrip(components);
            undoDeleteMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            Ti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            rowContextMenu.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.93839F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.061615F));
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(Ti, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(btnSaveFile, 0, 2);
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
            Ti.Size = new Size(272, 107);
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
            button1.Location = new Point(190, 47);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Xử lý";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 2);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(838, 302);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.RowContextMenuStripNeeded += dataGridView1_RowContextMenuStripNeeded;
            dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;
            dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Anchor = AnchorStyles.Right;
            btnSaveFile.Location = new Point(200, 427);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(75, 23);
            btnSaveFile.TabIndex = 6;
            btnSaveFile.Text = "Save file";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnLoadFile);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(281, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 107);
            panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(309, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(134, 97);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chỉnh sửa";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(128, 44);
            label1.TabIndex = 7;
            label1.Text = "Số dòng sửa: 10\r\nSố dòng xóa: 20";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLoadFile.Location = new Point(482, 81);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(75, 23);
            btnLoadFile.TabIndex = 5;
            btnLoadFile.Text = "Load file";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // rowContextMenu
            // 
            rowContextMenu.Items.AddRange(new ToolStripItem[] { undoDeleteMenuItem });
            rowContextMenu.Name = "contextMenuStrip1";
            rowContextMenu.Size = new Size(110, 26);
            // 
            // undoDeleteMenuItem
            // 
            undoDeleteMenuItem.Name = "undoDeleteMenuItem";
            undoDeleteMenuItem.Size = new Size(109, 22);
            undoDeleteMenuItem.Text = "Bỏ xóa";
            undoDeleteMenuItem.Click += undoDeleteMenuItem_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(647, 421);
            label2.Name = "label2";
            label2.Size = new Size(194, 35);
            label2.TabIndex = 10;
            label2.Text = "Các dòng trùng lặp: 2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(276, 89);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Các version";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(4, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 23);
            comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(4, 53);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tên version...";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(196, 52);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Thêm";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(195, 22);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 66);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 8;
            button2.Text = "Xác nhận thay đổi";
            button2.UseVisualStyleBackColor = true;
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
            rowContextMenu.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Label label1;
        private ContextMenuStrip rowContextMenu;
        private ToolStripMenuItem undoDeleteMenuItem;
        private Label label2;
        private GroupBox groupBox2;
        private Button button4;
        private Button button3;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button2;
    }
}
