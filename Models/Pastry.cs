using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public string PastryName { get; set; }
    public int PastryPrice { get; set; }
    public int PastryQuantity { get; set; }

    public Pastry(string pastryName, int pastryPrice, int pastryQuantity)
    {
      PastryName = pastryName;
      PastryPrice = 2;
      PastryQuantity = pastryQuantity;

    }

    public static void OrderPastry()
    {
      for(int i = 1; i < pastryQuantity; i++)
      if(pastryQuantity % 3 == 0)
      {
        // need bread working
        pastryPrice;
      }
      PastryReciept()
    }
    
    public static void PastryReciept()
    {
      Console.WriteLine("Your order comes out to $" + sweetroll.PastryPrice);
      Console.WriteLine("Than you for stopping in!");
    }
  }
}