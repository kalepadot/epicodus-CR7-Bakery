using System;
using System.Collections.Generic;

using Bakery.Models;

public class Program
{
  public static void Main()
  {
    Bread baguette = new Bread("Fresh Baguette",5);
    List<Bread> Breads = new List<Bread>() {baguette};
    foreach (Bread cart in Breads)
    {
      Console.WriteLine(cart.GetBreadPrice());
    }
    Console.WriteLine("Welcome Message");
    // Console.WriteLine(GetBreadPrice);
    // int breadPrice = int.Parse(stringGetBreadPrice);
    


    // public static void MAIN ends below
  }
  // puclic class program ends below
}