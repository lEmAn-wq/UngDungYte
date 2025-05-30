namespace UngDungYte
{
    partial class AssociationRuleMiningView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox3 = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox4 = new GroupBox();
            textBox2 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnKetQua = new Button();
            centeredGroupBox1 = new CenteredGroupBox();
            treeView2 = new TreeView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnLuu = new Button();
            centeredGroupBox2 = new CenteredGroupBox();
            treeView1 = new TreeView();
            AttributeType = new DataGridViewTextBoxColumn();
            GreaterThan = new DataGridViewTextBoxColumn();
            RangeCategory = new DataGridViewTextBoxColumn();
            LessThan = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            centeredGroupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            centeredGroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(20, 20);
            groupBox2.Margin = new Padding(20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(217, 55);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lựa chọn thuật toán";
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Top;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 23);
            comboBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkedListBox1);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(3, 100);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(190, 202);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lựa chọn thuộc tính áp dụng";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Dock = DockStyle.Fill;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Pregnancies", "Glucose", "BloodPressure", "SkinThickness", "Insulin", "BMI", "DiabetesPedigreeFunction", "Age" });
            checkedListBox1.Location = new Point(3, 19);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(184, 180);
            checkedListBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AttributeType, GreaterThan, RangeCategory, LessThan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(340, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(501, 202);
            dataGridView1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(277, 20);
            groupBox1.Margin = new Padding(20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(217, 55);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "minsup";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(3, 19);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Phần trăm dưới dạng số thực. vd: 0.75";
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox2);
            groupBox4.Location = new Point(534, 20);
            groupBox4.Margin = new Padding(20);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(217, 55);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "minconf";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Top;
            textBox2.Location = new Point(3, 19);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Phần trăm dưới dạng số thực. vd: 0.75";
            textBox2.Size = new Size(211, 23);
            textBox2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(centeredGroupBox2, 0, 3);
            tableLayoutPanel1.Controls.Add(btnLuu, 1, 2);
            tableLayoutPanel1.Controls.Add(btnKetQua, 0, 2);
            tableLayoutPanel1.Controls.Add(centeredGroupBox1, 1, 3);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 208F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(844, 456);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // btnKetQua
            // 
            btnKetQua.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnKetQua.Location = new Point(3, 314);
            btnKetQua.Name = "btnKetQua";
            btnKetQua.Size = new Size(75, 23);
            btnKetQua.TabIndex = 7;
            btnKetQua.Text = "Kết quả";
            btnKetQua.UseVisualStyleBackColor = true;
            // 
            // centeredGroupBox1
            // 
            centeredGroupBox1.Controls.Add(treeView2);
            centeredGroupBox1.Dock = DockStyle.Fill;
            centeredGroupBox1.Location = new Point(340, 343);
            centeredGroupBox1.Name = "centeredGroupBox1";
            centeredGroupBox1.Size = new Size(501, 110);
            centeredGroupBox1.TabIndex = 9;
            centeredGroupBox1.TabStop = false;
            centeredGroupBox1.Text = "Tập luật";
            // 
            // treeView2
            // 
            treeView2.Dock = DockStyle.Fill;
            treeView2.Location = new Point(3, 19);
            treeView2.Name = "treeView2";
            treeView2.Size = new Size(495, 88);
            treeView2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(838, 91);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuu.Location = new Point(718, 314);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(123, 23);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Áp dụng hệ thống";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // centeredGroupBox2
            // 
            centeredGroupBox2.Controls.Add(treeView1);
            centeredGroupBox2.Dock = DockStyle.Fill;
            centeredGroupBox2.Location = new Point(3, 343);
            centeredGroupBox2.Name = "centeredGroupBox2";
            centeredGroupBox2.Size = new Size(331, 110);
            centeredGroupBox2.TabIndex = 15;
            centeredGroupBox2.TabStop = false;
            centeredGroupBox2.Text = "Tập phổ biến";
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(3, 19);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(325, 88);
            treeView1.TabIndex = 0;
            // 
            // AttributeType
            // 
            AttributeType.FillWeight = 40F;
            AttributeType.HeaderText = "Loại thuộc tính";
            AttributeType.Name = "AttributeType";
            // 
            // GreaterThan
            // 
            GreaterThan.FillWeight = 30F;
            GreaterThan.HeaderText = "Lớn hơn";
            GreaterThan.Name = "GreaterThan";
            // 
            // RangeCategory
            // 
            RangeCategory.FillWeight = 50F;
            RangeCategory.HeaderText = "Giá trị trong khoảng";
            RangeCategory.Name = "RangeCategory";
            RangeCategory.Resizable = DataGridViewTriState.True;
            // 
            // LessThan
            // 
            LessThan.FillWeight = 30F;
            LessThan.HeaderText = "Nhỏ hơn";
            LessThan.Name = "LessThan";
            // 
            // AssociationRuleMiningView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "AssociationRuleMiningView";
            Size = new Size(844, 456);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            centeredGroupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            centeredGroupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private CheckedListBox checkedListBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox4;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnKetQua;
        private CenteredGroupBox centeredGroupBox1;
        private TreeView treeView2;
        private DataGridViewTextBoxColumn AttributeType;
        private DataGridViewTextBoxColumn GreaterThan;
        private DataGridViewTextBoxColumn RangeCategory;
        private DataGridViewTextBoxColumn LessThan;
        private CenteredGroupBox centeredGroupBox2;
        private TreeView treeView1;
        private Button btnLuu;
    }
}
