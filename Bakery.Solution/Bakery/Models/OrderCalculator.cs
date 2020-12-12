using System;

namespace Bakery.Models
{
  public class OrderCalculator
  {
    public int TotalCost(int breadCost, int pastryCost)
    {
      return breadCost + pastryCost; 
    }
  }
}