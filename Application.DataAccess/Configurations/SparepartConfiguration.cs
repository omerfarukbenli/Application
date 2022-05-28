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
    internal class SparepartConfiguration : IEntityTypeConfiguration<Sparepart>
    {
        public void Configure(EntityTypeBuilder<Sparepart> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.SparepartCode).IsRequired().HasColumnType("int");
            builder.Property(x => x.SparepartName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.SparePartPrice).IsRequired().HasColumnType("int");
        }
    }
}
