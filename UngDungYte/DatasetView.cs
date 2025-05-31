using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace UngDungYte
{
    public partial class DatasetView : UserControl
    {
        public static DataTable dt;
        public DatasetView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            dt = UIHelper.SelectCsvAndLoadToTable();
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }
    }
}
