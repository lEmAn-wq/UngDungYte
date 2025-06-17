namespace UngDungYte
{
    partial class DatasetView
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
            dgvDataset = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            grboxLuaChon = new GroupBox();
            cboLuaChon = new ComboBox();
            grboxDKLocTuChon = new GroupBox();
            cboDieuKienLocTuChon = new ComboBox();
            btnXoa = new Button();
            btnXacNhan = new Button();
            lblSoDong = new Label();
            flpDieuKien = new FlowLayoutPanel();
            groupBox5 = new GroupBox();
            cboThuocTinh = new ComboBox();
            groupBox6 = new GroupBox();
            cboDieuKien = new ComboBox();
            groupBox7 = new GroupBox();
            txtGiaTri = new TextBox();
            btnThem = new Button();
            btnLoadFile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDataset).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            grboxLuaChon.SuspendLayout();
            grboxDKLocTuChon.SuspendLayout();
            flpDieuKien.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDataset
            // 
            dgvDataset.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataset.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dgvDataset, 2);
            dgvDataset.Dock = DockStyle.Fill;
            dgvDataset.Location = new Point(3, 164);
            dgvDataset.Name = "dgvDataset";
            dgvDataset.Size = new Size(838, 289);
            dgvDataset.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 768F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flpDieuKien, 1, 0);
            tableLayoutPanel1.Controls.Add(dgvDataset, 0, 2);
            tableLayoutPanel1.Controls.Add(btnLoadFile, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(844, 456);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(grboxLuaChon);
            flowLayoutPanel1.Controls.Add(grboxDKLocTuChon);
            flowLayoutPanel1.Controls.Add(btnXoa);
            flowLayoutPanel1.Controls.Add(btnXacNhan);
            flowLayoutPanel1.Controls.Add(lblSoDong);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(762, 67);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // grboxLuaChon
            // 
            grboxLuaChon.Controls.Add(cboLuaChon);
            grboxLuaChon.Location = new Point(30, 3);
            grboxLuaChon.Margin = new Padding(30, 3, 3, 3);
            grboxLuaChon.Name = "grboxLuaChon";
            grboxLuaChon.Size = new Size(185, 52);
            grboxLuaChon.TabIndex = 10;
            grboxLuaChon.TabStop = false;
            grboxLuaChon.Text = "Lựa chọn";
            // 
            // cboLuaChon
            // 
            cboLuaChon.Dock = DockStyle.Fill;
            cboLuaChon.FormattingEnabled = true;
            cboLuaChon.Items.AddRange(new object[] { "--Tất cả--", "Có tiểu đường", "Không tiểu đường", "Lọc theo điều kiện tự chọn" });
            cboLuaChon.Location = new Point(3, 19);
            cboLuaChon.Margin = new Padding(10, 20, 10, 10);
            cboLuaChon.Name = "cboLuaChon";
            cboLuaChon.Size = new Size(179, 23);
            cboLuaChon.TabIndex = 1;
            cboLuaChon.SelectedIndexChanged += cboLuaChon_SelectedIndexChanged;
            // 
            // grboxDKLocTuChon
            // 
            grboxDKLocTuChon.Controls.Add(cboDieuKienLocTuChon);
            grboxDKLocTuChon.Location = new Point(248, 3);
            grboxDKLocTuChon.Margin = new Padding(30, 3, 3, 3);
            grboxDKLocTuChon.Name = "grboxDKLocTuChon";
            grboxDKLocTuChon.Size = new Size(138, 52);
            grboxDKLocTuChon.TabIndex = 8;
            grboxDKLocTuChon.TabStop = false;
            grboxDKLocTuChon.Text = "Điều kiện lọc tự chọn";
            grboxDKLocTuChon.Visible = false;
            // 
            // cboDieuKienLocTuChon
            // 
            cboDieuKienLocTuChon.Dock = DockStyle.Fill;
            cboDieuKienLocTuChon.FormattingEnabled = true;
            cboDieuKienLocTuChon.Location = new Point(3, 19);
            cboDieuKienLocTuChon.Margin = new Padding(10);
            cboDieuKienLocTuChon.Name = "cboDieuKienLocTuChon";
            cboDieuKienLocTuChon.Size = new Size(132, 23);
            cboDieuKienLocTuChon.TabIndex = 2;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(399, 20);
            btnXoa.Margin = new Padding(10, 20, 3, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(53, 23);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(495, 20);
            btnXacNhan.Margin = new Padding(40, 20, 3, 3);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(75, 23);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // lblSoDong
            // 
            lblSoDong.BorderStyle = BorderStyle.FixedSingle;
            lblSoDong.Location = new Point(613, 20);
            lblSoDong.Margin = new Padding(40, 20, 20, 20);
            lblSoDong.Name = "lblSoDong";
            lblSoDong.Size = new Size(119, 23);
            lblSoDong.TabIndex = 9;
            lblSoDong.Text = "Số dòng: ";
            lblSoDong.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpDieuKien
            // 
            tableLayoutPanel1.SetColumnSpan(flpDieuKien, 2);
            flpDieuKien.Controls.Add(groupBox5);
            flpDieuKien.Controls.Add(groupBox6);
            flpDieuKien.Controls.Add(groupBox7);
            flpDieuKien.Controls.Add(btnThem);
            flpDieuKien.Dock = DockStyle.Fill;
            flpDieuKien.Location = new Point(3, 76);
            flpDieuKien.Name = "flpDieuKien";
            flpDieuKien.Size = new Size(838, 82);
            flpDieuKien.TabIndex = 10;
            flpDieuKien.Visible = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cboThuocTinh);
            groupBox5.Location = new Point(20, 20);
            groupBox5.Margin = new Padding(20);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(141, 55);
            groupBox5.TabIndex = 13;
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
            cboThuocTinh.Size = new Size(135, 23);
            cboThuocTinh.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(cboDieuKien);
            groupBox6.Location = new Point(201, 20);
            groupBox6.Margin = new Padding(20);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(141, 55);
            groupBox6.TabIndex = 14;
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
            cboDieuKien.Size = new Size(135, 23);
            cboDieuKien.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtGiaTri);
            groupBox7.Location = new Point(382, 20);
            groupBox7.Margin = new Padding(20);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(141, 55);
            groupBox7.TabIndex = 15;
            groupBox7.TabStop = false;
            groupBox7.Text = "Giá trị cho điều kiện";
            // 
            // txtGiaTri
            // 
            txtGiaTri.Dock = DockStyle.Top;
            txtGiaTri.Location = new Point(3, 19);
            txtGiaTri.Name = "txtGiaTri";
            txtGiaTri.Size = new Size(135, 23);
            txtGiaTri.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(563, 35);
            btnThem.Margin = new Padding(20, 35, 10, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(53, 23);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoadFile.Location = new Point(771, 3);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(70, 23);
            btnLoadFile.TabIndex = 4;
            btnLoadFile.Text = "Load file";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // DatasetView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "DatasetView";
            Size = new Size(844, 456);
            ((System.ComponentModel.ISupportInitialize)dgvDataset).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            grboxLuaChon.ResumeLayout(false);
            grboxDKLocTuChon.ResumeLayout(false);
            flpDieuKien.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDataset;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnLoadFile;
        private FlowLayoutPanel flpDieuKien;
        private GroupBox groupBox5;
        private ComboBox cboThuocTinh;
        private GroupBox groupBox6;
        private ComboBox cboDieuKien;
        private GroupBox groupBox7;
        private TextBox txtGiaTri;
        private Button btnThem;
        private Button btnXoa;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox grboxDKLocTuChon;
        private ComboBox cboDieuKienLocTuChon;
        private Button btnXacNhan;
        private Label lblSoDong;
        private GroupBox grboxLuaChon;
        private ComboBox cboLuaChon;
    }
}
