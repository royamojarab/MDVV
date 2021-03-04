using BusinessEntity;
using dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataLogic
{
    public class userLogic
    {
       
        public bool login(string user,string pass)
        {
            return new Account().Login(user,pass);
        }
        public person register(person p)
        {
            return new Account().register(p);
        }
        public bool Exist(person p)
        {
            return new CRUD_Person().Exist(p);

        }
        public List<person> Read(string fullName)
        {
            return new CRUD_Person().Read(fullName);
        }
          public person Read(int ID)
        {
            return new CRUD_Person().Read(ID);
        }

        public person Update(int id, person p)
        {
           
            return new CRUD_Person().Update(id,p);
        }
        public string Delete(int id)
        {
            person p = Read(id);
           
            return "حذف اطلاعات با موفقیت انجام شد";
        }
        public List<person> ReadAll()
        {
            return new CRUD_Person().ReadAll();
        }


    }
}
