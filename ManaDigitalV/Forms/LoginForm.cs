using ManaDigitalV.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaDigitalV
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();

        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=.;Initial Catalog=ManaDigital;Integrated Security=True";
            con.Open();
        }

        private void Loginbutton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=ManaDigital;Integrated Security=true";
            con.Open();
            string userid = UserbunifuMaterialTextbox1.Text;
            string password = PassbunifuMaterialTextbox2.Text;
            SqlCommand cmd = new SqlCommand($"select [user], [password] from [Logins] where [user] = '{UserbunifuMaterialTextbox1.Text}' and [password] = '{PassbunifuMaterialTextbox2.Text}';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                SuccessLoginForm SLF = new SuccessLoginForm();
               
                

                   DashboardForm df1 = new DashboardForm();

                SLF.Show();
               
                this.Hide();



            }
            else
            {
                FialLoginForm flf = new FialLoginForm();
                flf.Show();
                

            }
            con.Close();



        }
    }
}
