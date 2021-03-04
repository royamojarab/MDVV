using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;

namespace dataAccess.CRUD
{
    public class CRUD_personPhone
    {
        //ceate read update delete 
        phbContext db1 = new phbContext();
        public personPhone Create(personPhone p)
        {//ایجاد شی در بانک اطلاعاتی
            if (p == null || p.personDataId == 0)
                return null;

            db1.phopersonPhones.Add(p);
            var result = db1.SaveChanges();

            if (result > 0)
                return p;

            return null;
        }
        public bool Exist(personPhone pp)
        {
            return db1.phopersonPhones.Any(i => i.phoneNumber == pp.phoneNumber);

        }
        //public List<personPhone> Read(string  fullName)
        //{
        //    return db1.phopersonPhones.Where(i => i.personDataId == fullName).ToList();
        //}
        public personPhone Read(int ID)
        {
            return db1.phopersonPhones.Where(i => i.Id == ID).FirstOrDefault();
        }
        public int Update(int id, personPhone p)
        {
            personPhone pp = new personPhone();
            pp = Read(id);
            pp.Id = p.Id;
           return db1.SaveChanges();
            
           // return "ویرایش اطلاعات با موفقیت انجام شد";

        }
        public string Delete(int id)
        {
            personPhone pp = Read(id);
            db1.phopersonPhones.Remove(pp);
            db1.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }
    
}
}
