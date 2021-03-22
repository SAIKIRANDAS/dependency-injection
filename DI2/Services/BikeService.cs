using System.Collections.Generic;
using di2.Models;
namespace di2.Services
{
    public class BikeService
    {
        List<Bike> _BikeList=new List<Bike>();
        public BikeService()
        {
            
        }
        public List<Bike> GetBikes()
        {
            return _BikeList;
        }
        public void AddBike(Bike bike)
        {
            this._BikeList.Add(bike);
        }
    }
}