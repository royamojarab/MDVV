using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;

namespace dataAccess
{
    public class CRUD_Person
    {

        //ceate read update delete 
        phbContext db1 = new phbContext();
        public person Create(person p)
        {//ایجاد شی در بانک اطلاعاتی
         //  phbContext db1 = new phbContext();
            db1.persons.Add(p);
            var result = db1.SaveChanges();

            if (result > 0)
                return p;

            return null;
        }
        public bool Exist(person p)
        {
            return db1.persons.Any(i => i.fullName == p.fullName);

        }
        public List<person> Read(string fullName)
        {
            return db1.persons.Where(i => i.fullName == fullName).ToList();
        }
        public person Read(int ID)
        {
            return db1.persons.Where(i => i.Id == ID).FirstOrDefault();
        }
        public person Update(int id, person p)
        {
            person p1 = new person();
            p1 = Read(id);
            p1.fullName = p.fullName;
            var result = db1.SaveChanges();

            if (result > 0)
                return p;

            return null;
            //  return "ویرایش اطلاعات با موفقیت انجام شد";
        }
        public string Delete(int id)
        {
            person p = Read(id);
            db1.persons.Remove(p);
            db1.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }
        public List<person> ReadAll()
        {
            return db1.persons.ToList();
        }



    }
}
