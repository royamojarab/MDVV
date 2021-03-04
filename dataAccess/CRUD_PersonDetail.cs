using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;

namespace dataAccess.CRUD
{
    public class CRUD_PersonDetail
    {

        //ceate read update delete 
        phbContext db1 = new phbContext();
        public personDetail Create(personDetail pd)
        {//ایجاد شی در بانک اطلاعاتی
            if (pd == null || pd.personDataId == 0)
                return null;

            db1.personDetails.Add(pd);
            var result = db1.SaveChanges();

            if (result > 0)
                return pd;

            return null;
        }
        public bool Exist(personDetail pd)
        {
            return db1.personDetails.Any(i => i.personDataId == pd.personDataId);

        }
        //public List<personDetail> Read(string pd)
        //{
        //    return db1.personDetails.Where(i => i.value == pd.value);
        //}
        public personDetail Read(int ID)
        {
            return db1.personDetails.Where(i => i.Id == ID).FirstOrDefault();
        }
        public int Update(int id, personDetail p)
        {
            personDetail pd = new personDetail();
          pd = Read(id);
           pd.personDataId = p.Id;
          return  db1.SaveChanges();
           // return "ویرایش اطلاعات با موفقیت انجام شد";

        }
        public string Delete(int id)
        {
            personDetail pd = Read(id);
            db1.personDetails.Remove(pd);
            db1.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }
    }
}

