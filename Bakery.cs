using System;
using System.Collections.Generic;

using Bakery.Models;

public class Program
{
  public static void Main()
  {
    Bread biscuit = new Bread ("Tender Paw Biscuits",5,0);
    Pastry sweetroll = new Pastry ("Catnip Sweet Roll",2,0);
    List<Bread> Breads = new List<Bread>() {biscuit};
    List<Pastry> Pastrys = new List<Pastry>() {sweetroll};

    Console.WriteLine("Welcome to Haru's Bakery");
    Console.WriteLine("We have a couple of specials today:");
    Console.WriteLine("Buy two Breads get one free!");
    Console.WriteLine("Buy one Pastry for $2, or you can get three for $5!");
    Console.WriteLine("Take a look at our menu");
    foreach (Bread selection in Breads)
    {
      Console.WriteLine(selection.BreadName);
    }
    foreach(Pastry selection in Pastrys)
    {
      Console.WriteLine(selection.PastryName);
    }
    Console.WriteLine("Would you like the biscuit or the sweetroll?");
    string start = Console.ReadLine();
    if(start == "biscuit")
    {
      Console.WriteLine("Thats great! How many would you like to order?");
      biscuit.BreadQuantity = int.Parse(Console.ReadLine());
      biscuit.OrderBread();
    }
    else if(start == "sweetroll")
    {
      Console.WriteLine("Alright! How many would you like to order?");
      sweetroll.PastryQuantity = int.Parse(Console.ReadLine());
      sweetroll.OrderPastry();
    }
  }
}