using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity.Models
{
    public class Product:BaseEntity
    {
        public Product()
        {
            this.Product_Spareparts = new HashSet<Product_Sparepart>();
        }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public ICollection<Product_Sparepart> Product_Spareparts { get; set; }
    }
}
