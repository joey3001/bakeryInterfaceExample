using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void test()
    {
      BreadOrder newBreadOrder = new BreadOrder(5, 1);
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }
  }
}