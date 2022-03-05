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
   
  }
}