using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity.DTOs
{
    public class ProductDto:BaseDto
    {
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
    }
}
