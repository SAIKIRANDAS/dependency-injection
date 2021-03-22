using Microsoft.AspNetCore.Mvc;
using di2.Services;
using di2.Models;

namespace di2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BikeController:ControllerBase
    {
        BikeService _bikeService;
       public BikeController(BikeService bikeService)
      { 
         this._bikeService=bikeService;
      }        
       [HttpGet]
       public ActionResult Get()
       {
           return Ok(this._bikeService.GetBikes());
       }
       [HttpPost]
       public ActionResult Post(Bike bike)
       {
           this._bikeService.AddBike(bike);
           return Ok();
       }
    }
}