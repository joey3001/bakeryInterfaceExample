using System;
using Bakery.Models;

public class Program
{
  public static void Main()
  {
    BreadOrder newBreadOrder = new BreadOrder(1); 
    PastryOrder newPastryOrder = new PastryOrder(1);
    OrderCalculator newOrderCalculator = new OrderCalculator();
  }
}

