using System;
using System.Collections.Generic;

namespace ConsoleApp.db.AdventureWorks2017.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            ProductSubcategory = new HashSet<ProductSubcategory>();
        }

        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductSubcategory> ProductSubcategory { get; set; }
    }
}
