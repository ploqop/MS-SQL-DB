using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_SQL_DB
{
    public partial class ReportDoctorForm : Form
    {
        public ReportDoctorForm()
        {
            InitializeComponent();
        }

        private void ReportDoctorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet4.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet4.DataTable1);

/*            foreach (var i in DataSet4.DataTable1.Rows)
            {
                DataSet4.DataTable1.RemoveDataTable1Row(i);
            }*/

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
