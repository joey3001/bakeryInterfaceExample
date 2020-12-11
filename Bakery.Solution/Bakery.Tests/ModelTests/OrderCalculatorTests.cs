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
      Assert.AreEqual(typeof(string), newOrderCalculator.GetType());
    }
  }
}