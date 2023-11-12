﻿using System;
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
                    pwdTextbox.PasswordChar = '•';
                    break;
                default:
                    pwdTextbox.PasswordChar = '\0';
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
            string login = fullyLogButton.Text;
            string pwd = fullyLogButton.Text;

        }

        private void pwdShowCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            PwdShowHide(pwdShowCheckbox);
        }
    }
}
