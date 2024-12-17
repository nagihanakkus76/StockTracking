using StokTakip.DataAccessLayer.Abstract;
using StokTakip.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public async Task DeleteAsync(T t)
        {
            using var context = new StockTrackerContext();
            context.Set<T>().Remove(t);
            context.SaveChanges();
        }

        public async Task<List<T>> GetAllAsync()
        {
            using var context = new StockTrackerContext();
            return context.Set<T>().ToList();
        }

        public async Task<T> GetByIDAsync(int id)
        {
            using var context = new StockTrackerContext();
            return context.Set<T>().Find(id);
        }

        public async Task InsertAsync(T t)
        {
            using var context = new StockTrackerContext();
            context.Set<T>().Add(t);
            context.SaveChanges();
        }

        public async Task UpdateAsync(T t)
        {
            using var context = new StockTrackerContext();
            context.Set<T>().Update(t);
            context.SaveChanges();
        }
    }
}