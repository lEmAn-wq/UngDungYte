namespace UngDungYte
{
    partial class CreateDiagnosisModelView
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
            groupBox2 = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            btnApDung = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(209, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 53);
            groupBox1.TabIndex = 3;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(checkedListBox1);
            groupBox2.Location = new Point(437, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(199, 176);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lựa chọn thuộc tính áp dụng";
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
            // btnApDung
            // 
            btnApDung.Location = new Point(132, 256);
            btnApDung.Name = "btnApDung";
            btnApDung.Size = new Size(75, 23);
            btnApDung.TabIndex = 5;
            btnApDung.Text = "Áp dụng";
            btnApDung.UseVisualStyleBackColor = true;
            // 
            // CreateDiagnosisModelView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnApDung);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "CreateDiagnosisModelView";
            Size = new Size(844, 456);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private CheckedListBox checkedListBox1;
        private Button btnApDung;
    }
}
