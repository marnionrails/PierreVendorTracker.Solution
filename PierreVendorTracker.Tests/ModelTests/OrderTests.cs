using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierreVendorTracker.Models;

namespace PierreVendorTracker.Tests 
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new Order("test", "test2", 1.99);
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
     [TestMethod]
      public void GetTitle_ReturnsTitle_String()
    {
      string title = "Donut";
      Order testOrder = new Order(title, "test2", 1.99);

      string result = testOrder.Title;

      Assert.AreEqual(title, result);
    }
      [TestMethod]
      public void SetTitle_SetTitle_String()
      {
        string title = "Donut";
        string title2 = "Bagel";
        string description = "example";

        Order testOrder = new Order(title, description, 1.99);
        testOrder.Title = title2;

        string result = testOrder.Title;

        Assert.AreEqual(title2, result);
      }
      [TestMethod]
      public void GetDescription_ReturnsDescription_String()
      {
        string title = "Donut";
        string description = "Chocolate with rainbow sprinkles";
        Order testOrder = new Order(title, description, 1.99);
        string result = testOrder.Description;
        Assert.AreEqual(description, result);
      }
      [TestMethod]
      public void SetDescription_SetDescription_String()
      {
        string title = "Donut";
        string description = "Chocolate with rainbow sprinkles";
        string description2 = "White powder";
        Order testOrder = new Order(title, description, 1.99);
        testOrder.Description = description2;
        string result = testOrder.Description;
        Assert.AreEqual(description2, result);
      }
      [TestMethod]
      public void GetPrice_GetPrice_Double()
      {
        string title = "Donut";
        string description = "Chocolate with rainbow sprinkles";
        double price = 1.99;
        Order testOrder = new Order(title, description, price);
        double result = testOrder.Price;
        Assert.AreEqual(price, result);
      }
      [TestMethod]
      public void SetPrice_SetPrice_Double()
      {
        string title = "Donut";
        string description = "Chocolate with rainbow sprinkles";
        double price = 1.99;
        Order testOrder = new Order(title, description, price);
        testOrder.Price = 2.99;
        double result = testOrder.Price;
        Assert.AreEqual(testOrder.Price, result);
      }
      [TestMethod]
      public void GetDateTime_GetDateTime_DateTime()
      {
        DateTime testNow = DateTime.Now;
        Order testOrder = new Order("Donut", "Chocolate with rainbow sprinkles", 2.99);
        Assert.AreEqual(testNow, testOrder.orderTime);
      }
      [TestMethod]
      public void GetOrderId_GetOrderId_Int()
      {
        Order order1 = new Order("Donut", "Chocolate with rainbow sprinkles", 2.99);
        Order order2 = new Order("Pie", "Apple", 1.99);
        int order2Id = 2;
        int result = order2.Id;
        Assert.AreEqual(order2Id, result);
      }
      [TestMethod]
      public void GetAll_ReturnsAllOrderObject_OrderList()
      {
        Order order1 = new Order("Donut", "Chocolate with rainbow sprinkles", 2.99);
        Order order2 = new Order("Pie", "Apple", 1.99);
        List<Order> testList = new List<Order> { order1, order2 };
        List<Order> result = Order.GetAll();
        CollectionAssert.AreEqual(testList, result);
      }
      [TestMethod]
      public void Find_ReturnsCorrectOrder_Order()
      {
        Order order1 = new Order("Donut", "Chocolate with rainbow sprinkles", 2.99);
        Order order2 = new Order("Pie", "Apple", 1.99);
        Order result = Order.Find(2);
        Assert.AreEqual(order2, result);
      }
  }
}