namespace DI6.Controllers
{
      [ApiController]
      [Route("[controller]")]
    public class fruitsController:controllerBase
    {
        fruitsservices _fruitservice;
        public fruitsController(fruitsservices FruitsServices)
        {

        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }
        [HttpPost]
        public ActionResult Post()
        {
            return Ok();
        }
    }

}