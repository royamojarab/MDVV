using BusinessEntity;
using dataAccess;
using dataAccess.CRUD;
using ManaDigitalV.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        public string savedPath { get; set; }
        List<person> p100 = new List<person>();
        List<person> pList = new List<person>();
        person selectedPerson = new person()
        {
            fullName = "",
            relation = ""
        };
        personPhone selectedPersonPhone = new personPhone();
        personDetail selectedPersonDetail = new personDetail();


        private void SearchUserControl_Load(object sender, EventArgs e)
        {

            //phbContext dphb = new phbContext();
            //dataGridView1.DataSource = dphb.persons.ToList();
            //List<person> pList = new List<person>();
            //phbContext db = new phbContext();
            //pList = db.persons.ToList();
            //SearchlistBox.DataSource = pList;

            bunifuMaterialTextbox1.OnValueChanged += fullNameValueChange;
            bunifuMaterialTextbox2.OnValueChanged += relationValueChange;
            bunifuMaterialTextbox3.OnValueChanged += phoneNumberValueChange;
            bunifuMaterialTextbox4.OnValueChanged += addressValueChange;
            numericUpDown1.ValueChanged += ageValueChange;
            comboBox1.SelectedIndexChanged += parameterValueChange;

        }

        private void fullNameValueChange(object sender, EventArgs e)
        {
            selectedPerson.fullName = bunifuMaterialTextbox1.Text;
        }

        private void relationValueChange(object sender, EventArgs e)
        {
            selectedPerson.relation = bunifuMaterialTextbox2.Text;
        }
        private void phoneNumberValueChange(object sender, EventArgs e)
        {
            selectedPersonPhone.phoneNumber = bunifuMaterialTextbox3.Text;
        }
        private void addressValueChange(object sender, EventArgs e)
        {
            selectedPersonDetail.Address = bunifuMaterialTextbox4.Text;
        }
        private void ageValueChange(object sender, EventArgs e)
        {
            selectedPerson.Age = Convert.ToInt32(numericUpDown1.Value);
        }
        private void parameterValueChange(object sender, EventArgs e)
        {
            selectedPersonDetail.parameter = comboBox1.Text;
        }
        private void CVValueChange(object sender, EventArgs e)
        {

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
            //bunifuMaterialTextbox1.DataBindings.Clear();
            //bunifuMaterialTextbox2.DataBindings.Clear();
            //bunifuMaterialTextbox3.DataBindings.Clear();
            //bunifuMaterialTextbox4.DataBindings.Clear();
            //numericUpDown1.DataBindings.Clear();
            //comboBox1.DataBindings.Clear();

            //phbContext ph = new phbContext();

            //selectedPerson = (person)SearchlistBox.SelectedItem;
            //selectedPersonPhone = ph.phopersonPhones.Where(w => w.personDataId == selectedPerson.Id).FirstOrDefault();
            //selectedPersonDetail = ph.personDetails.Where(w => w.personDataId == selectedPerson.Id).FirstOrDefault();

            //bunifuMaterialTextbox1.DataBindings.Add("Text", selectedPerson, "FullName");
            //bunifuMaterialTextbox2.DataBindings.Add("Text", selectedPerson, "relation");
            //bunifuMaterialTextbox3.DataBindings.Add("Text", selectedPersonPhone, "phoneNumber");
            //bunifuMaterialTextbox4.DataBindings.Add("Text", selectedPersonDetail, "address");
            //numericUpDown1.DataBindings.Add("Text", selectedPerson, "age");
            //comboBox1.DataBindings.Add("Text", selectedPersonDetail, "parameter");





        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            CRUD_personPhone CPP = new CRUD_personPhone();
            CRUD_PersonDetail CPD = new CRUD_PersonDetail();
            CRUD_Person cp = new CRUD_Person();

        var result1=   cp.Update(selectedPerson.Id, selectedPerson);
        var result2=    CPD.Update(selectedPersonDetail.Id, selectedPersonDetail);
       var result=CPP.Update(selectedPersonPhone.Id, selectedPersonPhone);


            
            //phbContext phb = new phbContext();
            //phb.persons.Attach(selectedPerson);
            //phb.Entry(selectedPerson).State = System.Data.Entity.EntityState.Modified;
            //phb.personDetails.Attach(selectedPersonDetail);
            //phb.Entry(selectedPersonDetail).State = System.Data.Entity.EntityState.Modified;
            //phb.phopersonPhones.Attach(selectedPersonPhone);
            //phb.Entry(selectedPersonPhone).State = System.Data.Entity.EntityState.Modified;
            //var result = phb.SaveChanges();

            if (result > 0&& result1!=null&&result2>0)
            {
                EditSuccessForm esf = new EditSuccessForm();
                esf.Show();
                pList = new CRUD_Person().ReadAll();
               // pList = db.persons.ToList();
                SearchlistBox.DataSource = pList;
            }
            else
            {
                EditFailedForm eff = new EditFailedForm();
                eff.Show();
            }
        }

        private void SearchlistBox_Click(object sender, EventArgs e)
        {
            phbContext ph = new phbContext();
                        
            

            selectedPerson = (person)SearchlistBox.SelectedItem;
            selectedPersonPhone = ph.phopersonPhones.Where(w => w.personDataId == selectedPerson.Id).FirstOrDefault();
            selectedPersonDetail = ph.personDetails.Where(w => w.personDataId == selectedPerson.Id).FirstOrDefault();

            bunifuMaterialTextbox1.DataBindings.Clear();
            bunifuMaterialTextbox2.DataBindings.Clear();
            bunifuMaterialTextbox3.DataBindings.Clear();
            bunifuMaterialTextbox4.DataBindings.Clear();
            numericUpDown1.DataBindings.Clear();
            comboBox1.DataBindings.Clear();

            bunifuMaterialTextbox1.DataBindings.Add("Text", selectedPerson, "fullName", false, DataSourceUpdateMode.OnPropertyChanged);
            bunifuMaterialTextbox2.DataBindings.Add("Text", selectedPerson, "relation");
            bunifuMaterialTextbox3.DataBindings.Add("Text", selectedPersonPhone, "phoneNumber");
            bunifuMaterialTextbox4.DataBindings.Add("Text", selectedPersonDetail, "address");
            numericUpDown1.DataBindings.Add("Text", selectedPerson, "age");
            comboBox1.DataBindings.Add("Text", selectedPersonDetail, "parameter", false, DataSourceUpdateMode.OnPropertyChanged);
          if(!string.IsNullOrEmpty(selectedPerson.Image))
            pictureBox1.Image = Image.FromFile(selectedPerson.Image);


            if (selectedPersonDetail != null)
            {
                comboBox1.Text = selectedPersonDetail.parameter;
            }
            
        }

        private void CVChoosebutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedPerson.Image))
            {
                Process.Start(selectedPerson.Image);
            }
        }

        private void SearchUserControl_Enter(object sender, EventArgs e)
        {
            List<person> pList = new List<person>();
            pList = new CRUD_Person().ReadAll();
            SearchlistBox.DataSource = pList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            List<person> pList = new List<person>();
            pList = new CRUD_Person().ReadAll();
            SearchlistBox.DataSource = pList;
        }

        private void CVSaverbutton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c://Desktop";
            openFileDialog1.Title = "فایل مورد نظر را انتخاب کنید";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    if (openFileDialog1.CheckFileExists)
                    {
                        string fileName = openFileDialog1.FileName;

                        var path = Path.Combine(Directory.GetCurrentDirectory(), "images");
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }

                        if (Path.GetExtension(fileName) == ".jpg")
                        {
                            Image img = Bitmap.FromFile(fileName);
                            var imgPath = Path.Combine(path, DateTime.Now.Ticks.ToString() + Path.GetExtension(fileName));
                            img.Save(imgPath);
                            savedPath = imgPath;
                            selectedPerson.Image = imgPath;
                            pictureBox1.Image = Image.FromFile(imgPath);
                        }
                        else
                        {
                            var imgPath = Path.Combine(path, DateTime.Now.Ticks.ToString() + Path.GetExtension(fileName));
                            File.Copy(fileName, imgPath);
                            savedPath = imgPath;
                            selectedPerson.Image = imgPath;
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            selectedPersonDetail.parameter = comboBox1.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SearchlistBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
    }

