using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public string PastryName { get; set; }
    public int PastryPrice { get; set; } = 2;
    public int PastryQuantity { get; set; } = 0;
    public int Total { get; set; } = 0;

    public Pastry(string pastryName, int pastryPrice, int pastryQuantity)
    {
      PastryName = pastryName;
    }

    public void OrderPastry()
    {
      Total = PastryQuantity * 2 -1 * (PastryQuantity / 3);
      PastryReciept();
    }
    
    public void PastryReciept()
    {
      Console.WriteLine("Your order comes out to $" + Total);
      Console.WriteLine("Than you for stopping in!");
    }
  }
}
    