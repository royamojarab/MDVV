using ManaDigitalV.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaDigitalV.UserControls
{
    public partial class MakeGroupUserControl : UserControl
    {
        public MakeGroupUserControl()
        {
            InitializeComponent();
        }
        GroupListsUserControl glc = new GroupListsUserControl();
        private void GroupListbutton_Click(object sender, EventArgs e)
        {
            ((DashboardForm)Application.OpenForms["DashboardForm"]).master.Controls.Clear();
            ((DashboardForm)Application.OpenForms["DashboardForm"]).master.Controls.Add(glc);
        }

        private void MakeGroupUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
