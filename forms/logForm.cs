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

        private void OpenForm(Form form)
        {
            this.Hide();
            form.Show();
        }
        public logForm()
        {
            InitializeComponent();
            dbConnection = new Database();
        }
        // Метод показать/скрыть пароль
        public void PwdShowHide(TextBox textboxName, CheckBox checkboxName)
        {
            // Если галочка "Показать пароль" стоит (checkboxName.Checked = true) - показать пароль, иначе спрятать
            textboxName.PasswordChar = checkboxName.Checked ? '\0' : '•';
        }

        // Обработчик события нажатия крестика - выход на главную страницу
        private void homepageButton_Click(object sender, EventArgs e)
        {
            OpenForm(new homePageForm()); 
        }

        // Обработчик события CheckBox "Показать пароль"
        private void pwdShowCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Вызов функции "Показать/скрыть пароль"
            PwdShowHide(pwdTextbox, pwdShowCheckbox);
        }

        // Обработчик события нажатия кнопки "Войти" - выход на основную страницу
        private void fullyLogButton_Click(object sender, EventArgs e)
        {
            // Сохраняем логин и пароль пользователя
            string login = loginTextbox.Text;
            string pwd = pwdTextbox.Text;

            // Если логин или пароль пустой - вывести errorLabel.Text пользователю
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pwd))
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Введите логин или пароль";
            }
            // Иначе вывести ошибку errorLabel.Text
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
            //                // Перехлд на FormMainMenu
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

        // Обработчик события кнопки "Зарегистрироваться" - выход на форму RegForm1
        private void regButton_Click(object sender, EventArgs e)
        {
            OpenForm(new regForm1());
        }

    }
}
