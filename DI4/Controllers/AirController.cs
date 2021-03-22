using Microsoft.AspNetCore.Mvc;
using DI4.Services;
using DI4.Models;
namespace DI4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirController:ControllerBase
    {
          AirServices _airServices;
        public AirController( AirServices airServices)
        {
            this._airServices=airServices;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok( this._airServices.GetAir());
        }
        [HttpPost]
        public ActionResult Post(Air air)
        {
            this._airServices.AddAir(air);
            return Ok();
        }
    }
}