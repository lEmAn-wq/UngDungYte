namespace UngDungYte
{
    partial class PatientSegmentationView
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
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            groupBox4 = new GroupBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            btnApDung = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 53);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lựa chọn thuật toán";
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Top;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 23);
            comboBox1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Dock = DockStyle.Fill;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Pregnancies", "Glucose", "BloodPressure", "SkinThickness", "Insulin", "BMI", "DiabetesPedigreeFunction", "Age" });
            checkedListBox1.Location = new Point(3, 19);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(193, 154);
            checkedListBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkedListBox1);
            groupBox2.Location = new Point(249, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(199, 176);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lựa chọn thuộc tính áp dụng";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Location = new Point(24, 130);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(133, 55);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Số cụm cần tạo";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(3, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox2);
            groupBox4.Location = new Point(18, 71);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 53);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hàm đo khoảng cách";
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Top;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(3, 19);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(194, 23);
            comboBox2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(111, 260);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 5;
            button1.Text = "Đặt cảnh báo";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnApDung
            // 
            btnApDung.Location = new Point(385, 217);
            btnApDung.Name = "btnApDung";
            btnApDung.Size = new Size(75, 23);
            btnApDung.TabIndex = 6;
            btnApDung.Text = "Áp dụng";
            btnApDung.UseVisualStyleBackColor = true;
            // 
            // PatientSegmentationView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnApDung);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "PatientSegmentationView";
            Size = new Size(844, 456);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private CheckedListBox checkedListBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private GroupBox groupBox4;
        private ComboBox comboBox2;
        private Button button1;
        private Button btnApDung;
    }
}
