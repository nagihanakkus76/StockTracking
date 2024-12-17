using StokTakip.BusinessLayer.Dtos.Product.Requests;
using StokTakip.BusinessLayer.Dtos.Product.Responses;
using StokTakip.BusinessLayer.Dtos.User.Responses;
using StokTakip.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLayer.Abstract
{
    public interface IProductService
    {
        Task InsertAsync(InsertProductRequest dto);
        Task UpdateAsync(UpdateProductRequest dto);
        Task DeleteAsync(Product product);
        Task<List<ListProductResponse>> GetAllAsync(Expression<Func<ListProductResponse, bool>>? predicate = null);
        Task<GetByIdProductResponse> GetByIDAsync(int id);
        Task IncreaseStockAsync(int id, int number);
        Task DecreaseStockAsync(int id, int number);
    }
}
