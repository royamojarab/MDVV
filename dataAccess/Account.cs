using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccess
{
   public class Account
    {
        phbContext uldb = new phbContext();
       
    
 
        public Account()
        {

        }
        public person register(person model) 
        {
            //ایجاد شی در بانک اطلاعاتی
            //  phbContext db1 = new phbContext();
            uldb.persons.Add(model);
            var result = uldb.SaveChanges();

            if (result > 0)
                return model;

            return null;
        }
        public bool Login(string user, string  pass)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=ManaDigital;Integrated Security=true";
            con.Open();
           
            SqlCommand cmd = new SqlCommand($"select [user], [password] from [Logins] where [user] = '{user}' and [password] = '{pass}';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                return true;


            }
            else
            {
                return false;


            }
            



        }
    }
}
