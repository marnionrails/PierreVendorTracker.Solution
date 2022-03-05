using System;
using System.Collections.Generic;

namespace PierreVendorTracker.Models
{
  public class Order 
  {
    public string Title { get; set; }
    public string Description { get; set; }

    public double Price { get; set; }
    public int Id { get; set; }

    public static List<Order> _instances = new List<Order> {};

    public DateTime orderTime { get; set; }

    public Order(string title, string description, double price)
    {
      Title = title;
      Description = description;
      Price = price;
      orderTime = DateTime.Now;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }

}