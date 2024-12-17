using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StokTakip.BusinessLayer.Abstract;
using StokTakip.EntitiesLayer;

namespace StokTakip.WebAPI.Controllers
{
    //public class ProcessesController : BaseController
    //{
    //    private readonly IProcessesService _processesService;

    //    public ProcessesController(IProcessesService processesService)
    //    {
    //        _processesService = processesService;
    //    }
    //    [HttpGet("{id}")]
    //    public IActionResult GetByID(int id)
    //    {
    //        var result = _processesService.GetByID(id);
    //        return Ok(result);
    //    }

    //    [HttpGet]
    //    public IActionResult GetAll()
    //    {
    //        var result = _processesService.GetAll();
    //        return Ok(result);
    //    }

    //    [HttpPost]
    //    public IActionResult Insert(Processes processes) 
    //    {
    //        _processesService.Insert(processes);
    //        return Ok("Kayıt Başarılı");
    //    }

    //    [HttpPut]
    //    public IActionResult Update(Processes processes) 
    //    {
    //        _processesService.Update(processes);
    //        return Ok("Güncelleme başarılı");
    //    }

    //    [HttpDelete]
    //    public IActionResult Delete(Processes processes) 
    //    {
    //        _processesService.Delete(processes);
    //        return Ok("Kayıt silindi");
    //    }


    //}
}
