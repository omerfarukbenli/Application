using Application.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataAccess.Configurations
{
    internal class Product_SparepartConfiguration : IEntityTypeConfiguration<Product_Sparepart>
    {
        public void Configure(EntityTypeBuilder<Product_Sparepart> builder)
        {
            builder.HasOne(o => o.Product).WithMany(b => b.Product_Spareparts).HasForeignKey(c => c.ProductId);
            builder.HasOne(o => o.Sparepart).WithMany(b => b.Product_Spareparts).HasForeignKey(c => c.SparepartId);
        }
    }
}
