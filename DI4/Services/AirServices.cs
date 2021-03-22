using System.Collections.Generic;
using DI4.Models;
namespace DI4.Services
{
    public class AirServices
    {
        List<Air> _air=new List<Air>();
        public AirServices()
        {
            
        }
        public  List<Air> GetAir()
        {
           return _air;
        }
        public void AddAir(Air air)
        {
            _air.Add(air);
        }

    }
   
}