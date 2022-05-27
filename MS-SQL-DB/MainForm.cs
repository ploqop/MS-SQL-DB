using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_SQL_DB
{
    public partial class MainForm : Form
    {
        private SqlConnection sqlConnection = null;
        public static string DoctorName = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            sqlConnection.Open();

            SqlDataAdapter dataAdapterDoctor = new SqlDataAdapter(
                $@"SELECT
                    intDoctorId,
                    txtDoctorName
                FROM
                	tblDoctor"
                , sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapterDoctor.Fill(dataSet);

            comboBoxDoctor.DataSource = dataSet.Tables[0];
            comboBoxDoctor.DisplayMember = "txtDoctorName";
            comboBoxDoctor.ValueMember = "intDoctorId";
        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            PatientsForm form = new PatientsForm();
            form.ShowDialog();
            form.Dispose();
        }

        private void DoctorsButton_Click(object sender, EventArgs e)
        {
            DoctorsForm form = new DoctorsForm();
            form.ShowDialog();
            form.Dispose();
        }

        private void ReportCabinetsButton_Click(object sender, EventArgs e)
        {
            ReportCabinetsForm form = new ReportCabinetsForm();
            form.ShowDialog();
            form.Dispose();
        }

        private void ReportPatientsButton_Click(object sender, EventArgs e)
        {
            ReportPatientsForm form = new ReportPatientsForm();
            form.ShowDialog();
            form.Dispose();
        }

        private void ReportDoctorButton_Click(object sender, EventArgs e)
        {
            ReportDoctorForm form = new ReportDoctorForm();
            DoctorName = comboBoxDoctor.Text;
            form.ShowDialog();
            form.Dispose();
        }
    }
}
