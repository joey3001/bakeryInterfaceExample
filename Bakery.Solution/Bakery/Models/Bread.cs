using System;

namespace Bakery.Models
{
  public class BreadOrder
  {
    public int NumberOfLoafs { get; set; }
    public BreadOrder(int numberOfLoafs)
    {
      NumberOfLoafs = numberOfLoafs; 
    }
  }
}