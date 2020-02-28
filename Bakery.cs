using System;
using System.Collections.Generic;

namespace Bakery.Models
{

  public class Bread
  {
    private string _breadName;
    private int _breadPrice;

    public Bread(string breadName, int breadPrice)
    {
      _breadName = breadName;
      _breadPrice = breadPrice;
    }
    public string GetBreadName()
    {
      return _breadName;
    }
    public int GetBreadPrice()
    {
      return _breadPrice;
    }
    public void SetBreadname(string newBreadName)
    {
      _breadName = newBreadName;
    }
    public void SetBreadPrice(int newBreadPrice)
    {
      _breadPrice = newBreadPrice;
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

// namespace ends below
}