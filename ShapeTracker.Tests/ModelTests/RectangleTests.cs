using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests : IDisposable
  {
    public void Dispose()
    {
      Rectangle.ClearAll();
    }

    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(2, 3);
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }


    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      int length1 = 3;
      Rectangle newRectangle = new Rectangle(length1, 2);
      int result = newRectangle.Side1;
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      Rectangle newRectangle = new Rectangle(2, 3);
      int newLength1 = 3;
      newRectangle.Side1 = newLength1;
      Assert.AreEqual(newLength1, newRectangle.Side1);
    }

    [TestMethod]
    public void GetSide1_ReturnsSide2_Int()
    {
      int length2 = 2;
      Rectangle newRectangle = new Rectangle(3, length2);
      int result = newRectangle.Side2;
      Assert.AreEqual(length2, result);
    }

    [TestMethod]
    public void SetSide2_SetsValueOfSide2_Void()
    {
      Rectangle newRectangle = new Rectangle(2, 3);
      int newLength2 = 4;
      newRectangle.Side2 = newLength2;
      Assert.AreEqual(newLength2, newRectangle.Side2);
    }

        [TestMethod]
    public void CalculateArea_CalculatesArea_Int()
    {
      Rectangle newRectangle = new Rectangle(2, 3);
      int area = newRectangle.CalculateArea();
      Assert.AreEqual(6, area);
    }

    [TestMethod]
    public void GetAll_ReturnsAllRectangleInstances_List()
    {
      Rectangle rec1 = new Rectangle(2, 2);
      Rectangle rec2 = new Rectangle(21, 3);
      Rectangle rec3 = new Rectangle(1, 3);
      List<Rectangle> expected = new List<Rectangle> { rec1, rec2, rec3 };
      // Act
      List<Rectangle> actualRectangles = Rectangle.GetAll();
      // Assert
      CollectionAssert.AreEqual(expected, actualRectangles);
    }

        [TestMethod]
    public void ClearAll_DeletesAllRectangleInList_Void()
    {
      // Arrange
      Rectangle rec1 = new Rectangle(2, 2);
      Rectangle rec2 = new Rectangle(21, 3);
      Rectangle rec3 = new Rectangle(1, 3);
      List<Rectangle> expected = new List<Rectangle> { };
      // Act
      Rectangle.ClearAll();
      // Assert
      CollectionAssert.AreEqual(expected, Rectangle.GetAll());
    }

  }
}
