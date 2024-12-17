using AutoMapper;
using StokTakip.BusinessLayer.Abstract;
using StokTakip.BusinessLayer.Dtos.Product.Requests;
using StokTakip.BusinessLayer.Dtos.Product.Responses;
using StokTakip.DataAccessLayer.Abstract;
using StokTakip.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IMapper _mapper;
        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        public async Task DecreaseStockAsync(int id, int number)
        {
            await _productDal.DecreaseStockAsync(id, number);
        }

        public async Task DeleteAsync(Product product)
        {
            await _productDal.DeleteAsync(product);
        }

        public async Task<List<ListProductResponse>> GetAllAsync(Expression<Func<ListProductResponse, bool>>? predicate = null)
        {
            List<Product> products = await _productDal.GetAllAsync();
            List<ListProductResponse> response = _mapper.Map<List<ListProductResponse>>(products);
            return response;
        }

        public async Task<GetByIdProductResponse> GetByIDAsync(int id)
        {
            Product product = await _productDal.GetByIDAsync(id);
            GetByIdProductResponse response = _mapper.Map<GetByIdProductResponse>(product);
            return response;
        }

        public async Task IncreaseStockAsync(int id, int number)
        {
            await _productDal.IncreaseStockAsync(id, number);
        }

        public async Task InsertAsync(InsertProductRequest dto)
        {
            Product product = _mapper.Map<Product>(dto);
            await _productDal.InsertAsync(product);
        }

        public async Task UpdateAsync(UpdateProductRequest dto)
        {
            Product product = _mapper.Map<Product>(dto);
            await _productDal.UpdateAsync(product);
        }
    }
}