 
using System;
using System.Collections.Generic;
 
 namespace Bakery.Models
 {
  public class ShoppingCart
  {
    public static List<Item> newList = new List<Item> {};
    
    public static void Cart()
    {
      Console.WriteLine("Welcome to your Shopping Cart! Would you like to \n[1] View Cart? Or \n[2] Buy more treats?");
      string cartResponse = Console.ReadLine();
      switch(cartResponse)
      {
        case "1":
          ViewList();
          break;
        case "2":
          AddItems();
          break;
        // default:
        //   Bakery.Main();
        //   break;
      }
      // public static void cart ends below
    } 
    
    public static void ViewList()
    {
      for (int i = 0; i < newList.Count; i++)
      {
        Console.WriteLine((i+1) + ". " + newList[i].Description);
      }
      Cart();
    }

    public static void AddItems()
    {
      Console.WriteLine("Please enter the items you would like to add to your cart!");
      string description = Console.ReadLine();
      Item newItem = new Item(description);
      newList.Add(newItem);
      Cart();
    }
    // public class Shoppingcart ends below
  }
 }