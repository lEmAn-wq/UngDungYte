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
    public partial class FileCleaningView : UserControl
    {
        public FileCleaningView()
        {
            InitializeComponent();
        }

        public void btnLoadFile_Click(object sender, EventArgs e)
        {
            DataTable table = UIHelper.SelectCsvAndLoadToTable();
            if (table != null)
            {
                dataGridView1.DataSource = table;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
           UIHelper.ShowSaveFileDialogAndExportToCsv(dataGridView1);
        }
    }
}
