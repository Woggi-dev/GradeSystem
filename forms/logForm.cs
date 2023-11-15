using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GradeSystem.scripts;

namespace GradeSystem.forms
{
    public partial class logForm : Form
    {

        readonly Database dbConnection;

        public logForm()
        {
            InitializeComponent();
            dbConnection = new Database();
        }
        public void PwdShowHide(CheckBox checkBoxName)
        {
            switch (pwdShowCheckbox.Checked)
            {
                case true:
                    pwdTextbox.PasswordChar = '\0';
                    break;
                default:
                    pwdTextbox.PasswordChar = '•';
                    break;
            }
        }

        private void homepageButton_Click(object sender, EventArgs e)
        {
            homePageForm homePageForm = new homePageForm();
            this.Hide();
            homePageForm.Show();
        }

        private void fullyLogButton_Click(object sender, EventArgs e)
        {
            string login = loginTextbox.Text;
            string pwd = pwdTextbox.Text;

            if (string.IsNullOrEmpty(login) && string.IsNullOrEmpty(pwd))
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Введите логин и пароль";

            }
            else if (string.IsNullOrEmpty(login))
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Введите логин";
            }
            else if (string.IsNullOrEmpty(pwd))
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Введите пароль";
            }
            else
            {
                errorLabel.ForeColor = Color.IndianRed;
                errorLabel.Text = "Введен неверный логин или пароль";

            }


            //// SQL-запрос для проверки соответствия данных
            //string sqlQuery = "SELECT * FROM YourTable WHERE Username = @Username AND Password = @Password";

            //// Создание объекта SqlCommand
            //using (SqlCommand command = dbConnection.CreateCommand())
            //{
            //    command.CommandText = sqlQuery;

            //    // Добавление параметров к SQL-запросу
            //    command.Parameters.AddWithValue("@login", login);
            //    command.Parameters.AddWithValue("@pass", pwd);

            //    try
            //    {
            //        // Открытие подключения
            //        dbConnection.Open();

            //        // Выполнение SQL-запроса
            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            // Если запись найдена, переход на новую форму
            //            if (reader.Read())
            //            {
            //                MessageBox.Show("Вход выполнен успешно!");
            //                // Перехлд на mainForm
            //            }
            //            else
            //            {
            //                MessageBox.Show("Неверное имя пользователя или пароль!");
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Ошибка: {ex.Message}");
            //    }
            //    finally
            //    {
            //        // Закрытие подключения
            //        dbConnection.Close();
            //    }
            //}

        }

        private void pwdShowCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            PwdShowHide(pwdShowCheckbox);
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            regForm1 regForm1 = new regForm1();
            this.Hide();
            regForm1.Show();
                   
        }

        private void logForm_Load(object sender, EventArgs e)
        {

        }

        private void loginTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
