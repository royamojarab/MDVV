using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
 
    public class personDetail 
    {
        public int Id { get; set; }
        public int personDataId { get; set; }
        public person personData { get; set; }
        public string  parameter { get; set; }
        public string  value { get; set; }
        public string  Address { get; set; }
     
     
     
    }
}
