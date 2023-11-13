using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeSystem.forms
{
    public partial class regForm1 : Form
    {
        homePageForm homePageForm = new homePageForm();
        bool isNameValid, isSurnameValid, isPatronymicValid;
        public regForm1()
        {
            InitializeComponent();
        }

        static private void DataValidation(Label errorLabel, string input, string obj, ref bool isValid)
        {
            if (string.IsNullOrEmpty(input))
            {
                isValid = false;
                errorLabel.ForeColor = Color.Khaki;
                errorLabel.Visible = true;
                errorLabel.Text = $"Заполните поле";
                return;
            }

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    isValid = false;
                    errorLabel.ForeColor = Color.IndianRed;
                    errorLabel.Visible = true;
                    errorLabel.Text = $"{obj} содержит цифры";
                    return;
                }
                if (c == ' ')
                {
                    isValid = false;
                    errorLabel.ForeColor = Color.IndianRed;
                    errorLabel.Visible = true;
                    errorLabel.Text = $"{obj} содержит пробелы";
                    return;
                }
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    isValid = false;
                    errorLabel.ForeColor = Color.IndianRed;
                    errorLabel.Visible = true;
                    errorLabel.Text = $"{obj} содержит спец. символы";
                    return;
                }
                if (!(c >= '\u0400' && c <= '\u04FF'))
                {
                    isValid = false;
                    errorLabel.ForeColor = Color.IndianRed;
                    errorLabel.Visible = true;
                    errorLabel.Text = $"{obj} не содержит кирилицу";
                    return;
                }
            }
            errorLabel.ForeColor = Color.Green;
            errorLabel.Text = $"✔";
            errorLabel.Visible = true;
            isValid = true;
        }
        private void logButton_Click(object sender, EventArgs e)
        {
            logForm logForm = new logForm();
            this.Hide();
            logForm.Show();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            string surname = nameTextbox.Text;
            string name = nameTextbox.Text;
            string patronymic = nameTextbox.Text;

            if (isNameValid && isSurnameValid && isPatronymicValid)
            {
                
                name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
                surname = char.ToUpper(surname[0]) + surname.Substring(1).ToLower();
                patronymic = char.ToUpper(patronymic[0]) + patronymic.Substring(1).ToLower();
                
                regForm2 regForm2 = new regForm2();
                this.Hide();
                regForm2.Show();
            }
        }

        private void homepageButton_Click(object sender, EventArgs e)
        {
            homePageForm homePageForm = new homePageForm();
            this.Hide();
            homePageForm.Show();
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e)
        {
            DataValidation(errorLabelName, nameTextbox.Text, "Имя", ref isNameValid);

        }

        private void patronymicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switch (patronymicCheckBox.Checked)
            {
                case true:
                    errorLabelPatronymic.Text = "🔒";
                    errorLabelPatronymic.ForeColor = Color.Gray;
                    patronymicTextbox.Enabled = false;
                    patronymicTextbox.BackColor = Color.FromArgb(224, 224, 224);
                    patronymicTextbox.Text = "";
                    break;
                default:
                    errorLabelPatronymic.Text = "Заполните поле";
                    errorLabelPatronymic.ForeColor = Color.Khaki;
                    patronymicTextbox.Enabled = true;
                    patronymicTextbox.BackColor = Color.White;
                    errorLabelPatronymic.Visible = true;
                    break;
            }
        }

        private void surnameTextbox_TextChanged(object sender, EventArgs e)
        {
            DataValidation(errorLabelSurname, surnameTextbox.Text, "Фамилия", ref isSurnameValid);
        }

        private void patronymicTextbox_TextChanged(object sender, EventArgs e)
        {
            if (patronymicTextbox.Enabled)
            {
                DataValidation(errorLabelPatronymic, patronymicTextbox.Text, "Отчество", ref isPatronymicValid);
            }
        }

    }


}
