using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonelProjesiEntity;

namespace PersonelProjesiDAL
{
    public class MyContext:DbContext
    {
        public MyContext() : base("MyCon")
        {

        }

        public DbSet<Personel> Personels { get; set; }
    }
}
