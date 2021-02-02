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
using System.Windows.Forms;

namespace ManaDigitalV.UserControls
{
    public partial class SearchUserControl : UserControl
    {
        public SearchUserControl()
        {
            InitializeComponent();
        }
        List<person> p100 = new List<person>();
        List<person> pList = new List<person>();
        person selectedPerson = new person();
        personPhone selectedPersonPhone = new personPhone();
        personDetail selectedPersonDetail = new personDetail();


        private void SearchUserControl_Load(object sender, EventArgs e)
        {
            List<person> pList = new List<person>();
            phbContext db = new phbContext();
            pList = db.persons.ToList();
            SearchlistBox.DataSource = pList;

        }
        bool search(person p)
        {
            phbContext phb = new phbContext();
            return phb.persons.Any(i => i.fullName.Contains(p.fullName));
        }
        void register() 
        {
            phbContext phb = new phbContext();
        }

        private void SearchbunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            List<person> searchList = new List<person>();
            phbContext db1 = new phbContext();
            var q = from item in db1.persons where item.fullName.Contains(SearchbunifuMaterialTextbox1.Text) select item;
            SearchlistBox.DataSource = q.ToList();

        }

        private void SearchlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.DataBindings.Clear();
            bunifuMaterialTextbox2.DataBindings.Clear();
            bunifuMaterialTextbox3.DataBindings.Clear();
            bunifuMaterialTextbox4.DataBindings.Clear();
            numericUpDown1.DataBindings.Clear();
            comboBox1.DataBindings.Clear();

            phbContext ph = new phbContext();

            selectedPerson = (person)SearchlistBox.SelectedItem;
            selectedPersonPhone = ph.phopersonPhones.Where(w => w.personDataId == selectedPerson.Id).FirstOrDefault();
            selectedPersonDetail = ph.personDetails.Where(w => w.personDataId == selectedPerson.Id).FirstOrDefault();

            bunifuMaterialTextbox1.DataBindings.Add("Text", selectedPerson, "FullName");
            bunifuMaterialTextbox2.DataBindings.Add("Text", selectedPerson, "relation");
            bunifuMaterialTextbox3.DataBindings.Add("Text", selectedPersonPhone, "phoneNumber");
            bunifuMaterialTextbox4.DataBindings.Add("Text", selectedPersonDetail, "address");
            numericUpDown1.DataBindings.Add("Text", selectedPerson, "age");
            comboBox1.DataBindings.Add("Text", selectedPersonDetail, "parameter");

         
        
        
        
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            phbContext phb = new phbContext();
            phb.persons.Attach(selectedPerson);
            phb.Entry(selectedPerson).State = System.Data.Entity.EntityState.Modified;
            var result = phb.SaveChanges();
            if (result > 0)
            {

                SuccessLoginForm slf = new SuccessLoginForm();
                slf.Show();
            }
            else 
            {
                FailedSaveForm FSF = new FailedSaveForm();
                FSF.Show();
            }
        
        
        }
    }
}
