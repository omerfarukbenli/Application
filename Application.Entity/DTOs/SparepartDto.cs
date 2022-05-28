using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity.DTOs
{
    public class SparepartDto:BaseDto
    {
        public int SparepartCode { get; set; }
        public string SparepartName { get; set; }
        public int SparePartPrice { get; set; }
    }
}
