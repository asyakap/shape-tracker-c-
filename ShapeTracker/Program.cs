using System;
using ShapeTracker.Models;
using System.Collections.Generic;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Shape Tracker app!");
      Console.WriteLine("We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides.");
      Console.WriteLine("Please enter a number:");
      string stringNumber1 = Console.ReadLine();
      Console.WriteLine("Enter another number:");
      string stringNumber2 = Console.ReadLine();
      Console.WriteLine("Enter a third number:");
      string stringNumber3 = Console.ReadLine();
      int length1 = int.Parse(stringNumber1);
      int length2 = int.Parse(stringNumber2);
      int length3 = int.Parse(stringNumber3);
      Triangle tri = new Triangle(length1, length2, length3);
      ConfirmOrEditTriangle(tri);
      DisplayAll();
      RemoveAll();

      Console.WriteLine("Now let's calculate an area of a Rectangle!");
      Console.WriteLine("Please enter a first side:");
      string stringSide1 = Console.ReadLine();
      Console.WriteLine("Please enter a second side:");
      string stringSide2 = Console.ReadLine();
      int recLength1 = int.Parse(stringSide1);
      int recLength2 = int.Parse(stringSide2);
      Rectangle rec = new Rectangle(recLength1, recLength2);
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("The area of your rectangle is");
      Console.WriteLine(rec.CalculateArea());
      Console.WriteLine("Goodbye!");
    }

    static void ConfirmOrEditTriangle(Triangle tri)
    {
      Console.WriteLine("Please confirm that you entered in your triangle correctly:");
      Console.WriteLine($"Side 1 has a length of {tri.Side1}.");
      Console.WriteLine($"Side 2 has a length of {tri.Side2}.");
      Console.WriteLine($"Side 3 has a length of {tri.GetSide3()}.");
      Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the triangle's sides");
      string userInput = Console.ReadLine();
      if (userInput == "yes")
      {
        CheckTriangleType(tri);
      }
      else
      {
        Console.WriteLine("Let's fix your triangle. Please enter the 3 sides again!");
        Console.WriteLine("Please enter a number:");
        string stringNumber1 = Console.ReadLine();
        Console.WriteLine("Enter another number:");
        string stringNumber2 = Console.ReadLine();
        Console.WriteLine("Enter a third number:");
        string stringNumber3 = Console.ReadLine();
        tri.Side1 = int.Parse(stringNumber1);
        tri.Side2 = int.Parse(stringNumber2);
        tri.SetSide3(int.Parse(stringNumber3));
        ConfirmOrEditTriangle(tri);
      }
    }

    static void CheckTriangleType(Triangle tri)
    {
      string result = tri.CheckType();
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("Your result is: " + result + ".");
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("What's next?");
      Console.WriteLine("Would you like to check a new triangle (new)?");
      Console.WriteLine("Please enter 'new' to check the type of a new triangle. To proceed, enter any key.");
      string userResponse = Console.ReadLine();
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Please proceed with the next question!");
      }
    }

    static void DisplayAll()
    {
      Console.WriteLine("Would you like to see all of the triangles created? Please answer with 'yes' or 'no' below");
      string userAnswer = Console.ReadLine();
      if (userAnswer == "yes")
      {
        List<Triangle> actualResult = Triangle.GetAll();
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Here are the sides of the triangles saved:");
        foreach (Triangle item in actualResult)
        {
          Console.WriteLine(item.Side1 + " " + item.Side2 + " " + item.GetSide3());
        }
      }
      else
      {
        Console.WriteLine("Let's proceed!");
      }
    }

    static void RemoveAll()
    {
      Console.WriteLine("Would you like to remove triangles created? Please answer with 'yes' or 'no' below");
      string userAnswer = Console.ReadLine();
      if (userAnswer == "yes")
      {
        Triangle.ClearAll();
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("All of the triangles are deleted");
      }
      else
      {
        Console.WriteLine("Let's proceed!");
      }
    }

  }
}