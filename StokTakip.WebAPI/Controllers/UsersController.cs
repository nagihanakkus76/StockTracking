using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StokTakip.BusinessLayer.Abstract;
using StokTakip.BusinessLayer.Dtos.User.Requests;
using StokTakip.BusinessLayer.Dtos.User.Responses;
using StokTakip.EntitiesLayer;

namespace StokTakip.WebAPI.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id) 
        {
            var result = _userService.GetByIDAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var result = _userService.GetAllAsync();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Insert(InsertUserRequest dto ) 
        {
            _userService.InsertAsync(dto);
            return Ok("Kayıt Başarılı");
        }

        [HttpPut]
        public IActionResult Update(UpdateUserRequest dto)
        {
            _userService.UpdateAsync(dto);
            return Ok("Güncelleme başarılı");
        }

        [HttpDelete]
        public IActionResult Delete(User user) 
        {
            _userService.DeleteAsync(user);
            return Ok("Kayıt silindi");
        }
    }
}