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
    public int GetBreadName()
    {
      return _breadName;
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
    // public class Pastry ends below
  }
// namespace ends below
}