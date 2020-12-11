using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void BreadOrder_CreateInstanceOfBreadOrder_BreadOrder()
    {
      BreadOrder newBreadOrder = new BreadOrder(2);
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }

    [TestMethod]
    public void BreadOrder_ProvideInputForNumberOfLoafs_2()
    {
      BreadOrder newBreadOrder = new BreadOrder(2);
      Assert.AreEqual(2, newBreadOrder.NumberOfLoafs);
    }

    [TestMethod]
    public void BreadOrder_SetCostPerLoafTo5_5()
    {
      BreadOrder newBreadOrder = new BreadOrder(2);
      Assert.AreEqual(5, newBreadOrder.CostPerLoaf);
    }

    [TestMethod]
    public void OrderCost_CalculateBreadOrderCostForEvenAmountOfLoafs_10()
    {
      BreadOrder newBreadOrder = new BreadOrder(4);
      Assert.AreEqual(10, newBreadOrder.OrderCost());
    }

    [TestMethod]
    public void OrderCost_CalculateBreadOrderCostForOddAmountOfLoafs_10()
    {
      BreadOrder newBreadOrder = new BreadOrder(5);
      Assert.AreEqual(0, newBreadOrder.OrderCost());
    }
  }
}