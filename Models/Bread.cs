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
  }
}