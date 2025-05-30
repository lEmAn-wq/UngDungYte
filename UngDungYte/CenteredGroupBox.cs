using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungYte
{
    public partial class CenteredGroupBox : GroupBox
    {
        //private string _Text = "";

        ////create a new property a
        //[Browsable(true)]
        //[Category("Appearance")]
        //[DefaultValue("GroupBoxText")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        //public new string Text
        //{
        //    get
        //    {

        //        return _Text;
        //    }
        //    set
        //    {

        //        _Text = value;
        //        this.Invalidate();
        //    }
        //}
        public CenteredGroupBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            e.Graphics.Clear(this.BackColor);

            // Kích thước chữ
            SizeF textSize = e.Graphics.MeasureString(this.Text, this.Font);

            // Vị trí chữ căn giữa
            float textX = (this.Width - textSize.Width) / 2;
            float textY = 0;  // thường đặt 0 hoặc một chút lệch để chữ nằm đúng vị trí

            // Màu vẽ
            Color borderColor = this.ForeColor;
            Brush textBrush = new SolidBrush(this.ForeColor);

            // Vẽ chữ
            e.Graphics.DrawString(this.Text, this.Font, textBrush, textX, textY);

            // Vẽ viền, tránh viền cắt ngang chữ:
            int textHeight = (int)textSize.Height;
            int textMargin = 6;  // khoảng cách 2 bên chữ

            // Vẽ 2 đoạn viền ở trên, tránh vùng chữ
            e.Graphics.DrawLine(new Pen(borderColor), 0, textHeight / 2, textX - textMargin, textHeight / 2);
            e.Graphics.DrawLine(new Pen(borderColor), textX + textSize.Width + textMargin, textHeight / 2, this.Width, textHeight / 2);

            // Vẽ 3 cạnh còn lại
            e.Graphics.DrawLine(new Pen(borderColor), 0, textHeight / 2, 0, this.Height);
            e.Graphics.DrawLine(new Pen(borderColor), 0, this.Height - 1, this.Width, this.Height - 1);
            e.Graphics.DrawLine(new Pen(borderColor), this.Width - 1, textHeight / 2, this.Width - 1, this.Height);
        }
    }
}
