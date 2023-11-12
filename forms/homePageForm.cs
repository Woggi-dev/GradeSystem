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
    public partial class homePageForm : Form
    {
        public homePageForm()
        {
            InitializeComponent();
        }
        private void regButton_Click(object sender, EventArgs e)
        {
            regForm1 regForm1 = new regForm1();
            this.Hide();
            regForm1.Show();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            logForm logForm = new logForm();
            this.Hide();
            logForm.Show();
        }
    }
}
