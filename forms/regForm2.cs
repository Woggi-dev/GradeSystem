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
    public partial class regForm2 : Form
    {
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
            regForm2 regForm2 = new regForm2();
            this.Hide();
            regForm2.Show();
        }

        private void homepageButton_Click(object sender, EventArgs e)
        {
            homePageForm homePageForm = new homePageForm();
            this.Hide();
            homePageForm.Show();
        }

        
    }
}
