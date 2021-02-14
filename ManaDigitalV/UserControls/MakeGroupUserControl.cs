using BusinessEntity;
using dataAccess;
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
        List<group> g100 = new List<group>();
        List<person> pList = new List<person>();
        group selectedGroup = new group();
        List<person> selectedGroupPerson = new List<person>();
        List<person> selectedPersons = new List<person>();
        public MakeGroupUserControl()
        {
            InitializeComponent();
        }

        GroupListsUserControl glc = new GroupListsUserControl();
        bool search(group g)
        {
            phbContext db2 = new phbContext();
            return db2.groups.Any(i => i.groupName.Contains(g.groupName));
        }
        void register(group g)
        {
            phbContext db3 = new phbContext();
            if (g.groupName.Length >= 2 && search(g) != true)
            {
                db3.groups.Add(new group { groupName = g.groupName, persons = g.persons });
                db3.SaveChanges();
                GroupSuccessForm gsf = new GroupSuccessForm();
                gsf.Show();

            }
            else
            {
                GroupFailedForm gff = new GroupFailedForm();
                gff.Show();
            }
        }





        private void GroupListbutton_Click(object sender, EventArgs e)
        {
            ((DashboardForm)Application.OpenForms["DashboardForm"]).master.Controls.Clear();
            ((DashboardForm)Application.OpenForms["DashboardForm"]).master.Controls.Add(glc);
        }

        private void MakeGroupUserControl_Load(object sender, EventArgs e)
        {
            //phbContext db = new phbContext();
            //pList = db.persons.ToList();
            //MemberslistBox.DataSource = pList;

            //NewGroupMemberlistBox.DataBindings.Clear();
            //NewGroupMemberlistBox.DataBindings.Add("Text", selectedPersons, "fullName");
        }

        private void GroupNamebunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            //List<group> searchList = new List<group>();
            //phbContext db2 = new phbContext();
            //var q = from item in db2.groups where item.groupName.Contains(GroupNamebunifuMaterialTextbox1.Text) select item;

            //NewGroupMemberlistBox.DataSource = q.ToList();
        }

        private void NewGroupMemberlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewGroupMemberlistBox_Click(object sender, EventArgs e)
        {
            var pg1 = (person)NewGroupMemberlistBox.SelectedItem;

            if (pg1 != null)
            {
                MemberslistBox.DataSource = new List<person>();
                pList.Add(pg1);
                MemberslistBox.DataSource = pList;
                selectedPersons = selectedPersons.Where(w => w.Id != pg1.Id).ToList();
                NewGroupMemberlistBox.DataSource = selectedPersons;
            }
        }

        private void MemberslistBox_Click(object sender, EventArgs e)
        {
            var pg = (person)MemberslistBox.SelectedItem;
            if (pg != null)
            {
                NewGroupMemberlistBox.DataSource = new List<person>();
                selectedPersons.Add(pg);
                NewGroupMemberlistBox.DataSource = selectedPersons;

                pList = pList.Where(w => w.Id != pg.Id).ToList();
                MemberslistBox.DataSource = pList;
            };

        }

        private void MakeNewGroupbutton_Click(object sender, EventArgs e)
        {
            register(new group
            {
                groupName = GroupNamebunifuMaterialTextbox1.Text,
                persons = string.Join(",", selectedPersons.Select(s => s.Id.ToString()).ToArray())
            }); ;
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            phbContext db = new phbContext();
            pList = db.persons.ToList();
            MemberslistBox.DataSource = pList;

            NewGroupMemberlistBox.DataBindings.Clear();
            NewGroupMemberlistBox.DataBindings.Add("Text", selectedPersons, "fullName");
        }
    }
}
