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
    }
}
