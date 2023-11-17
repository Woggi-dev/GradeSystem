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
        homePageForm homePageForm;
        private void OpenForm(Form form)
        {
            this.Hide();
            form.Show();
        }
        public logForm()
        {
            InitializeComponent();
            homePageForm = new homePageForm();
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
            OpenForm(homePageForm); 
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
            // Если найдено совпадение логина и пароля в бд - зайти в аккаунт и запустить основную форму
            else if (Database.SelectData($"select usr_id, pass, login from User " +
            $"where login = '{login}' and password_user = '{pwd}'"))
            {
                OpenForm(homePageForm);
            }
            // Иначе вывести ошибку errorLabel.Text
            else
            {
                errorLabel.ForeColor = Color.IndianRed;
                errorLabel.Text = "Введен неверный логин или пароль";

            }
        }

        // Обработчик события кнопки "Зарегистрироваться" - выход на форму RegForm1
        private void regButton_Click(object sender, EventArgs e)
        {
            OpenForm(new regForm1("", "", ""));
        }

    }
}
