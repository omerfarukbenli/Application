using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataAccess.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll(); //listele
        Task<T> GetByIdAsync(int id); //id'ye göre getir
        Task AddAsync(T entity); //ekle
        void Update(T entity); //güncelle
        void Remove(T entity); //sil
        
    }
}
