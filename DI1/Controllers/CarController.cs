using Microsoft.AspNetCore.Mvc;
using di1.Services;
using di1.Models;

namespace di1.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController:ControllerBase
    {
        CarService _carService;
        public CarController (CarService carService)
        {
            this._carService=carService;
        }
        [HttpGet]
        public ActionResult Get()
        {
            Return Ok( this._carService.GetCars());
        }
        [HttpPost]
        public ActionResult Post(Body body)
        {
            this._carService.AddCar(body);
            Return Ok();
        }
    }
}