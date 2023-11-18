using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using GradeSystem.scripts;

namespace GradeSystem.childrenMainForm
{
    public partial class dayForm : Form
    {   
        public dayForm()
        {
            InitializeComponent();
            
        }

        private void dayForm_Load(object sender, EventArgs e)
        {
            firstLabel.Text = Database.ExecuteSqlQuery($"select subject from Grades where subject = 'математика'");
        }
    }
}
