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
      bs.AddFood(cheeseburger);
      bs.AddFood(fries);

      bool quit = false;
      while (!quit)
      {
        Console.Clear();
        Console.WriteLine("Welcome to Burger Shack");
        Console.WriteLine("things you can do here");
        Console.WriteLine("1 - Purchase food");
        Console.WriteLine("2 - See your total");
        Console.WriteLine("3 - Quit");
        Console.WriteLine("What would you like to do?");
        var userInput = Console.ReadLine();
        if (Int32.TryParse(userInput, out int choice))
        {
          switch (choice)
          {
            case 1:
              Shack.BuyFood();
              break;
            case 2:
              Shack.PurchaseTotal();
              break;
            case 3:
              quit = true;
              Console.Clear();
              Console.WriteLine("Goodbye");
              break;
            default:
              System.Console.WriteLine("Invalid Choice Try again");
              break;
          }
        }



        bs.BuyFood();

      }
    }
  }
}
