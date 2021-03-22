using System.Collections.Generic;
using di1.Models;

namespace di1.Services
{
    public class CarService
    {
        List<Body> _carList=new List<Body>();
       
       public  CarService()
       {

       }
       public List<Body> GetCars()
       {
         return _carList;
       }
       public void AddCar(Body body)
       {
         _carList.Add(body);
       }
    }

}