using System;
using System.Collections.Generic;

namespace  DevExpress.DemoData.Models
{
    public partial class Category
    {
        public long CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
