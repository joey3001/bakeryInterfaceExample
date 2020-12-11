using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryOrder_CreateInstanceOfPastryOrder_PastryOrder()
    {
      PastryOrder newPastryOrder = new PastryOrder();
      Assert.AreEqual(typeof(PastryOrder), newPastryOrder.GetType());
    }

    [TestMethod]
    public void PastryOrder_ProvideInputForNumberOfPastries_2()
    {
      PastryOrder newPastryOrder = new PastryOrder(2);
      Assert.AreEqual(1, newPastryOrder.NumberOfPastries);
    }
  }
}