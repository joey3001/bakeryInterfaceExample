using System;

namespace Bakery.Models
{
  public class OrderCalculator
  {
    public int BreadCalculator(int numberOfLoafs, int costPerLoaf)
    {
    if (numberOfLoafs % 2 == 0)
      { 
        return numberOfLoafs/2 * costPerLoaf;
      }
      return 1;
    } 
  }
}