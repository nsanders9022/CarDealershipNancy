using System.Collections.Generic;

namespace Cars.Objects
{
  public class Car
  {
    private string _makeModel;
    private int _miles;
    private int _price;
    private static List<Car> _instances = new List<Car>{};

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public Car(string carMakeModel, int carMiles, int carPrice)
    {
      _makeModel = carMakeModel;
      _miles = carMiles;
      _price = carPrice;
    }


  }

}
