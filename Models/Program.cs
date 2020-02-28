using System;
using System.Collections.Generic;

using Bakery.Models;

public class Program
{
  public static void Main()
  {
    Bread baguette = new Bread("Fresh Baguette",5);
    Bread sourdough = new Bread ("Sourdough Loaf",5);
    Bread biscuit = new Bread ("Tender Paw Biscuits",5);
    Pastry kingcake = new Pastry ("Catnip King Cake",2);
    Pastry sweetroll = new Pastry ("Sweet Roll",2);
    Pastry haruspecial = new Pastry ("Haru Special",2);
    List<Bread> Breads = new List<Bread>() {baguette, sourdough, biscuit};
    List<Pastry> Pastrys = new List<Pastry>() {kingcake, sweetroll, haruspecial};
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

      Console.WriteLine("Would you like to make a purchase? (yes/no)");
      string start = Console.ReadLine();
      if(start == "yes")
      {
        Console.WriteLine("Wonderful! We have a couple of specials today:");
        Console.WriteLine("Buy two Breads get one free!");
        Console.WriteLine("Buy one Pastry for $2, or you can get three for $5!");
        Console.WriteLine("Just say 'meow' and I'll show you the menu again");
        Console.WriteLine("From there, you can select your items");
        string meow = Console.ReadLine();
        if(meow == "meow")
        {
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
        }
      }
    
    
  
    


    // public static void MAIN ends below
  }
  // puclic class program ends below
}