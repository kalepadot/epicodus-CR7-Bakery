using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public string BreadName { get; set; }
    public int BreadPrice { get; set; }
    public int BreadQuantity { get; set; }
    
    public Bread(string breadName, int breadPrice, int breadQuantity)
    {
      BreadName = breadName;
      BreadPrice = 5;
      BreadQuantity = breadQuantity;
    }

    public static void OrderBread()
    {
      for(int i = 1; i < breadQuantity; i++)
      {
        if(breadQuantity % 3 == 0)
        {
          breadPrice += 0;
        }
        else
        {
          breadPrice += 5;
        }
      }
        BreadReciept();
    }
  

    public static void BreadReciept()
    {
      Console.WriteLine("Your order comes out to $" + biscuit.BreadPrice);
      Console.WriteLine("Thank you for stopping in!");
    }
  }
}
 