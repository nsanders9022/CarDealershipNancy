using Nancy;
using Cars.Objects;
using System.Collections.Generic;

namespace CarDealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_car.cshtml"];
      Get["/view_all_cars"] = _ => {
        List<Car> allCars = Car.GetAll();
        return View["view_all_cars.cshtml", allCars];
      };
      Post["/cars_added"] = _ => {
        Car newCar = new Car(Request.Form["new-makeModel"], Request.Form["new-miles"], Request.Form["new-price"]);
        newCar.Save();
        return View["cars_added.cshtml", newCar];
      };
      Post["/cars_cleared"] = _ => {
        Car.ClearAll();
        return View["cars_cleared.cshtml"];
      };
    }
  }
}
