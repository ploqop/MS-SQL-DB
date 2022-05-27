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
    public partial class SelectedPatientForm : Form
    {
        private SqlConnection sqlConnection = null;

        readonly string[] FullName;
        public SelectedPatientForm(string[] str)
        {
            InitializeComponent();
            FullName = str;
        }

        private void buttonAddTreatment_Click(object sender, EventArgs e)
        {
            AddTreatmentForm form = new AddTreatmentForm(FullName);
            form.ShowDialog();
            UpdateTreatment();
            form.Dispose();
        }

        private void SelectedPatientForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            sqlConnection.Open();

            UpdatePatient();
            UpdateTreatment();
        }

        private void UpdatePatient()
        {
            SqlDataAdapter dataAdapterPatient = new SqlDataAdapter(
                $@"SELECT
                    ISNULL(txtPatientSurname, '') + ' ' + ISNULL(txtPatientName, '') + ' ' + ISNULL(txtPatientSecondName, '') AS 'ФИО пациента',
                    datBirthday AS 'Дата рождения',
                    txtAddress AS Адрес
                FROM
                	tblPatient
                WHERE
                    txtPatientSurname = '{FullName[0]}'
                    AND txtPatientName = '{FullName[1]}'"
                , sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapterPatient.Fill(dataSet);

            SelectedPatientDataGridView.DataSource = dataSet.Tables[0];
        }

        private void UpdateTreatment()
        {
            SqlDataAdapter dataAdapterTreatment = new SqlDataAdapter(
                $@"SELECT
	                tblTreatmentType.txtTreatmentTypeName AS 'Вид процедуры',
	                tblTreatmentSet.datDateBegin AS 'Дата начала курса',
	                tblTreatmentSet.datDateEnd AS 'Дата окончания курса',
	                tblTreatmentSet.intTreatmentSetCount AS 'Количество назначенных процедур',
	                tblTreatmentSet.intTreatmentSetCountFact AS 'Количество проведённых процедур',
	                tblDoctor.txtDoctorName AS 'ФИО доктора'
                FROM
	                tblTreatmentType,
	                tblTreatmentSet,
	                tblDoctor,
	                tblPatient
                WHERE
	                tblTreatmentSet.intDoctorId = tblDoctor.intDoctorId
	                AND tblTreatmentSet.intTreatmentTypeId = tblTreatmentType.intTreatmentTypeId
	                AND tblTreatmentSet.intPatientId = tblPatient.intPatientId
	                AND tblPatient.txtPatientName = '{FullName[1]}'
                   	AND tblPatient.txtPatientSurname = '{FullName[0]}'"
                , sqlConnection);

            DataSet dataSet2 = new DataSet();

            dataAdapterTreatment.Fill(dataSet2);

            SelectedPatientTreatmentDataGridView.DataSource = dataSet2.Tables[0];
        }

    }
}
