
namespace Bakery.Models
{
    public class Bread
    {
        private static int _breadLeft = 10;
        private string _typeBread;
        private int _priceBread;
        
        public static int BreadLeft
    {
        get
        {
            return _breadLeft; 
        }
    
    }
      public string TypeBread 
    {
        get
        {
            return _typeBread; 
        }
        set
        {
            _typeBread = value; 
        }
    }
      public int PriceBread 
    {
        get
        {
            return _priceBread; 
        }
        set
        {
            _priceBread = value; 
        }
    }
    public Bread(string type, int price)
    {
        _typeBread = type;
        _priceBread = price; 
    }
    }
    public class Pastry
    {
        //type of Pastry
        //falvour
        //price
        //loaves left
    }

}