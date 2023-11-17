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
    public partial class regForm1 : Form
    {
        // Приватные статические булевые переменные (принадлежащие классу) для проверки данных в обработчике событий nextButton_Click
        private static bool isNameValid, isSurnameValid, isPatronymicValid;
        

        // Функция открыть новую форму и скрыть старую
        public void OpenForm(Form currectForm, Form form)
        {
            currectForm.Hide();
            form.Show();
        }
        public regForm1()
        {
            InitializeComponent();
        }

        // Функция для установки параметров для надписей (labels) отчества
        private void SetPatronymicLabels(string labelText, Color labelForeColor, bool textboxEnabled, Color textboxBackColor, string textboxText)
        {
            // Меняем текст и цвет для надписи ошибки
            errorLabelPatronymic.Text = labelText;
            errorLabelPatronymic.ForeColor = labelForeColor;

            // Меняем доступность текстового поля отчества, цвет и его текст
            patronymicTextbox.Enabled = textboxEnabled;
            patronymicTextbox.BackColor = textboxBackColor;
            patronymicTextbox.Text = textboxText;
            
        }
        // Функция для преобразования из вида "ВАсИф" в "Васиф"
        private static string ToTitle(string input)
        {
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }
        // Функция для установки свойств для надписей ошибок
        private static void SetValidationProperties(Label errorLabel, Color textColor, string text)
        {
            // Устанавливаем цвет надписи и текст
            errorLabel.ForeColor = textColor;
            errorLabel.Text = text;
        }
        // Функция для проверки текстовых полей на правильность
        private static void DataValidation(Label errorLabel, string input, string obj, ref bool isValid)
        {
            // Если строчка пуста, установить свойства для надписи ошибки и выйти из функции
            if (string.IsNullOrEmpty(input))
            {
                SetValidationProperties(errorLabel, Color.Khaki, $"Заполните поле");
                return;
            }
            // Цикл для проверки всего введенного пользователем
            foreach (char c in input)
            {
                /* Если символ - цифра, пробел, спец символ, не кирилица - перезаписать конкретную булевую переменную каждого компонента 
                 * (isNameValid, isSurnameValid, isPatronymicValid) на false - невалидно и установить характеристики надписей для ошибок */
                if (char.IsDigit(c))
                {
                    isValid = false;
                    SetValidationProperties(errorLabel, Color.IndianRed, $"{obj} содержит цифры");
                    return;
                }
                else if (c == ' ' || !char.IsLetterOrDigit(c))
                {
                    isValid = false;
                    SetValidationProperties(errorLabel, Color.IndianRed, $"{obj} содержит спец символы");
                    return;
                }
                else if (char.IsDigit(c))
                {
                    isValid = false;
                    SetValidationProperties(errorLabel, Color.IndianRed, $"{obj} содержит цифры");
                    return;
                }
                else if (!(c >= '\u0400' && c <= '\u04FF'))
                {
                    isValid = false;
                    SetValidationProperties(errorLabel, Color.IndianRed, $"{obj} не содержит кирилицу");
                    return;
                }
            }
            // В случае прохода всех условий - установить маркеры успешности к надписям ошибки и поменять переменную на true - валидно
            SetValidationProperties(errorLabel, Color.Green, $"✔");
            isValid = true;
        }
        // Обработчик события нажатия кнопки "Войти" - перейти на logForm
        private void logButton_Click(object sender, EventArgs e)
        {
            OpenForm(this, new logForm());
        }

        // Обработчик события нажатия кнопки "Далее" - переход на regForm2
        private void nextButton_Click(object sender, EventArgs e)
        {

            // Сохраняем фамилию, имя, отчество в переменные
            string surname = surnameTextbox.Text;
            string name = nameTextbox.Text;
            string patronymic = patronymicTextbox.Text;

            // Если все компоненты - валидны (true) - преобразуем из вида "ВаСиФ" в "Васиф" и открываем форму regForm2
            if (isNameValid && isSurnameValid && isPatronymicValid)
            {
                name = ToTitle(name);
                surname = ToTitle(surname);
                patronymic = ToTitle(patronymic);

                Database.Connect();

                
                OpenForm(this, new regForm2());
            }
        }
        // Обработчик события "Нет отчества"
        private void patronymicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Если галочка поставлена (true) - блокируем текстовое поле "Отчество", устанавливаем маркеры. Иначе вернуть как было.
            switch (patronymicCheckBox.Checked)
            {
                case true:
                    SetPatronymicLabels("\U0001F512", Color.Gray, false, Color.FromArgb(224, 224, 224), "");
                    break;
                default:
                    SetPatronymicLabels("Заполните поле", Color.Khaki, true, Color.White, "");
                    break;
            }
        }

        // Обработчик события нажатия кнопки "Крестик" - перейти на главную страницу 
        private void homepageButton_Click(object sender, EventArgs e)
        {
            OpenForm(this, new homePageForm());

        }
        // Обработчик события написания текстовых полей "Имя", "Фамилия", "Отчество" и валидация данных
        private void surnameTextbox_TextChanged(object sender, EventArgs e)
        {
            DataValidation(errorLabelSurname, surnameTextbox.Text, "Фамилия", ref isSurnameValid);
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e)
        {
            DataValidation(errorLabelName, nameTextbox.Text, "Имя", ref isNameValid);
        }

        private void patronymicTextbox_TextChanged(object sender, EventArgs e)
        {
            // Если чекбокс "Нет отчества" неактивирован, то запустить валидацию данных
            if (patronymicTextbox.Enabled)
            {
                DataValidation(errorLabelPatronymic, patronymicTextbox.Text, "Отчество", ref isPatronymicValid);
            }
        }






    }


}
