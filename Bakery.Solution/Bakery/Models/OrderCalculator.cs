using System;

namespace Bakery.Models
{
  public class OrderCalculator
  { 
    public int TotalCost(IOrder[] Orders)
    {
      int result = 0;
      for (int i = 0; i < Orders.Length; i++)
      {
        result = result + Orders[i].OrderCost();
      }
      return result;
    }
  }
}

