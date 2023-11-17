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
    public partial class homePageForm : Form
    {
        Database database;

        public homePageForm()
        {
            InitializeComponent();


            // Добавляем обработчики события наведения/отведения мышки к кнопкам-надписям (button-label)
            aboutButton.MouseEnter += Label_MouseEnter;
            aboutButton.MouseLeave += Label_MouseLeave;
            
            privacyButton.MouseEnter += Label_MouseEnter;
            privacyButton.MouseLeave += Label_MouseLeave;
            
            conditionsButton.MouseEnter += Label_MouseEnter;
            conditionsButton.MouseLeave += Label_MouseLeave;
            contactButton.MouseEnter += Label_MouseEnter;
            contactButton.MouseLeave += Label_MouseLeave;

        }
        // Функция открыть новую форму и скрыть старую
        public void OpenForm(Form form)
        {
            this.Hide();
            form.Show();
        }

        // Обработчики события Label_MouseEnter/Leave - навести/отвести мышку от надписи
        private void Label_MouseEnter(object sender, EventArgs e)
        {
            // При наведении мышки на надпись сделать надпись подчеркнутым
            Label label = (Label) sender;
            label.Font = new Font(label.Font, label.Font.Style | FontStyle.Underline);
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            // При отведении мышки от надписи сделать надпись неподчеркнутой
            Label label = (Label)sender;
            label.Font = new Font(label.Font, label.Font.Style & ~FontStyle.Underline);

        }

        // Обработчики события Reg/Log/About/Privacy/Conditions/contactButton_Click - нажать на кнопки
        private void regButton_Click(object sender, EventArgs e)
        {
            OpenForm(new regForm1());
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            OpenForm(new logForm());
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            OpenForm(new aboutUsForm());
        }

        private void privacyButton_Click(object sender, EventArgs e)
        {
            OpenForm(new privacyForm());
        }

        private void conditionsButton_Click(object sender, EventArgs e)
        {
            OpenForm(new conditionsForm());
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            OpenForm(new contactForm());
        }
    }
}
