using System;
using System.Collections.Generic;
using TriangleTracker;

namespace Tracker 
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter three numbers!");
      string stringNumber1 = Console.ReadLine();
      string stringNumber2 = Console.ReadLine();
      string stringNumber3 = Console.ReadLine();
      int intNumber1 = int.Parse(stringNumber1);
      int intNumber2 = int.Parse(stringNumber2);
      int intNumber3 = int.Parse(stringNumber3);
      
      Triangle userTriangle = new Triangle(intNumber1, intNumber2, intNumber3);

      Console.WriteLine(userTriangle.DoesTriangle()); 
    }
  }
}