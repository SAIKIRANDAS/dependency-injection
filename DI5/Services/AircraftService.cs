using DI5.Models;
using System.Collections.Generic;
namespace DI5.Services
{
    public class AircraftService
    { 
        List<Air> _aircraftList=new List<Air>();
        public AircraftService()
        {
            
        }
        public List<Air> GetAirs()
        {
            return _aircraftList;
        }
        public void AddAir(Air air)
        {
             _aircraftList.Add(air);
        }
    }

}