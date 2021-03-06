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
    public void TotalCost_AddTwoNumbersTogether_30()
    {
      OrderCalculator newOrderCalculator = new OrderCalculator();
      Assert.AreEqual(30, newOrderCalculator.TotalCost(14, 16));
    }
  }
}