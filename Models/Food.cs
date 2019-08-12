namespace BurgerShack.Models
{
  //NOTE Abstract enforces that a class cannot be instantiated
  abstract class Food
  {
    public string Name { get; private set; }
    public int Cost { get; private set; }

    public Food(string name, int cost)
    {
      Name = name;
      Cost = cost;
    }
  }
}