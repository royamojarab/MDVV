using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaDigitalV.Forms
{
    public partial class SuccessLoginForm : Form
    {
        public SuccessLoginForm()
        {
            InitializeComponent();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            DashboardForm DF = new DashboardForm();
            this.Hide();
            DF.Show();
        }
    }
}
