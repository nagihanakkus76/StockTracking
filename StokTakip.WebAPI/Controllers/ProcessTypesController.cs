using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StokTakip.BusinessLayer.Abstract;
using StokTakip.EntitiesLayer;

namespace StokTakip.WebAPI.Controllers
{
    //public class ProcessTypesController : BaseController
    //{
    //    private readonly IProcessTypeService _processTypeService;


    //    public ProcessTypesController(IProcessTypeService processTypeService)
    //    {
    //        _processTypeService = processTypeService;
    //    }

    //    [HttpGet("{id}")]
    //    public IActionResult GetByID(int id)
    //    {
    //        var result = _processTypeService.GetByID(id);
    //        return Ok(result);
    //    }

    //    [HttpGet]
    //    public IActionResult GetAll()
    //    {
    //        var result = _processTypeService.GetAll();
    //        return Ok(result);
    //    }

    //    [HttpPost]
    //    public IActionResult Insert(ProcessType processType)
    //    {
    //        _processTypeService.Insert(processType);
    //        return Ok("Kayıt Başarılı");
    //    }

    //    [HttpPut]
    //    public IActionResult Update(ProcessType processType)
    //    {
    //        _processTypeService.Update(processType);
    //        return Ok("Güncelleme başarılı");
    //    }

    //    [HttpDelete]
    //    public IActionResult Delete(ProcessType processType)
    //    {
    //        _processTypeService?.Delete(processType);
    //        return Ok("Kayıt silindi");
    //    }

    //}
}
