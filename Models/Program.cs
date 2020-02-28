using System;
using System.Collections.Generic;

using Bakery.Models;

public class Program
{
  public static void Main()
  {
    Bread baguette = new Bread("Fresh Baguette",5);
    Bread sourdough = new Bread ("Sourdough Loaf",5);
    Pastry sweetroll = new Pastry ("Sweet Roll", 2);
    List<Bread> Breads = new List<Bread>() {baguette, sourdough};
    List<Pastry> Pastrys = new List<Pastry>() {sweetroll};
    Console.WriteLine("Welcome to Haru's Bakery");
    Console.WriteLine("Take a look at our menu");
    foreach (Bread cart in Breads)
    {
      Console.WriteLine(cart.GetBreadName());
      Console.WriteLine(cart.GetBreadPrice());
    }
    foreach (Pastry cart in Pastrys)
    {
      Console.WriteLine(cart.GetPastryName());
      Console.WriteLine(cart.GetPastryPrice());
    }
    
  
    


    // public static void MAIN ends below
  }
  // puclic class program ends below
}