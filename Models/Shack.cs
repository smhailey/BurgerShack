using System;
using System.Collections.Generic;

namespace BurgerShack.Models
{
  class Shack
  {
    public string Location { get; private set; }
    private List<Food> AvailableFood { get; set; }
    private List<Food> SoldOutFood { get; set; }




    public void AddFood(Food f)
    {
      AvailableFood.Add(f);
    }

    public Shack(string location)
    {
      Location = location;
      AvailableFood = new List<Food>();
      SoldOutFood = new List<Food>();
    }
  }
}