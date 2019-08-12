namespace BurgerShack.Models
{
  //NOTE Derived classes can Inherit from a base class by using the ':'
  class Burger : Food
  {
    public Burger(string Name, int Cost) : base(Name, Cost)
    {
    }
  }
}