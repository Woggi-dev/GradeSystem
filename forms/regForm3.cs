using System;
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
    public partial class regForm3 : Form
    {
        // Приватные статические булевые переменные (принадлежащие классу) для проверки данных в обработчике событий fullyRegButton_Click
        private static bool isPwdValid;
        // Приватная статическая ссылка на класс logForm
        private static logForm logForm;
        

        // Конструктор класса
        public regForm3()
        {
            InitializeComponent();
            // Создаем новый экземляр класса logForm
            logForm = new logForm();    
        }
        // Функция для открытия формы
        private void OpenForm(Form form)
        {
            this.Hide();
            form.Show();
        }

        // Функция для очистки надписей ошибок для пароля
        private void ClearPwdValidationLabels()
        {
            // Очищаем ошибочные надписи и устанавливаем им зеленый цвет
            SetPwdValidationLabels("", Color.Green);
            SetPwdAgainValidationLabels("", Color.Green);
           
        }

        // Функция для установки значения надписей ошибок для пароля
        private void SetPwdValidationLabels(string text, Color color)
        {
            // Изменяем текст и цвет
            errorLabelPwd.Text = text;
            errorLabelPwd.ForeColor = color;
        }

        // Функция для установки значения надписей ошибок для повторного пароля
        private void SetPwdAgainValidationLabels(string text, Color color)
        {
            // Изменяем текст и цвет
            errorLabelPwdAgain.Text = text;
            errorLabelPwdAgain.ForeColor = color;
        }
        // Обработчик события перехода на главную страницу
        private void homepageButton_Click(object sender, EventArgs e)
        {
            OpenForm(new homePageForm());
        }

        // Обработчик события изменения состояния Checkbox (галочка/нет галочки)
        private void pwdShowCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // Вызываем функцию из класса logForm для скрытия/показания пароля для пароля и повторного пароля
            logForm.PwdShowHide(pwdTextbox, pwdShowCheckbox);
            logForm.PwdShowHide(pwdAgainTextbox, pwdShowCheckbox);
        }

        // Обработчик события нажатия кнопки "Войти" - переход на форму logForm
        private void logButton_Click(object sender, EventArgs e)
        {
            OpenForm(new logForm());
        }

        // Обработчик события нажатия кнопки "Назад" - переход на форму regForm2
        private void backButton_Click(object sender, EventArgs e)
        {
            OpenForm(new regForm2());
        }

        // Обработчик события изменения текста
        private void pwdTextbox_TextChanged(object sender, EventArgs e)
        {
            // При наборе текста убираем ошибочные надписи
            errorLabelPwd.Text = "";

            // Сохраняем пароль 
            string pwd = pwdTextbox.Text;

            // Создаем массивы надписей для ошибок, запрещенные символы и проверки пароля (длина пароля, есть ли заглавные/маленькие буквы, есть ли цифры)
            char[] forbiddenChars = { ' ', '"', '\'', '`', ';', ':'};
            Label[] errorLabels = { errorLabelPwdLength, errorLabelPwdUpper, errorLabelPwdLower, errorLabelPwdDigits, errorLabelPwdSpecChars };
            bool[] validations = { pwd.Length > 8, pwd.Any(char.IsUpper), pwd.Any(char.IsLower), pwd.Any(char.IsDigit),
            !pwd.Any(c => forbiddenChars.Contains(c))};

            // Общая длина всех массивов
            const int generalArraysLength = 5;

            // Цикл для изменения состояния требований пароля (если требования соблюдено - зеленый цвет, галочка, иначе - красный цвет, крестик)
            for (int i = 0; i < generalArraysLength; i++)
            {
                // Если из массива мы берем true - зеленый цвет и галочка, иначе красный и крестик
                errorLabels[i].ForeColor = validations[i] ? Color.Green : Color.IndianRed;
                errorLabels[i].Text = validations[i] ? "✔" : "✖";
            }
            
             /* Если все проверки прошли успешно (в массиве validations везде true) - поставить отметку, что пароль - валидный (true) 
              * и очистить надписи ошибок */
            if (validations.All(value => value))
            {
                isPwdValid = true;
                ClearPwdValidationLabels();
            }
            // Иначе поставить отметку, что пароль - невалидный (false) и установить характеристики надписей для ошибок
            else
            {
                isPwdValid = false;
                SetPwdValidationLabels("Выполните требования пароля", Color.Khaki);
            }
        }

        // Обработчик события нажатия кнопки "Зарегистрироваться" - переход на основную форму
        private void fullyRegButton_Click(object sender, EventArgs e)
        {
            // Если пароль валидный и он совпадает с другим паролем, войти в аккаунт
            if (isPwdValid && pwdAgainTextbox.Text == pwdTextbox.Text)
            {
                MessageBox.Show("Вы вошли в аккаунт");
            }
            // Если пароль валидный, но он совпадает с другим паролем, войти в аккаунт
            else if (isPwdValid && pwdAgainTextbox.Text != pwdTextbox.Text)
            {
                // Вызываем функции для вывода надписей для ошибок
                SetPwdValidationLabels("Пароли не совпадают", Color.IndianRed);
                SetPwdAgainValidationLabels("Пароли не совпадают", Color.IndianRed);
            }
        }

        // Обработчик события изменения текста
        private void pwdAgainTextbox_TextChanged(object sender, EventArgs e)
        {
            // При наборе текста убираем ошибочные надписи
            errorLabelPwdAgain.Text = "";
        }

    }
}
