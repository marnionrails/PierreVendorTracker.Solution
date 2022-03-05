using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreVendorTracker.Models;
using System.Collections.Generic;
using System;

namespace PierreVendorTracker.Tests
{
  [TestClass]
  public class VendorTests
  {     
    

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
   
  }
}