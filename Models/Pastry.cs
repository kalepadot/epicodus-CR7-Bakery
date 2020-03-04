using System;
using System.Collections.Generic;

namespace Bakery.Models
{
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
}