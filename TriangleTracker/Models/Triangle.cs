using Tracker;

namespace TriangleTracker
{
  public class Triangle
  {
    public int Side1 { get; set; }
    public int Side2 { get; set; }
    public int Side3 { get; set; }

    public Triangle (int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }

    public string DoesTriangle()
    {
      if ((Side1 > (Side2 + Side3)) || (Side2 > (Side1 + Side3) || (Side3 > (Side1 + Side2))))
      {
        return "Not a Triangle";
      }
      else if ((Side1 != Side2) && (Side1 != Side3) && (Side2 != Side3))
      {
        return "Scalene";
      }
      else if ((Side1 == Side2) && (Side1 == Side3))
      {
        return "Equilateral";
      }
      else
      {
        return "Isosceles";
      }
    }
  }
}