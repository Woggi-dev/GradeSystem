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
    public partial class regForm3 : Form
    {
        bool isPwdValid, isPwdAgainValid;
        public regForm3()
        {
            InitializeComponent();
        }

        private void homepageButton_Click(object sender, EventArgs e)
        {
            homePageForm homePageForm = new homePageForm();
            this.Hide();
            homePageForm.Show();
        }

        private void pwdShowCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            switch (pwdShowCheckbox.Checked)
            {
                case true:
                    pwdTextbox.PasswordChar = '\0';
                    pwdAgainTextbox.PasswordChar = '\0';
                    break;
                default:
                    pwdTextbox.PasswordChar = '•';
                    pwdAgainTextbox.PasswordChar = '•';
                    break;
            }

        }

        private void logButton_Click(object sender, EventArgs e)
        {
            logForm logForm = new logForm();
            this.Hide();
            logForm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            regForm2 regForm2 = new regForm2();
            this.Hide();
            regForm2.Show();
        }

        private void pwdTextbox_TextChanged(object sender, EventArgs e)
        {
            errorLabelPwd.Text = "";
            string pwd = pwdTextbox.Text;

            Label[] errorLabels = { errorLabelPwdLength, errorLabelPwdUpper, errorLabelPwdLower, errorLabelPwdDigits};
            bool[] validations = { pwd.Length > 8, pwd.Any(char.IsUpper), pwd.Any(char.IsLower), pwd.Any(char.IsDigit) };
            int validationsLength = validations.Length;

            for (int i = 0; i < validationsLength; i++)
            {
                if (validations[i])
                {
                    errorLabels[i].ForeColor = Color.Green;
                    errorLabels[i].Text = $"✔";
                }
                else
                {
                    errorLabels[i].ForeColor = Color.IndianRed;
                    errorLabels[i].Text = $"✖";
                }
            }
            if (!validations.Any(value => value == false))
            {
                isPwdValid = true;
                errorLabelPwd.Text = "";
                errorLabelPwd.ForeColor = Color.Green;

                errorLabelPwdAgain.Text = "";
                pwdAgainTextbox.Enabled = true;
                pwdAgainTextbox.BackColor = Color.White;

            }
            else
            {
                isPwdValid = false;
                errorLabelPwd.Text = "Выполните требования пароля";
                errorLabelPwd.ForeColor = Color.Khaki;
            }
        }

        private void fullyRegButton_Click(object sender, EventArgs e)
        {
            if (isPwdValid && pwdAgainTextbox.Text == pwdTextbox.Text)
            {
                MessageBox.Show("Вы вошли в аккаунт");
            }
            else if (isPwdValid && pwdAgainTextbox.Text != pwdTextbox.Text)
            {
                errorLabelPwd.Text = "Пароли не совпадают";
                errorLabelPwd.ForeColor = Color.IndianRed;
                errorLabelPwdAgain.Text = "Пароли не совпадают";
                errorLabelPwdAgain.ForeColor = Color.IndianRed;
            }
        }

        private void pwdAgainTextbox_TextChanged(object sender, EventArgs e)
        {
            errorLabelPwdAgain.Text = "";
        }
    }
}
