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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            TreeNode treeNode7 = new TreeNode("L1");
            TreeNode treeNode8 = new TreeNode("L2");
            TreeNode treeNode9 = new TreeNode("L3");
            TreeNode treeNode4 = new TreeNode("L1");
            TreeNode treeNode5 = new TreeNode("L2");
            TreeNode treeNode6 = new TreeNode("L3");
            groupBox2 = new GroupBox();
            cboboxThuatToan = new ComboBox();
            groupBox3 = new GroupBox();
            checkListThuocTinh = new CheckedListBox();
            dgvRoiRacGiaTri = new DataGridView();
            AttributeType = new DataGridViewTextBoxColumn();
            GreaterThan = new DataGridViewTextBoxColumn();
            RangeCategory = new DataGridViewTextBoxColumn();
            LessThan = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtMinsup = new TextBox();
            groupBox4 = new GroupBox();
            txtMinconf = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            centeredGroupBoxTapPhoBien = new CenteredGroupBox();
            btnLuu = new Button();
            btnKetQua = new Button();
            centeredGroupBoxTapLuat = new CenteredGroupBox();
            treeView2 = new TreeView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            treeView1 = new TreeView();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoiRacGiaTri).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            centeredGroupBoxTapPhoBien.SuspendLayout();
            centeredGroupBoxTapLuat.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboboxThuatToan);
            groupBox2.Location = new Point(20, 20);
            groupBox2.Margin = new Padding(20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(217, 55);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lựa chọn thuật toán";
            // 
            // cboboxThuatToan
            // 
            cboboxThuatToan.Dock = DockStyle.Top;
            cboboxThuatToan.FormattingEnabled = true;
            cboboxThuatToan.Items.AddRange(new object[] { "Apriori" });
            cboboxThuatToan.Location = new Point(3, 19);
            cboboxThuatToan.Name = "cboboxThuatToan";
            cboboxThuatToan.Size = new Size(211, 23);
            cboboxThuatToan.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkListThuocTinh);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(3, 100);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(190, 202);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lựa chọn thuộc tính áp dụng";
            // 
            // checkListThuocTinh
            // 
            checkListThuocTinh.Dock = DockStyle.Fill;
            checkListThuocTinh.FormattingEnabled = true;
            checkListThuocTinh.Items.AddRange(new object[] { "Pregnancies", "Glucose", "BloodPressure", "SkinThickness", "Insulin", "BMI", "DiabetesPedigreeFunction", "Age" });
            checkListThuocTinh.Location = new Point(3, 19);
            checkListThuocTinh.Name = "checkListThuocTinh";
            checkListThuocTinh.Size = new Size(184, 180);
            checkListThuocTinh.TabIndex = 1;
            // 
            // dgvRoiRacGiaTri
            // 
            dgvRoiRacGiaTri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRoiRacGiaTri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRoiRacGiaTri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoiRacGiaTri.Columns.AddRange(new DataGridViewColumn[] { AttributeType, GreaterThan, RangeCategory, LessThan });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvRoiRacGiaTri.DefaultCellStyle = dataGridViewCellStyle4;
            dgvRoiRacGiaTri.Dock = DockStyle.Fill;
            dgvRoiRacGiaTri.Location = new Point(340, 100);
            dgvRoiRacGiaTri.Name = "dgvRoiRacGiaTri";
            dgvRoiRacGiaTri.Size = new Size(501, 202);
            dgvRoiRacGiaTri.TabIndex = 7;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMinsup);
            groupBox1.Location = new Point(277, 20);
            groupBox1.Margin = new Padding(20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(217, 55);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "minsup";
            // 
            // txtMinsup
            // 
            txtMinsup.Dock = DockStyle.Top;
            txtMinsup.Location = new Point(3, 19);
            txtMinsup.Name = "txtMinsup";
            txtMinsup.PlaceholderText = "Phần trăm dưới dạng số thực. vd: 0.75";
            txtMinsup.Size = new Size(211, 23);
            txtMinsup.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtMinconf);
            groupBox4.Location = new Point(534, 20);
            groupBox4.Margin = new Padding(20);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(217, 55);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "minconf";
            // 
            // txtMinconf
            // 
            txtMinconf.Dock = DockStyle.Top;
            txtMinconf.Location = new Point(3, 19);
            txtMinconf.Name = "txtMinconf";
            txtMinconf.PlaceholderText = "Phần trăm dưới dạng số thực. vd: 0.75";
            txtMinconf.Size = new Size(211, 23);
            txtMinconf.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(centeredGroupBoxTapPhoBien, 0, 3);
            tableLayoutPanel1.Controls.Add(btnLuu, 1, 2);
            tableLayoutPanel1.Controls.Add(btnKetQua, 0, 2);
            tableLayoutPanel1.Controls.Add(centeredGroupBoxTapLuat, 1, 3);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvRoiRacGiaTri, 1, 1);
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
            // centeredGroupBoxTapPhoBien
            // 
            centeredGroupBoxTapPhoBien.Controls.Add(treeView1);
            centeredGroupBoxTapPhoBien.Dock = DockStyle.Fill;
            centeredGroupBoxTapPhoBien.Location = new Point(3, 343);
            centeredGroupBoxTapPhoBien.Name = "centeredGroupBoxTapPhoBien";
            centeredGroupBoxTapPhoBien.Size = new Size(331, 110);
            centeredGroupBoxTapPhoBien.TabIndex = 15;
            centeredGroupBoxTapPhoBien.TabStop = false;
            centeredGroupBoxTapPhoBien.Text = "Tập phổ biến";
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
            // centeredGroupBoxTapLuat
            // 
            centeredGroupBoxTapLuat.Controls.Add(treeView2);
            centeredGroupBoxTapLuat.Dock = DockStyle.Fill;
            centeredGroupBoxTapLuat.Location = new Point(340, 343);
            centeredGroupBoxTapLuat.Name = "centeredGroupBoxTapLuat";
            centeredGroupBoxTapLuat.Size = new Size(501, 110);
            centeredGroupBoxTapLuat.TabIndex = 9;
            centeredGroupBoxTapLuat.TabStop = false;
            centeredGroupBoxTapLuat.Text = "Tập luật";
            // 
            // treeView2
            // 
            treeView2.Dock = DockStyle.Fill;
            treeView2.Location = new Point(3, 19);
            treeView2.Name = "treeView2";
            treeNode7.Name = "L1";
            treeNode7.Text = "L1";
            treeNode8.Name = "L2";
            treeNode8.Text = "L2";
            treeNode9.Name = "L3";
            treeNode9.Text = "L3";
            treeView2.Nodes.AddRange(new TreeNode[] { treeNode7, treeNode8, treeNode9 });
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
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(3, 19);
            treeView1.Name = "treeView1";
            treeNode4.Name = "L1";
            treeNode4.Text = "L1";
            treeNode5.Name = "L2";
            treeNode5.Text = "L2";
            treeNode6.Name = "L3";
            treeNode6.Text = "L3";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode4, treeNode5, treeNode6 });
            treeView1.Size = new Size(325, 88);
            treeView1.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)dgvRoiRacGiaTri).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            centeredGroupBoxTapPhoBien.ResumeLayout(false);
            centeredGroupBoxTapLuat.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox cboboxThuatToan;
        private GroupBox groupBox3;
        private CheckedListBox checkListThuocTinh;
        private DataGridView dgvRoiRacGiaTri;
        private GroupBox groupBox1;
        private TextBox txtMinsup;
        private GroupBox groupBox4;
        private TextBox txtMinconf;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnKetQua;
        private CenteredGroupBox centeredGroupBoxTapLuat;
        private TreeView treeView2;
        private DataGridViewTextBoxColumn AttributeType;
        private DataGridViewTextBoxColumn GreaterThan;
        private DataGridViewTextBoxColumn RangeCategory;
        private DataGridViewTextBoxColumn LessThan;
        private CenteredGroupBox centeredGroupBoxTapPhoBien;
        private Button btnLuu;
        private TreeView treeView1;
    }
}
