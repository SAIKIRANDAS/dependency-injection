namespace DI6.services
{
    public class fruitsservices
    {
        List<fruitsservices> _fruitservice =new List<fruitsservices>();
        pblic fruitsservices()
        {

        }
        public List<fruitsservices> Getfruits()
        {
            return _fruitservice;
        }
        public void Addfruits(Fruits fruits)
        {
            _fruitservice.Add(fruits);
        }
    }
}