using System;

namespace Bakery.Models
{
  public class PastryOrder
  {
    public int NumberOfPastries { get; set; }
    public PastryOrder(int numberOfPastries)
    {
      NumberOfPastries = numberOfPastries; 
    }
  }
}