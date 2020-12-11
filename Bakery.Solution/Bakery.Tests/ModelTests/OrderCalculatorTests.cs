using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderCalculatorTests
  {
    [TestMethod]
    public void OrderCalculator_CreateInstanceOfOrderCalculator_OrderCalculator()
    {
      OrderCalculator newOrderCalculator = new OrderCalculator();
      Assert.AreEqual(typeof(OrderCalculator), newOrderCalculator.GetType());
    }
    [TestMethod]
    public void BreadCalculator_CalculateCostOfBreadOrderForEvenAmountOfLoafs_10()
    {
      OrderCalculator newOrderCalculator = new OrderCalculator();
      BreadOrder newBreadOrder = new BreadOrder(4);
      Assert.AreEqual(1, newOrderCalculator.BreadCalculator());
    }
  }
}