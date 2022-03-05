using System;
using System.Collections.Generic;

namespace PierreVendorTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }


    public Vendor(string name)
    {
      Name = name;
    }
  }
}