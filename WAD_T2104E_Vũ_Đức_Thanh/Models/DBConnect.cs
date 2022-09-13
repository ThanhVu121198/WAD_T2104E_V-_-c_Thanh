using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WAD_T2104E_Vũ_Đức_Thanh.Models
{
    public class DBConnect: DbContext
    {
        public DBConnect() : base("name=DBEntities3") { 
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}