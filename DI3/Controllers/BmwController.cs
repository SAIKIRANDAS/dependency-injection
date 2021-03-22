using Microsoft.AspNetCore.Mvc;
using di3.Service;
using di3.Models;
namespace DI3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BmwController:ControllerBase
    {
        BmwService _bmwService;
        public BmwController(BmwService bmwService)
        {
            this._bmwService= bmwService;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(this._bmwService.GetBmw());
        }
        [HttpPost]
        public void Post(Bmw bmw)
        {
            this._bmwService.AddBmw(bmw);
            return Ok();
        }
        
    }
}