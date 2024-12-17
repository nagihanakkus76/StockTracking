using StokTakip.DataAccessLayer.Abstract;
using StokTakip.DataAccessLayer.EntityFramework;
using StokTakip.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccessLayer.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductDal
    {
        public async Task DecreaseStockAsync(int id, int number)
        {
            using var context = new StockTrackerContext();
            var _product = await GetByIDAsync(id);
            _product.AmountOfStock -= number;
            context.Set<Product>().Update(_product);
            context.SaveChanges();
        }

        public async Task IncreaseStockAsync(int id, int number)
        {
             using var context = new StockTrackerContext();
            var _product = await GetByIDAsync(id);
            _product.AmountOfStock += number;
            context.Set<Product>().Update(_product);
            context.SaveChanges();
        }
    }
}
