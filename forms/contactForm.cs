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
    public partial class contactForm : Form
    {
        // Ссылка на класс homepage
        homePageForm homePageForm;
        public contactForm()
        {
            InitializeComponent();
            // Создаем экземпляр класса homepage
            homePageForm = new homePageForm();
        }

        // Обработчик события на кнопку "На главный экран"
        private void homeButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePageForm.Show();
        }
    }
}
