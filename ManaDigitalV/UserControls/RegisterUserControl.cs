using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntity;
using dataAccess;
using dataAccess.CRUD;
using ManaDigitalV.Forms;

namespace ManaDigitalV.UserControls
{
    public partial class RegisterUserControl : UserControl
    {
        public RegisterUserControl()
        {
            InitializeComponent();
        }

        SqlConnection CON = new SqlConnection("Data Source=.;Initial Catalog=ManaDigital;Integrated Security=True");
        string savedPath;

        bool search(person p)
        {
            phbContext phb = new phbContext();
            return phb.persons.Any(i => i.fullName.Contains(p.fullName));

        }

        public bool register(person p, personDetail pd, personPhone pp)
        {
            CRUD_Person cp = new CRUD_Person();
            CRUD_PersonDetail cpd = new CRUD_PersonDetail();
            CRUD_personPhone cpp = new CRUD_personPhone();
            phbContext db1 = new phbContext();
            if (p.Age >= 18 && search(p) != true)
            {
                var person = new person { fullName = p.fullName, relation = p.relation, Age = p.Age, Image = savedPath };
                var prsn = cp.Create(person);
                //  db1.persons.Add(new person { fullName = p.fullName, relation = p.relation, Age = p.Age, Image = savedPath });
                // db1.personDetails.Add(new personDetail { parameter = pd.parameter, Address = pd.Address });
                var prsnD = cpd.Create(new personDetail { parameter = pd.parameter, Address = pd.Address, personDataId = prsn?.Id ?? 0 });
                // db1.phopersonPhones.Add(new personPhone { phoneNumber = pp.phoneNumber });
                var prsnP = cpp.Create(new personPhone { phoneNumber = pp.phoneNumber, personDataId = prsn?.Id ?? 0 });




                RegisterSubmitForm rsf = new RegisterSubmitForm();
                rsf.Show();
                if (prsnD != null && prsnP != null)
                    return true;

                //   return false;

            }
            else
            {
                FailedRegisterSubmitForm frsf = new FailedRegisterSubmitForm();
                frsf.Show();
            }
            return false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterUserControl_Load(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            var result = register(new person
            {
                fullName = NamebunifuMaterialTextbox.Text,
                Age = Convert.ToInt32(AgenumericUpDown.Value),
                relation = RelationbunifuMaterialTextbox.Text,
                Image = savedPath,

            },
            new personDetail { Address = AddressbunifuMaterialTextbox.Text, parameter = GroupcomboBox.Text },
            new personPhone { phoneNumber = PhonebunifuMaterialTextbox.Text, }
            );
            if (result)
            {
                NamebunifuMaterialTextbox.Text = "";
                AgenumericUpDown.Value = 0;
                RelationbunifuMaterialTextbox.Text = "";
                savedPath = "";
                AddressbunifuMaterialTextbox.Text = "";
                PhonebunifuMaterialTextbox.Text = "";
                GroupcomboBox.SelectedIndex = -1;

            }
        }

        private void CVChoosebutton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c://Desktop";
            openFileDialog1.Title = "فایل مورد نظر را انتخاب کنید";
            //openFileDialog1.Filter = "select valid format(*.pdf,*.doc,*.xlsx,*.html,*.jpg,*.svg;)|*.pdf,*.doc,*.xlsx,*.html,*.jpg,*.svg;";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

                    }

                }
                else
                {

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CVSaverbutton_Click(object sender, EventArgs e)
        {
            try
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
                }
                else
                {
                    var imgPath = Path.Combine(path, DateTime.Now.Ticks.ToString() + Path.GetExtension(fileName));
                    File.Copy(fileName, imgPath);
                    savedPath = imgPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PhonebunifuMaterialTextbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void GroupcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void NamebunifuMaterialTextbox_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}

