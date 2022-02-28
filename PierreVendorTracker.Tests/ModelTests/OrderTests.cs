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
      Order testOrder = new Order("test", "test2");
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
     [TestMethod]
      public void GetTitle_ReturnsTitle_String()
    {
      string title = "Donut";
      Order testOrder = new Order(title, "test2");

      string result = testOrder.Title;

      Assert.AreEqual(title, result);
    }
      [TestMethod]
      public void SetTitle_SetTitle_String()
      {
        string title = "Donut";
        string title2 = "Bagel";
        string description = "example";

        Order testOrder = new Order(title, description);
        testOrder.Title = title2;

        string result = testOrder.Title;

        Assert.AreEqual(title2, result);
      }
      [TestMethod]
      public void GetDescription_ReturnsDescription_String()
      {
        string title = "Donut";
        string description = "Chocolate with rainbow sprinkles";
        Order testOrder = new Order(title, description);
        string result = testOrder.Description;
        Assert.AreEqual(description, result);
      }
  }
}