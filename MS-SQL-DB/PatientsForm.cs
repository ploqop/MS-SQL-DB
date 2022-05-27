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
    public partial class PatientsForm : Form
    {

        private SqlConnection sqlConnection = null;

        public PatientsForm()
        {
            InitializeComponent();
        }

        private void PatientsFormLoad(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            sqlConnection.Open();

            UpdatePatientsForm();
        }

        private void UpdatePatientsForm()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                @"SELECT
                    ISNULL(txtPatientSurname, '') + ' ' + ISNULL(txtPatientName, '') + ' ' + ISNULL(txtPatientSecondName, '') AS 'ФИО пациента',
                    datBirthday AS 'Дата рождения',
                    txtAddress AS Адрес
                FROM
                	tblPatient;"
                , sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            PatientDataGridView.DataSource = dataSet.Tables[0];
        }

        private void AddPatientButtonClick(object sender, EventArgs e)
        {
            NewPatientForm form = new NewPatientForm();
            form.ShowDialog();
            UpdatePatientsForm();
            form.Dispose();
        }

        private void PatientDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                SelectedPatientForm form = new SelectedPatientForm(PatientDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString().Split(' '));
                form.ShowDialog();
                form.Dispose();
            }
        }

        private void PatientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}