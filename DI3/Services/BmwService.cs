using System.Collections.Generic;
using di3.Models;
namespace DI3.Services
{
    public class BmwService
    {
        List<Bmw> _bmwList=new List<Bmw>();
        public BmwService()
        {
            
        }
        public List<Bmw> GetBmw()
        {
            return _bmwList;
        }
        public void AddBmw(Bmw bmw)
        {
            _bmwList.Add(bmw);
        }
    }
}