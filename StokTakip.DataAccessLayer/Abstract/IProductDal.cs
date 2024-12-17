using StokTakip.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
       Task IncreaseStockAsync (int id,int number);
       Task DecreaseStockAsync (int id,int number);
    }
}
