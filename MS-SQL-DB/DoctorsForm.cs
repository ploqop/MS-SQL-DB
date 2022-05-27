using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MS_SQL_DB
{
    public partial class DoctorsForm : Form
    {

        private SqlConnection sqlConnection = null;

        public DoctorsForm()
        {
            InitializeComponent();
        }

        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            sqlConnection.Open();

            UpdateDoctorsForm();
        }
        private void UpdateDoctorsForm()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                @"SELECT
                    txtDoctorName AS 'ФИО доктора',
                    txtSpecialist AS 'Специальность',
                    datDoctorWork AS 'Дата приёма на работу'
                FROM
                	tblDoctor;"
                , sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            DoctorDataGridView.DataSource = dataSet.Tables[0];
        }

        private void DoctorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
