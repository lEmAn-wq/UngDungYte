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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvRoiRacGiaTri = new DataGridView();
            groupBox1 = new GroupBox();
            txtMinsup = new TextBox();
            groupBox4 = new GroupBox();
            txtMinconf = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            dgvLKH = new DataGridView();
            LKH = new DataGridViewTextBoxColumn();
            Conf = new DataGridViewTextBoxColumn();
            flowLayoutPanel3 = new FlowLayoutPanel();
            groupBox5 = new GroupBox();
            cboThuocTinh = new ComboBox();
            groupBox6 = new GroupBox();
            cboDieuKien = new ComboBox();
            groupBox7 = new GroupBox();
            txtGiaTri = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnThucThi = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblSoLuat = new Label();
            lblSoLuatHopLe = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRoiRacGiaTri).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLKH).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRoiRacGiaTri
            // 
            dgvRoiRacGiaTri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRoiRacGiaTri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRoiRacGiaTri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRoiRacGiaTri.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRoiRacGiaTri.Dock = DockStyle.Fill;
            dgvRoiRacGiaTri.Location = new Point(410, 72);
            dgvRoiRacGiaTri.Name = "dgvRoiRacGiaTri";
            dgvRoiRacGiaTri.ReadOnly = true;
            dgvRoiRacGiaTri.Size = new Size(431, 182);
            dgvRoiRacGiaTri.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMinsup);
            groupBox1.Location = new Point(20, 3);
            groupBox1.Margin = new Padding(20, 3, 20, 3);
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
            groupBox4.Location = new Point(277, 3);
            groupBox4.Margin = new Padding(20, 3, 20, 3);
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.2227478F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.7772522F));
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 3);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(btnThucThi, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvRoiRacGiaTri, 1, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 188F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(844, 456);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // groupBox3
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox3, 2);
            groupBox3.Controls.Add(dgvLKH);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(20, 312);
            groupBox3.Margin = new Padding(20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(804, 124);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kết quả";
            // 
            // dgvLKH
            // 
            dgvLKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLKH.Columns.AddRange(new DataGridViewColumn[] { LKH, Conf });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvLKH.DefaultCellStyle = dataGridViewCellStyle4;
            dgvLKH.Dock = DockStyle.Fill;
            dgvLKH.Location = new Point(3, 19);
            dgvLKH.Name = "dgvLKH";
            dgvLKH.ReadOnly = true;
            dgvLKH.Size = new Size(798, 102);
            dgvLKH.TabIndex = 8;
            // 
            // LKH
            // 
            LKH.HeaderText = "Luật kết hợp";
            LKH.Name = "LKH";
            LKH.ReadOnly = true;
            // 
            // Conf
            // 
            Conf.HeaderText = "Độ tin cậy";
            Conf.Name = "Conf";
            Conf.ReadOnly = true;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(groupBox5);
            flowLayoutPanel3.Controls.Add(groupBox6);
            flowLayoutPanel3.Controls.Add(groupBox7);
            flowLayoutPanel3.Controls.Add(btnThem);
            flowLayoutPanel3.Controls.Add(btnXoa);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 72);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(401, 182);
            flowLayoutPanel3.TabIndex = 18;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cboThuocTinh);
            groupBox5.Location = new Point(20, 20);
            groupBox5.Margin = new Padding(20);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(133, 55);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Lựa chọn thuộc tính";
            // 
            // cboThuocTinh
            // 
            cboThuocTinh.Dock = DockStyle.Top;
            cboThuocTinh.FormattingEnabled = true;
            cboThuocTinh.Items.AddRange(new object[] { "Pregnancies", "Glucose", "BloodPressure", "SkinThickness", "Insulin", "BMI", "DiabetesPedigreeFunction", "Age" });
            cboThuocTinh.Location = new Point(3, 19);
            cboThuocTinh.Name = "cboThuocTinh";
            cboThuocTinh.Size = new Size(127, 23);
            cboThuocTinh.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(cboDieuKien);
            groupBox6.Location = new Point(193, 20);
            groupBox6.Margin = new Padding(20);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(133, 55);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Lựa chọn điều kiện";
            // 
            // cboDieuKien
            // 
            cboDieuKien.Dock = DockStyle.Top;
            cboDieuKien.FormattingEnabled = true;
            cboDieuKien.Items.AddRange(new object[] { ">", "<" });
            cboDieuKien.Location = new Point(3, 19);
            cboDieuKien.Name = "cboDieuKien";
            cboDieuKien.Size = new Size(127, 23);
            cboDieuKien.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtGiaTri);
            groupBox7.Location = new Point(20, 115);
            groupBox7.Margin = new Padding(20);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(133, 55);
            groupBox7.TabIndex = 10;
            groupBox7.TabStop = false;
            groupBox7.Text = "Giá trị cho điều kiện";
            // 
            // txtGiaTri
            // 
            txtGiaTri.Dock = DockStyle.Top;
            txtGiaTri.Location = new Point(3, 19);
            txtGiaTri.Name = "txtGiaTri";
            txtGiaTri.Size = new Size(127, 23);
            txtGiaTri.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(183, 125);
            btnThem.Margin = new Padding(10, 30, 10, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(278, 125);
            btnXoa.Margin = new Padding(10, 30, 10, 30);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThucThi
            // 
            btnThucThi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnThucThi.Location = new Point(3, 266);
            btnThucThi.Name = "btnThucThi";
            btnThucThi.Size = new Size(75, 23);
            btnThucThi.TabIndex = 7;
            btnThucThi.Text = "Thực thi";
            btnThucThi.UseVisualStyleBackColor = true;
            btnThucThi.Click += btnThucThi_Click;
            // 
            // flowLayoutPanel1
            // 
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(838, 63);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblSoLuat);
            flowLayoutPanel2.Controls.Add(lblSoLuatHopLe);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(410, 260);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(431, 29);
            flowLayoutPanel2.TabIndex = 20;
            // 
            // lblSoLuat
            // 
            lblSoLuat.BorderStyle = BorderStyle.FixedSingle;
            lblSoLuat.Location = new Point(3, 3);
            lblSoLuat.Margin = new Padding(3);
            lblSoLuat.Name = "lblSoLuat";
            lblSoLuat.Size = new Size(152, 23);
            lblSoLuat.TabIndex = 10;
            lblSoLuat.Text = "Tổng số luật: ";
            lblSoLuat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSoLuatHopLe
            // 
            lblSoLuatHopLe.BorderStyle = BorderStyle.FixedSingle;
            lblSoLuatHopLe.Location = new Point(238, 3);
            lblSoLuatHopLe.Margin = new Padding(80, 3, 3, 3);
            lblSoLuatHopLe.Name = "lblSoLuatHopLe";
            lblSoLuatHopLe.Size = new Size(152, 23);
            lblSoLuatHopLe.TabIndex = 11;
            lblSoLuatHopLe.Text = "Số luật hợp lệ: ";
            lblSoLuatHopLe.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AssociationRuleMiningView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "AssociationRuleMiningView";
            Size = new Size(844, 456);
            ((System.ComponentModel.ISupportInitialize)dgvRoiRacGiaTri).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLKH).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvRoiRacGiaTri;
        private GroupBox groupBox1;
        private TextBox txtMinsup;
        private GroupBox groupBox4;
        private TextBox txtMinconf;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnThucThi;
        private FlowLayoutPanel flowLayoutPanel3;
        private GroupBox groupBox5;
        private ComboBox cboThuocTinh;
        private GroupBox groupBox6;
        private ComboBox cboDieuKien;
        private GroupBox groupBox7;
        private TextBox txtGiaTri;
        private Button btnThem;
        private Button btnXoa;
        private GroupBox groupBox3;
        private DataGridView dgvLKH;
        private DataGridViewTextBoxColumn LKH;
        private DataGridViewTextBoxColumn Conf;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblSoLuat;
        private Label lblSoLuatHopLe;
    }
}
