using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;

namespace dataAccess.CRUD
{
    public class CRUD_Group
    {
        //ceate read update delete 
        phbContext db1 = new phbContext();

        public void Create(groups g)
        {//ایجاد شی در بانک اطلاعاتی

            db1.groups.Add(g);
            db1.SaveChanges();

        }
        public bool Exist(groups g)
        {
            return db1.groups.Any(i => i.groupName == g.groupName);
        }
        public List<groups> Read(string groupName)
        {
            return db1.groups.Where(i => i.groupName == groupName).ToList();
        }
        public groups Read(int ID)
        {
            return db1.groups.Where(i => i.Id == ID).FirstOrDefault();
        }
      public  bool search(groups g)
        {
            phbContext db2 = new phbContext();
            return db2.groups.Any(i => i.groupName.Contains(g.groupName));
        }
        public string Update(int id, person p)
        {
            groups g1 = new groups();
            g1 = Read(id);
            g1.groupName = p.fullName;
            db1.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";

        }
        public string Delete(int id)
        {
            groups g = Read(id);
            db1.groups.Remove(g);
            db1.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }
        public List<groups> ReadAll()
        {
            return db1.groups.ToList();
        }

    }
}

