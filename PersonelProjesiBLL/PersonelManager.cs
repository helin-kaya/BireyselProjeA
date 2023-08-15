using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PersonelProjesiDAL;
using PersonelProjesiEntity;

namespace PersonelProjesiBLL
{
    
    public class PersonelManager
    {
        MyContext context = new MyContext();
        public List<Personel> GetAllPersonel()
        {
            try
            {
                return context.Personels.ToList();
            }
            catch(Exception ex) 
            {
                throw;
            }
        }
         public bool DeletePersonel(int id)
        {
            try
            {
                var personel = context.Personels.Find(id);
            if (personel != null)
            {
                context.Personels.Remove(personel);
                context.SaveChanges();
            }
                return context.SaveChanges() > 1 ? true : false;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public bool AddPersonel(Personel newPersonel)
        {
            try
            {
                if (newPersonel != null)
                {
                    context.Personels.Add(newPersonel);
                    context.SaveChanges();
                }
                return context.SaveChanges() > 1 ? true : false;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //public void AddPersonel(Personel newPersonel)
        //{
        //    try
        //    {
        //        if (newPersonel != null)
        //        {
        //            context.Personels.Add(newPersonel);
        //            context.SaveChanges();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Personel eklenirken bir hata oluştu.", ex);
        //    }
        //}








    }
}
