using System;
using System.Collections.Generic;

using Bakery.Models;

public class Program
{
  public static void Main()
  {
    Bread baguette = new Bread("Fresh Baguette",5,0);
    Bread sourdough = new Bread ("Sourdough Loaf",5,0);
    Bread biscuit = new Bread ("Tender Paw Biscuits",5,0);
    Pastry kingcake = new Pastry ("Catnip King Cake",2);
    Pastry sweetroll = new Pastry ("Sweet Roll",2);
    Pastry haruspecial = new Pastry ("Haru Special",2);
    List<Bread> Breads = new List<Bread>() {baguette, sourdough, biscuit};
    List<Pastry> Pastrys = new List<Pastry>() {kingcake, sweetroll, haruspecial};
    string item = "";
    // ShoppingCart newShoppingCart = new ShoppingCart(item);
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
      // Console.WriteLine("Oh dear, looks like something has come up.");
      // Console.WriteLine("For now, I can sell you Bread or Pastry");
      // Console.WriteLine("So, Whats it going to be? (Bread/Pastry");
      // string orderBread = Console.ReadLine();
      // if(orderBread == "Bread")
      // {
      //   Console.WriteLine("Okay! How many Breads would you like?");
      //   string stringHowMany = Console.ReadLine();
      //   int breadQuantity = int.Parse(stringHowMany);
      //   int breadPrice = 0;
      //   Bread newBread = new Bread(breadPrice, breadQuantity);
      //   newBread.PurchaseBread(breadQuantity, breadPrice);
      // }
      // else 
      // {
      //   Console.WriteLine("goodbye!");
      // }
      
      // Console.WriteLine("Lets start with Bread. Please enter the bread type");
      // string order = Console.ReadLine();
      // if(order == "Fresh Baguette")
      // {
      //   Console.WriteLine("How many Fresh Baguettes would you like? Enter a number Please");
      //   string quantity = Console.ReadLine();
      //   if(quantity =="1")

      // }
      // if(order == "Sourdough Loaf")
      // {
      //   Console.WriteLine("How many Sourdoug Loafs would you like? Enter a number Please");
      //   string quantity = Console.ReadLine();
      //   if(quantity =="1")
      // }
      // Console.WriteLine("Its time to make your selection. Plesase ")
    
    
  
    


    // public static void MAIN ends below
  }
  // puclic class program ends below
}