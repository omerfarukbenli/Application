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
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                    new Product { Id = 1, ProductCode = 3434, ProductName = "Asus-A-100 Laptop", ProductPrice = 5000 },
                    new Product { Id = 2, ProductCode = 2345, ProductName = "Arçelik-E-400 Buzdolabı", ProductPrice = 10500 },
                    new Product { Id = 3, ProductCode = 3478, ProductName = "Samsung-P-200 LCD Televizyon", ProductPrice = 6000 },
                    new Product { Id = 4, ProductCode = 2367, ProductName = "IPhone 13-Akıllı Telefon", ProductPrice = 11000 },
                    new Product { Id = 5, ProductCode = 2348, ProductName = "Beko-U-600 Çamaşır Makinesi", ProductPrice = 7000 }


);
        }
    }
}
