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

  }
}
