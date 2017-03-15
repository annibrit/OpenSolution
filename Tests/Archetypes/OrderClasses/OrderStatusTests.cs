using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order;

namespace Tests
{
    [TestClass]
    public class OrderStatusTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreEqual(7, Enum.GetNames(typeof(OrderStatus.Status)).Length);
        }

        [TestMethod]
        public void MakstudTest()
        {
            Assert.AreEqual(0, (int)OrderStatus.Status.Makstud);
        }
        [TestMethod]
        public void LaosTest()
        {
            Assert.AreEqual(1, (int)OrderStatus.Status.Laos);
        }
        [TestMethod]
        public void TellimiselTest()
        {
            Assert.AreEqual(2, (int)OrderStatus.Status.Tellimisel);
        }
        [TestMethod]
        public void KohaletoimetamiselTest()
        {
            Assert.AreEqual(3, (int)OrderStatus.Status.Kohaletoimetamisel);
        }
        [TestMethod]
        public void KohaletoimetatudTest()
        {
            Assert.AreEqual(4, (int)OrderStatus.Status.Kohaletoimetatud);
        }
        [TestMethod]
        public void TühistatudTest()
        {
            Assert.AreEqual(5, (int)OrderStatus.Status.Tühistatud);
        }
        [TestMethod]
        public void TagastatudTest()
        {
            Assert.AreEqual(6, (int)OrderStatus.Status.Tagastatud);
        }
    }
}
