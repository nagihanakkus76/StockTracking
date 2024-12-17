using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StokTakip.BusinessLayer.Abstract;
using StokTakip.BusinessLayer.Dtos.Product.Requests;
using StokTakip.EntitiesLayer;

namespace StokTakip.WebAPI.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var result = _productService.GetByIDAsync(id);
            return Ok(result);
        }

        [HttpGet]
    public IActionResult GetAll()
    {
        var result = _productService.GetAllAsync();
        return Ok(result);
    }

        [HttpPost]
        public IActionResult Insert(InsertProductRequest dto)
        {
            _productService.InsertAsync(dto);
            return Ok("Kayıt Başarılı.");
        }

        [HttpPut]
        public IActionResult Update(UpdateProductRequest dto)
        {
            _productService.UpdateAsync(dto);
            return Ok("Güncelleme  Başarılı.");
        }

        [HttpDelete]
        public IActionResult Delete(Product product)
        {
            _productService.DeleteAsync(product);
            return Ok("Kayıt silindi.");
        }

        [HttpPut("{id}/increase/{number}")]
        public IActionResult IncreaseStock(int id, int number)
        {
            _productService.IncreaseStockAsync(id, number);
            return Ok("Ekleme işlemi başarılı");
        }

        [HttpPut("{id}/decrease/{number}")]
        public IActionResult DecreaseStock(int id, int number)
        {
            _productService.DecreaseStockAsync(id, number);
            return Ok("Azaltma işlemi başarılı");
        }

    }
}
