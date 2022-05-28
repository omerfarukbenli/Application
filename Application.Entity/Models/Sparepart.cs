using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity.Models
{
    public class Sparepart:BaseEntity
    {
        public Sparepart()
        {
            this.Product_Spareparts = new HashSet<Product_Sparepart>();
        }
        public int SparepartCode { get; set; }
        public string SparepartName { get; set; }
        public int SparePartPrice { get; set; }
        public ICollection<Product_Sparepart> Product_Spareparts { get; set; }
    }
}

