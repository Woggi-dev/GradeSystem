using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeSystem.forms
{
    public partial class regForm2 : Form
    {
        // Приватные статические булевые переменные (принадлежащие классу) для проверки данных в обработчике событий nextButton_Click
        private static bool isPhoneValid, isEmailValid;
        public regForm2()
        {
            InitializeComponent();
        }

        // Функция открыть новую форму и скрыть старую
        public void OpenForm(Form form)
        {
            this.Hide();
            form.Show();
        }

        // Функция для установки параметров для надписей (labels)
        private void SetValidationProperties(Label errorLabel, Color labelForeColor, string text)
        {
            // Устанавливаем текст и цвет
            errorLabel.ForeColor = labelForeColor;
            errorLabel.Text = text;
        }

        // Обработчик события нажатия кнопки "Войти" - перейти на logForm
        private void logButton_Click(object sender, EventArgs e)
        {
            OpenForm(new logForm());
        }

        // Обработчик события нажатия кнопки "Далее" - переход на regForm2
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (isPhoneValid && isEmailValid)
            {
                OpenForm(new regForm3());
            }
        }
        // Обработчик события нажатия кнопки "Назад" - переход на regForm1
        private void backButton_Click(object sender, EventArgs e)
        {
            OpenForm(new regForm1());
        }

        // Обработчик события нажатия кнопки "Крестик" - переход на главную страницу
        private void homepageButton_Click(object sender, EventArgs e)
        {
            OpenForm(new homePageForm());
        }

        // Обработчик события написания текстовых полей "Телефона", "Почты" и валидация данных
        private void phoneTextbox_TextChanged(object sender, EventArgs e)
        {
            // Сохраняем номер телефона
            string phoneNumber = phoneTextbox.Text;

            // Проверка начинается ли номер телефона с +79
            bool isItStarts79 = phoneNumber.StartsWith("+79");

            // Если поле телефона пустое - установить свойства надписей ошибки и выйти из функции
            if (string.IsNullOrEmpty(phoneNumber))
            {
                SetValidationProperties(errorLabelPhone, Color.Khaki, "Заполните поле");
                return;
            }
            
            // Если начинается, изменить длину текстового поля телефона на 12, иначе на 11
            if (isItStarts79)
            {
                phoneTextbox.MaxLength = 12;
            }
            else
            {
                phoneTextbox.MaxLength = 11;

            }
            /* Если поле телефона начинается с +7, 89, символы являются цифрами и количество символов + больше 2,
            Если поле телефона пустое - установить свойства надписей ошибки и выйти из функции */
            if (!(isItStarts79 || phoneNumber.StartsWith("89"))
                || phoneNumber.Any(c => (!char.IsDigit(c) && c != '+')) || phoneNumber.Count(c => c == '+') >= 2
                || phoneNumber.Length < 11)
            {
                SetValidationProperties(errorLabelPhone, Color.IndianRed, "Неверный формат телефона");
                return;
            }

            // В случае прохода всех условий - установить маркеры успешности к надписям ошибки и поменять переменную на true - валидно
            SetValidationProperties(errorLabelPhone, Color.Green, "✔");
            isPhoneValid = true;
        }

        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {
            // Сохраняем почту
            string email = emailTextbox.Text;

            // Если поле почты пустое - установить свойства надписей ошибки и выйти из функции
            if (string.IsNullOrEmpty(email))
            {
                SetValidationProperties(errorLabelEmail, Color.Khaki, "Заполните поле");
                return;
            }

            // Если почта валидна (готовая функция) - установить свойства надписей ошибки и выйти из функции
            if (!Regex.IsMatch(email, @"\b(gmail.com|mail.ru|inbox.ru|yandex.ru)$"))
            {
                SetValidationProperties(errorLabelEmail, Color.IndianRed, "Неверный формат эл.почты");
                return;
            }

            // В случае прохода всех условий - установить маркеры успешности к надписям ошибки и поменять переменную на true - валидно
            SetValidationProperties(errorLabelEmail, Color.Green, "✔");
            isEmailValid = true;

        }
    }
}
