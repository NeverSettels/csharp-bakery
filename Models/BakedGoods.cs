
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
        private static int _pastryLeft = 10;
        private string _typePastry;
        private string _flavorPastry;
        private int _pricePastry;
        
        public static int PastryLeft
    {
        get
        {
            return _pastryLeft; 
        }
    
    }
      public string TypePastry 
    {
        get
        {
            return _typePastry; 
        }
        set
        {
            _typePastry = value; 
        }
    }
      public string FlavorPastry 
    {
        get
        {
            return _flavorPastry; 
        }
        set
        {
            _flavorPastry = value; 
        }
    }
      public int PricePastry 
    {
        get
        {
            return _pricePastry; 
        }
        set
        {
            _pricePastry = value; 
        }
    }
    public Pastry(string type, string flavor,int price)
    {
        _typePastry = type;
        _flavorPastry = flavor;
        _pricePastry = price; 
    }
    }
    

}