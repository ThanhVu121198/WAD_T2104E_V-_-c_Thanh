using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_T2104E_Vũ_Đức_Thanh.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public Nullable<int> CategoryId { get; set; }

        public virtual ICollection<Category> Categorys { get; set; }
    }
}