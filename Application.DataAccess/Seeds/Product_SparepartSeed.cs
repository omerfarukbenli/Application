using Application.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataAccess.Seeds
{
    internal class Product_SparepartSeed : IEntityTypeConfiguration<Product_Sparepart>
    {
        public void Configure(EntityTypeBuilder<Product_Sparepart> builder)
        {
            builder.HasData(
                  new Product_Sparepart { Id = 1, ProductId = 1, SparepartId = 1 },
                  new Product_Sparepart { Id = 2, ProductId = 1, SparepartId = 2 },
                  new Product_Sparepart { Id = 3, ProductId = 2, SparepartId = 3 },
                  new Product_Sparepart { Id = 4, ProductId = 2, SparepartId = 4 },
                  new Product_Sparepart { Id = 5, ProductId = 3, SparepartId = 5 },
                  new Product_Sparepart { Id = 6, ProductId = 3, SparepartId = 6 },
                  new Product_Sparepart { Id = 7, ProductId = 4, SparepartId = 7 },
                  new Product_Sparepart { Id = 8, ProductId = 4, SparepartId = 8 },
                  new Product_Sparepart { Id = 9, ProductId = 5, SparepartId = 9 },
                  new Product_Sparepart { Id = 10, ProductId = 5, SparepartId = 10 });



        }
    }
}
