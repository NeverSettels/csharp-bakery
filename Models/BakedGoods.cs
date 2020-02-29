
namespace Bakery.Models
{
  public class Bread
  {
      

      private string _nameBread;
      private string _typeBread;
      private int _priceBread;
    
      public string NameBread 
  {
      get
      {
          return _nameBread; 
      }
      set
      {
          _nameBread = value; 
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
  public Bread(string name,string type, int price)
  {
      _nameBread = name;
      _typeBread = type;
      _priceBread = price; 
  }
  }

  public class Pastry
  {
    
      private string _namePastry;
      private string _typePastry;
      private string _flavorPastry;
      private int _pricePastry;
      
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
    public string NamePastry 
  {
      get
      {
          return _namePastry; 
      }
      set
      {
          _namePastry = value; 
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
  public Pastry(string name, string type, string flavor,int price)
  {
      _namePastry = name;
      _typePastry = type;
      _flavorPastry = flavor;
      _pricePastry = price; 
  }
  }
  

}