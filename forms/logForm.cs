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
    public partial class logForm : Form
    {
        public logForm()
        {
            InitializeComponent();
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
    }
}
