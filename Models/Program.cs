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
    string item = "";
    ShoppingCart newShoppingCart = new ShoppingCart(item);
    Console.WriteLine("Welcome to Haru's Bakery");
    Console.WriteLine("Take a look at our menu");
    foreach (Bread selection in Breads)
    {
      Console.WriteLine(selection.GetBreadName());
      Console.WriteLine(selection.GetBreadPrice());
    }
      foreach (Pastry selection in Pastrys)
      {
        Console.WriteLine(selection.GetPastryName());
        Console.WriteLine(selection.GetPastryPrice());
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
          foreach (Bread selection in Breads)
          {
            Console.WriteLine(selection.GetBreadName());
            Console.WriteLine(selection.GetBreadPrice());
          }
          foreach (Pastry selection in Pastrys)
          {
            Console.WriteLine(selection.GetPastryName());
            Console.WriteLine(selection.GetPastryPrice());
          }
        }
      }
      // Console.WriteLine("Its time to make your selection. Plesase ")
    
    
  
    


    // public static void MAIN ends below
  }
  // puclic class program ends below
}