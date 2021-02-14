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

        public void register(person p, personDetail pd, personPhone pp)
        {
            phbContext db1 = new phbContext();
            if (p.Age >= 18 && search(p) != true)
            {
                db1.persons.Add(new person { fullName = p.fullName, relation = p.relation, Age = p.Age, Image = savedPath });
                db1.personDetails.Add(new personDetail { parameter = pd.parameter, Address = pd.Address });
                db1.phopersonPhones.Add(new personPhone { phoneNumber = pp.phoneNumber });
                db1.SaveChanges();

                RegisterSubmitForm rsf = new RegisterSubmitForm();
                rsf.Show();
            }
            else
            {
                FailedRegisterSubmitForm frsf = new FailedRegisterSubmitForm();
                frsf.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterUserControl_Load(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            register(new person
            {
                fullName = NamebunifuMaterialTextbox.Text,
                Age = Convert.ToInt32(AgenumericUpDown.Value),
                relation = RelationbunifuMaterialTextbox.Text,
                Image = savedPath
            },
        new personDetail { Address = AddressbunifuMaterialTextbox.Text },
        new personPhone { phoneNumber = PhonebunifuMaterialTextbox.Text, }
        );
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
                        ////////////////////////////
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
    }
}

