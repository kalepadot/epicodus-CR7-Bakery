using System;
using System.Collections.Generic;

using Bakery.Models;

public class Program
{
  public static void Main()
  {
    Bread baguette = new Bread("Fresh Baguette",5);
    List<Bread> Breads = new List<Bread>() {baguette};
    Console.WriteLine("Welcome Message");
    foreach (Bread cart in Breads)
    {
      Console.WriteLine(cart.GetBreadName());
      Console.WriteLine(cart.GetBreadPrice());
    }
    
  
    


    // public static void MAIN ends below
  }
  // puclic class program ends below
}