using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccess
{
    public class phbContext: DbContext
    {
        public phbContext():base("ManaDigitalV.Properties.Settings.ManaDigitalConnectionString")
        {

        }
        public DbSet<person> persons { get; set; }
        public DbSet<groups> groups { get; set; }
        public DbSet<personPhone> phopersonPhones { set; get; }
        public DbSet<personDetail> personDetails { set; get; }
        public DbSet<Login> logins { set; get; }
        
        
    }
}
