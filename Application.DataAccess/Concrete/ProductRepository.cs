using Application.DataAccess.Abstract;
using Application.Entity.DTOs;
using Application.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataAccess.Concrete
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        protected readonly DataContext _context;
        private readonly DbSet<Product> _dbSet;

        public ProductRepository(DataContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Product>();
        }

        public async Task<List<Product_Sparepart>> Add(Product_Sparepart entity)
        {
           var products=  await _context.Product_Spareparts.Include(a => a.Product).Include(a => a.Sparepart).ToListAsync();
            return products;
        }

        public async Task<object> AddAsync(List<Product_Sparepart> product_Spareparts)
        {
            var products = await _context.Product_Spareparts.Include(a => a.Product).Include(a => a.Sparepart).ToListAsync();
            return products;
        }

        public object AddAsync(ProductWithSparepartDto productDto)
        {
            throw new NotImplementedException();
        }
    }
}
