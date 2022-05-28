using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity.Models
{
    public class Product_Sparepart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int SparepartId { get; set; }
        public virtual Sparepart Sparepart { get; set; }

    }
}

