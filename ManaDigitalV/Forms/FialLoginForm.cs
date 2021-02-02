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
    public partial class FialLoginForm : Form
    {
        public FialLoginForm()
        {
            InitializeComponent();
        }

        private void Returnbutton_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            this.Hide();

        }

        private void FialLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
