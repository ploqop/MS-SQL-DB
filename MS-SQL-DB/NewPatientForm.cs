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
using System.Globalization;

namespace MS_SQL_DB
{
    public partial class NewPatientForm : Form
    {

        private SqlConnection sqlConnection = null;

        public NewPatientForm()
        {
            InitializeComponent();
        }

        private void NewPatient_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            sqlConnection.Open();
        }

        private void textBoxSurname_Enter(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == "Фамилия")
            {
                textBoxSurname.ForeColor = Color.Black;
                textBoxSurname.Text = "";
            }
        }

        private void textBoxSurname_Leave(object sender, EventArgs e)
        {
            if (textBoxSurname.Text.Length == 0)
            {
                textBoxSurname.ForeColor = Color.Gray;
                textBoxSurname.Text = "Фамилия";
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Имя")
            {
                textBoxName.ForeColor = Color.Black;
                textBoxName.Text = "";
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0)
            {
                textBoxName.ForeColor = Color.Gray;
                textBoxName.Text = "Имя";
            }
        }

        private void textBoxSecondName_Enter(object sender, EventArgs e)
        {
            if (textBoxSecondName.Text == "Отчество")
            {
                textBoxSecondName.ForeColor = Color.Black;
                textBoxSecondName.Text = "";
            }
        }

        private void textBoxSecondName_Leave(object sender, EventArgs e)
        {
            if (textBoxSecondName.Text.Length == 0)
            {
                textBoxSecondName.ForeColor = Color.Gray;
                textBoxSecondName.Text = "Отчество";
            }
        }

        private void textBoxBirthDay_Enter(object sender, EventArgs e)
        {
            if (textBoxBirthday.Text == "Дата рождения")
            {
                textBoxBirthday.ForeColor = Color.Black;
                textBoxBirthday.Text = "";
            }
        }

        private void textBoxBirthDay_Leave(object sender, EventArgs e)
        {
            if (textBoxBirthday.Text.Length == 0)
            {
                textBoxBirthday.ForeColor = Color.Gray;
                textBoxBirthday.Text = "Дата рождения";
            }
        }

        private void textBoxAddress_Enter(object sender, EventArgs e)
        {
            if (textBoxAddress.Text == "Адрес проживания")
            {
                textBoxAddress.ForeColor = Color.Black;
                textBoxAddress.Text = "";
            }
        }

        private void textBoxAddress_Leave(object sender, EventArgs e)
        {
            if (textBoxAddress.Text.Length == 0)
            {
                textBoxAddress.ForeColor = Color.Gray;
                textBoxAddress.Text = "Адрес проживания";
            }
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                $@"INSERT INTO
                    tblPatient
                VALUES
                    (@Surname, @Name, @SecondName, @Birthday, @Address);"
                , sqlConnection
                );

            var Surname = textBoxSurname.Text;
            var Name = textBoxName.Text;
            var SecondName = textBoxSecondName.Text;
            var Birthday = textBoxBirthday.Text;
            var Address = textBoxAddress.Text;

            if (Surname == "Фамилия")
            {
                MessageBox.Show("Вы не ввели фамилию");
                return;
            }

            if (Name == "Имя")
            {
                MessageBox.Show("Вы не ввели имя");
                return;
            }

            if (Address == "Адрес проживания")
            {
                MessageBox.Show("Вы не ввели адрес");
                return;
            }

            if (SecondName == "Отчество")
            {
                MessageBox.Show("Вы не ввели отчество");
                return;
            }
            
            try
            {
                DateTime dateTime = DateTime.ParseExact(textBoxBirthday.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            }
            catch(FormatException)
            {
                MessageBox.Show("Неверная дата рождения\nДата должна быть в формате 'yyyy-MM-dd'");
                return;
            }

            command.Parameters.AddWithValue("Surname", Surname);
            command.Parameters.AddWithValue("Name", Name);
            command.Parameters.AddWithValue("SecondName", SecondName);
            command.Parameters.AddWithValue("Birthday", Birthday);
            command.Parameters.AddWithValue("Address", Address);

            if (command.ExecuteNonQuery() == 0)
                MessageBox.Show("Произошла ошибка");
            else
                MessageBox.Show("Успешно добавлено");
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
