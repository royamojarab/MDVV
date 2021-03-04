using ManaDigitalV.UserControls;
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
    public partial class DashboardForm : Form
    {
        public Panel master;
      
    
        public DashboardForm()
        {
            InitializeComponent();
        }

        RegisterUserControl ruc1 = new RegisterUserControl();
        SearchUserControl suc = new SearchUserControl();
        MakeGroupUserControl muc = new MakeGroupUserControl();
        GroupListsUserControl gluc = new GroupListsUserControl();

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            Sliderpanel.Top = Registerbutton.Top;
            Sliderpanel.Height = Registerbutton.Height;
            Motherpanel.Controls.Clear();
            Motherpanel.Controls.Add(ruc1);
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            Sliderpanel.Top = Searchbutton.Top;
            Sliderpanel.Height = Searchbutton.Height;
            Motherpanel.Controls.Clear();
            Motherpanel.Controls.Add(suc);

        }

        private void Groupsbutton_Click(object sender, EventArgs e)
        {
            Sliderpanel.Top = Groupsbutton.Top;
            Sliderpanel.Height = Groupsbutton.Height;
            Motherpanel.Controls.Clear();
            Motherpanel.Controls.Add(muc);
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
             

            Motherpanel.Controls.Clear();
            Motherpanel.Controls.Add(ruc1);
            master = Motherpanel;
        }

        private void Motherpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Maximizebutton_Click(object sender, EventArgs e)
        {
            
            if (this.Width == 825)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else {
               this.WindowState = FormWindowState.Normal; }
        }

        private void Minimizebutton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Close();        }

        private void Maximizebutton_Click_1(object sender, EventArgs e)
        {

        }

        private void Supportbutton_Click(object sender, EventArgs e)
        {
            ContactUsUserControl cuc = new ContactUsUserControl();
            Sliderpanel.Top = Supportbutton.Top;
            Sliderpanel.Height = Supportbutton.Height;
            Motherpanel.Controls.Clear();
            Motherpanel.Controls.Add(cuc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChartUserControl ctuc = new ChartUserControl();
            Sliderpanel.Top = Chartbutton.Top;
            Sliderpanel.Height = Chartbutton.Height;
            Motherpanel.Controls.Clear();
            Motherpanel.Controls.Add(ctuc);
        }
    }
}
