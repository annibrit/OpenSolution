using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.OrderClasses;

namespace Open.Tests.Archetypes.OrderClasses
{
    [TestClass]
    public class OrderStatusTests : ClassTests<OrderStatus>
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreEqual(4, Enum.GetNames(typeof(OrderStatus)).Length);
        }

        [TestMethod]
        public void InitializingTest()
        {
            Assert.AreEqual(0, (int) OrderStatus.Initializing);
        }
    }
}