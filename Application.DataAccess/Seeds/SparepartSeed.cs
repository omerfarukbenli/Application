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
    internal class SparepartSeed : IEntityTypeConfiguration<Sparepart>
    {
        public void Configure(EntityTypeBuilder<Sparepart> builder)
        {
            builder.HasData(
                   new Sparepart { Id = 1, SparepartCode = 6765, SparepartName = "4 GB bilgisayar Ram'i", SparePartPrice = 500 },
                   new Sparepart { Id = 2, SparepartCode = 7645, SparepartName = "i9 bilgisayar İşlemcisi", SparePartPrice = 1000 },
                   new Sparepart { Id = 3, SparepartCode = 5423, SparepartName = "Buzdolabı Fan Motoru", SparePartPrice = 500 },
                   new Sparepart { Id = 4, SparepartCode = 9765, SparepartName = "Buzdolabı TelRafı", SparePartPrice = 400 },
                   new Sparepart { Id = 5, SparepartCode = 3214, SparepartName = "TV Anakartı", SparePartPrice = 600 },
                   new Sparepart { Id = 6, SparepartCode = 3467, SparepartName = "TV Ayağı Aparatı", SparePartPrice = 200 },
                   new Sparepart { Id = 7, SparepartCode = 1456, SparepartName = "Telefon Bataryası", SparePartPrice = 200 },
                   new Sparepart { Id = 8, SparepartCode = 1389, SparepartName = "Telefon Ekranı", SparePartPrice = 400 },
                   new Sparepart { Id = 9, SparepartCode = 4321, SparepartName = "Çamaşır Makina Kazanı", SparePartPrice = 1000 },
                   new Sparepart { Id = 10, SparepartCode = 4526, SparepartName = "Çamaşır Makine Rezistansı", SparePartPrice = 500 }
                   );
        }
    }
}
