using Application.Entity.DTOs;
using Application.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataAccess.Abstract
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Task<List<Product_Sparepart>> Add(Product_Sparepart entity);
        Task<object> AddAsync(List<Product_Sparepart> product_Spareparts);
        object AddAsync(ProductWithSparepartDto productDto);
    }
}
