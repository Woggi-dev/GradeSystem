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
            aboutButton.MouseEnter += Label_MouseEnter;
            aboutButton.MouseLeave += Label_MouseLeave;
            privacyButton.MouseEnter += Label_MouseEnter;
            privacyButton.MouseLeave += Label_MouseLeave;
            conditionsButton.MouseEnter += Label_MouseEnter;
            conditionsButton.MouseLeave += Label_MouseLeave;
            contactButton.MouseEnter += Label_MouseEnter;
            contactButton.MouseLeave += Label_MouseLeave;

        }
        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Font = new Font(label.Font, label.Font.Style | FontStyle.Underline);
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Font = new Font(label.Font, label.Font.Style & ~FontStyle.Underline);
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

        private void aboutButton_Click(object sender, EventArgs e)
        {
            aboutUsForm aboutUsForm = new aboutUsForm();
            this.Hide();
            aboutUsForm.Show();
        }

        private void privacyButton_Click(object sender, EventArgs e)
        {
            privacyForm privacyForm = new privacyForm();
            this.Hide();
            privacyForm.Show();
        }

        private void conditionsButton_Click(object sender, EventArgs e)
        {
            conditionsForm conditionsForm = new conditionsForm();
            this.Hide();
            conditionsForm.Show();
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            contactForm contactForm = new contactForm();
            this.Hide();
            contactForm.Show();
        }
    }
}
