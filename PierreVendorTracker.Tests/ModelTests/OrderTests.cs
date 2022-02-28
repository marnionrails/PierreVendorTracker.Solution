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
      Order testOrder = new Order();
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
  }
}