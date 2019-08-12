namespace BurgerShack.Models
{
  //NOTE Derived classes can Inherit from a base class by using the ':'
  class Side : Food
  {
    public Side(string Name, int Cost) : base(Name, Cost)
    {
    }
  }
}