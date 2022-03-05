using System;
using System.Collections.Generic;

namespace PierreVendorTracker.Models
{
  public class Vendor
  {
    public static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }


    public Vendor(string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}