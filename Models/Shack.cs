using System;
using System.Collections.Generic;

namespace BurgerShack.Models
{
  class Shack
  {
    public string Location { get; private set; }
    private List<Food> AvailableFood { get; set; }
    // private List<Food> SoldOutFood { get; set; }

    public void PrintMenu()
    {
      for (int i = 0; i < AvailableFood.Count; i++)
      {
        Food f = AvailableFood[i];
        System.Console.WriteLine($"{i + 1}. {f.Name} Price: {f.Cost}");
      }
    }



    public Food GetFoodFromUserChoice()
    {
      if (Int32.TryParse(Console.ReadLine(), out int n))
      {
        n = n - 1;
        if (n < 0 || n >= AvailableFood.Count)
        {
          return null;
        }
        // add AvailableFood[n] to cart?
        return AvailableFood[n];
      }
      return null;
    }


    public void BuyFood()
    {
      var currentlyInTheProcessOfBuyingFood = true;
      while (currentlyInTheProcessOfBuyingFood)
      {
        Console.Clear();
        PrintMenu();
        Console.WriteLine("Please make a selection: ");
        Food food = GetFoodFromUserChoice();
        if (food == null)
        {
          currentlyInTheProcessOfBuyingFood = false;
        }
      }
    }


    public void PurchaseTotal()
    {
      // display contents of cart
      // add cost of all items in cart
      // display total cost of all items in cart
    }




    public void AddFood(Food f)
    {
      AvailableFood.Add(f);
    }

    public Shack(string location)
    {
      Location = location;
      AvailableFood = new List<Food>();
      // SoldOutFood = new List<Food>();
    }
  }
}