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
    public partial class AddTreatmentForm : Form
    {
        private SqlConnection sqlConnection = null;
        readonly string[] Fullname;

        public AddTreatmentForm(string[] fullname)
        {
            InitializeComponent();
            Fullname = fullname;
        }

        private void AddTreatmentForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            sqlConnection.Open();

            SqlDataAdapter dataAdapterPatient = new SqlDataAdapter(
                $@"SELECT
                    datBirthday AS 'Дата рождения'
                FROM
                	tblPatient
                WHERE
                    txtPatientSurname = '{Fullname[0]}'
                    AND txtPatientName = '{Fullname[1]}'"
                , sqlConnection);

            DataSet dataSet = new DataSet();

            dataAdapterPatient.Fill(dataSet);

            var a = dataSet.Tables[0].Columns[0];

            PatientBirthdaytextBox.Text = dataSet.Tables[0].Rows[0].Field<DateTime>(a).ToString().Split(' ')[0];

            PatientNametextBox.Text = string.Join(" ", Fullname);

            dataAdapterPatient = new SqlDataAdapter(
                $@"SELECT
                    intTreatmentTypeId,
                    txtTreatmentTypeName
                FROM
                	tblTreatmentType"
                , sqlConnection);

            dataSet = new DataSet();

            dataAdapterPatient.Fill(dataSet);

            comboBoxTreatment.DataSource = dataSet.Tables[0];
            comboBoxTreatment.DisplayMember = "txtTreatmentTypeName";
            comboBoxTreatment.ValueMember = "intTreatmentTypeId";

            dataAdapterPatient = new SqlDataAdapter(
                $@"SELECT
                    intDoctorId,
                    txtDoctorName
                FROM
                	tblDoctor"
                , sqlConnection);

            dataSet = new DataSet();

            dataAdapterPatient.Fill(dataSet);

            comboBoxDoctor.DataSource = dataSet.Tables[0];
            comboBoxDoctor.DisplayMember = "txtDoctorName";
            comboBoxDoctor.ValueMember = "intDoctorId";

            for (var i = 1; i < 1001; i++)
                comboBoxRoom.Items.Add(i);
        }

        private void buttonSetTreatment_Click(object sender, EventArgs e)
        {
            if (comboBoxRoom.Text == null || comboBoxRoom.Text == "")
            {
                MessageBox.Show("Выберите кабинет");
                return;
            }

            if (dateTimePickerDateBegin.Value >= dateTimePickerDateEnd.Value)
            {
                MessageBox.Show("Дата окончания курса должна быть позже даты начала курса");
                return;
            }

            SqlCommand command = new SqlCommand(
                $@"INSERT INTO
	                tblTreatmentSet
                VALUES
                	((SELECT
                		intDoctorId
                	FROM
                		tblDoctor
                	WHERE
                		@Doctor = txtDoctorName),
                	(SELECT
                		intPatientId
                	FROM
	                	tblPatient
                	WHERE
	                	@PatientName = txtPatientName
                        AND @PatientSurname = txtPatientSurname),
                	@DateBegin,
                	@DateEnd,
                	@Room,
                	@Visit,
                	0,
	                (SELECT
                		intTreatmentTypeId
                	FROM
                		tblTreatmentType
                	WHERE
                		@Treatment = txtTreatmentTypeName))"
                , sqlConnection
                );

            command.Parameters.AddWithValue("Doctor", comboBoxDoctor.Text);
            command.Parameters.AddWithValue("PatientSurname", PatientNametextBox.Text.Split(' ')[0]);
            command.Parameters.AddWithValue("PatientName", PatientNametextBox.Text.Split(' ')[1]);
            command.Parameters.AddWithValue("DateBegin", dateTimePickerDateBegin.Value.Date);
            command.Parameters.AddWithValue("DateEnd", dateTimePickerDateEnd.Value.Date);
            command.Parameters.AddWithValue("Room", int.Parse(comboBoxRoom.Text));
            command.Parameters.AddWithValue("Visit", (int)numericUpDownVisit.Value);
            command.Parameters.AddWithValue("Treatment", comboBoxTreatment.Text);

            if (command.ExecuteNonQuery() == 0)
                MessageBox.Show("Произошла ошибка");
            else
            {
                MessageBox.Show("Успешно добавлено");
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
