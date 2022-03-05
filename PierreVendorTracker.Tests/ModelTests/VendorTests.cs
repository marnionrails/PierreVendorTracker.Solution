using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreVendorTracker.Models;
using System.Collections.Generic;
using System;

namespace PierreVendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()  
    {
      Vendor.ClearAll();
    }   
    
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("testVendor");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string name = "Emily's Cafe";
      Vendor testVendor = new Vendor(name);
      string result = testVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetVendorId_ReturnsVendorId_Int()
    {
      string name = "Emily's Cafe";
      Vendor testVendor = new Vendor(name);
      int result = testVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Emily's Cafe";
      string name02 = "Thomas Sweets";
      Vendor testVendor1 = new Vendor(name01);
      Vendor testVendor2 = new Vendor(name02);
      List<Vendor> testList = new List<Vendor> { testVendor1, testVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(testList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Emily's Cafe";
      string name02 = "Thomas Sweets";
      Vendor testVendor1 = new Vendor(name01);
      Vendor testVendor2 = new Vendor(name02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(testVendor2, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string title = "Donut";
      string description = "Chocolate with rainbow sprinkles";
      double price = 2.99;
      Order testOrder = new Order(title, description, price);
      List<Order> newList = new List<Order> { testOrder };
      string name = "Annie's Cupcake Shop";
      Vendor newVendor = new Vendor(name);
      newVendor.AddOrder(testOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);

    }
  }
}