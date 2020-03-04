using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  
  public class Bread
  {
    private string _breadName;
    private int _breadPrice;
    private int _breadQuantity;
    
    public Bread(string breadName, int breadPrice, int breadQuantity)
    {
      _breadName = breadName;
      _breadPrice = breadPrice;
      _breadQuantity = breadQuantity;
    }
    public string GetBreadName()
    {
      return _breadName;
    }
    public int GetBreadPrice()
    {
      return _breadPrice;
    }
    public int GetBreadQuantity()
    {
      return _breadQuantity;
    }
    public void SetBreadname(string newBreadName)
    {
      _breadName = newBreadName;
    }
    public void SetBreadPrice(int newBreadPrice)
    {
      _breadPrice = newBreadPrice;
    }
    public void SetBreadQuantitiy(int newBreadQuantity)
    {
      _breadQuantity = newBreadQuantity;
    }
    public void PurchaseBread(int breadPrice, int breadQuantity)
    {
      if (breadQuantity == 1)
      {
        breadPrice += 5;
      }
      else
      {
        for(int i = 0; i < breadQuantity; i++)
        {
          if (i % 3 == 0)
          {
          breadPrice += 10;
          }
        }
      }
    }
      // public class Bread ends below
  }

  public class Pastry
  {
    private string _pastryName;
    private int _pastryPrice;

    public Pastry(string pastryName, int pastryPrice)
    {
      _pastryName = pastryName;
      _pastryPrice = pastryPrice;
    }
    public string GetPastryName()
    {
      return _pastryName;
    }
    public int GetPastryPrice()
    {
      return _pastryPrice;
    }
    public void SetPastryName(string newPastryName)
    {
      _pastryName = newPastryName;
    }
    public void SetPastryPrice(int newPastryPrice)
    {
      _pastryPrice = newPastryPrice;
    }
    // public class Pastry ends below
  }
  public class Item
  {

   public string Description { get; set;}
   private static List<Item> _instances = new List<Item> {};

    public Item(string description)
    {
      Description = description;
       _instances.Add(this);
    }
    public static List<Item> GetAll()
    {
      return _instances;
    }
  }
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
        default:
          Main();
          break;
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
 
// namespace ends below
}