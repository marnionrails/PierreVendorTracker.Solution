using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierreVendorTracker.Models;

namespace PierreVendorTracker.Tests 
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new Order("test");
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
     [TestMethod]
      public void GetTitle_ReturnsTitle_String()
    {
      string title = "Donut";
      Order testOrder = new Order(title);

      string result = testOrder.Title;

      Assert.AreEqual(title, result);
    }
  }
}