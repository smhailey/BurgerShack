using System;
using BurgerShack.Models;

namespace BurgerShack
{
  class Program
  {
    static void Main(string[] args)
    {
      Shack bs = new Shack("Boise Location");
      Burger hamburger = new Burger("Hamburger", 5);
      Burger cheeseburger = new Burger("Cheeseburger", 7);
      Side fries = new Side("French Fries", 3);

      //NOTE Burgers are implicitly casted to Food
      bs.AddFood(hamburger);

    }
  }
}
