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
using BusinessEntity;
using dataAccess;

namespace ManaDigitalV.UserControls
{
    public partial class GroupListsUserControl : UserControl
    {
        List<group> g100 = new List<group>();
        group selectedGroup = new group();
        List<person> selectedGroupPersons = new List<person>();


        public GroupListsUserControl()
        {
            InitializeComponent();
        }

        private void GroupBackbutton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MakeGroupUserControl mgcc = new MakeGroupUserControl();

            ((DashboardForm)Application.OpenForms["DashboardForm"]).master.Controls.Clear();
            ((DashboardForm)Application.OpenForms["DashboardForm"]).master.Controls.Add(mgcc);



        }

        private void GroupListsUserControl_Load(object sender, EventArgs e)
        {
            //List<group> pList = new List<group>();
            //phbContext db = new phbContext();
            //pList = db.groups.ToList();
            //GroupNamelistBox.DataSource = pList;

           

        }

        private void GroupNamelistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupNamelistBox_Click(object sender, EventArgs e)
        {
            selectedGroup = (group)GroupNamelistBox.SelectedItem;
            List<int> ids = selectedGroup.persons.Split(',').Select(s => Convert.ToInt32(s)).ToList();
            //
            selectedGroupPersons = new CRUD_Person().ReadAll();
            MemberslistBox.DataSource = selectedGroupPersons;
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            List<group> pList = new List<group>();
            pList = new CRUD_Group().ReadAll();
            GroupNamelistBox.DataSource = pList;
        }
    }
}
