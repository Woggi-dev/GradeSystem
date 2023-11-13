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
        bool isPhoneValid, isEmailValid;
        public regForm2()
        {
            InitializeComponent();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            logForm logForm = new logForm();
            this.Hide();
            logForm.Show();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            regForm3 regForm3 = new regForm3();
            this.Hide();
            regForm3.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            regForm1 regForm1 = new regForm1();
            this.Hide();
            regForm1.Show();
        }

        private void homepageButton_Click(object sender, EventArgs e)
        {
            homePageForm homePageForm = new homePageForm();
            this.Hide();
            homePageForm.Show();
        }

        private void phoneTextbox_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = phoneTextbox.Text;
            string errorPhoneNumberMessage = "Неверный формат телефона";
            if (string.IsNullOrEmpty(phoneNumber))
            {
                errorLabelPhone.ForeColor = Color.Khaki;
                errorLabelPhone.Text = $"Заполните поле";
                return;
            }
            else if (!(phoneNumber.StartsWith("+79") || phoneNumber.StartsWith("89")))
            {
                errorLabelPhone.ForeColor = Color.IndianRed;
                errorLabelPhone.Text = errorPhoneNumberMessage;
                return;
            }

            foreach (char c in phoneNumber)
            {
                if ((!char.IsLetterOrDigit(c) || c == ' ') && c != '+')
                {
                    errorLabelPhone.ForeColor = Color.IndianRed;
                    errorLabelPhone.Text = errorPhoneNumberMessage;
                    return;
                }
            }
            errorLabelPhone.ForeColor = Color.Green;
            errorLabelPhone.Text = $"✔";
        }

        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(emailTextbox.Text, @"\b(gmail.com|mail.ru|inbox.ru|yandex.ru)$"))
            {
                errorLabelEmail.ForeColor = Color.IndianRed;
                errorLabelEmail.Text = "Неверный формат эл.почты";
                return;
            }
            errorLabelEmail.ForeColor = Color.Green;
            errorLabelEmail.Text = $"✔";
        }
    }
}
