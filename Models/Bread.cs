using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public string BreadName { get; set; }
    public int BreadPrice { get; set; } = 5;
    public int BreadQuantity { get; set; } =0;
    public int Total { get; set; } = 0;
    
    public Bread(string breadName, int breadPrice, int breadQuantity)
    {
      BreadName = breadName;
    }

    public void OrderBread()
    {
      Total =  (BreadQuantity - (BreadQuantity / 3))  * 5;
      BreadReciept();
    }
  
    public void BreadReciept()
    {
      Console.WriteLine("Your order comes out to $" + Total);
      Console.WriteLine("Thank you for stopping in!");
    }
  }
}