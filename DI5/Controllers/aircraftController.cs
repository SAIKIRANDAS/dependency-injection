using Microsoft.AspNetCore.Mvc;
using DI5.Models;
using DI5.Services;
namespace DI5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class aircraftController:ControllerBase
    {
        AircraftService _aircraftService;
        public aircraftController(AircraftService aircraftService)
        {
            this. _aircraftService=aircraftService;
        }
    
      [HttpGet]
        public ActionResult Get()
      {
        return Ok(this. _aircraftService.GetAirs());
      }
      [HttpPost]
      public ActionResult Post(Air air)
      {
           this._aircraftService.AddAir(air);
          return Ok();
      }
    }
}
