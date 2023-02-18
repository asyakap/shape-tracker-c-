using System.Collections.Generic;

namespace ShapeTracker.Models
{
  public class Rectangle
  {
    private int _side1;
    public int Side1
    {
      get { return _side1; }
      set { _side1 = value; }
    }
    private int _side2;
    public int Side2
    {
      get { return _side2; }
      set { _side2 = value; }
    }

    private static List<Rectangle> _instances = new List<Rectangle> { };

    public Rectangle(int length1, int length2)
    {
      _side1 = length1;
      _side2 = length2;
      _instances.Add(this);
    }

    public int CalculateArea()
    {
      int area = Side1 * Side2;
      return area;
    }

    public static List<Rectangle> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}