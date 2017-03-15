using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Tests;
using Order;

namespace Tests
{

    [TestClass]
    public class OrderLineIdentifierTests : CommonTests<>
    {
        private OrderLineIdentifier N;

        [TestInitialize]
        public void Int()
        {
            N = new OrderLineIdentifier();
        }

        [TestMethod]
        public void OrderLineIdTest()
        {
            IntPropertyTest(() => N.OrderLineId, x => N.OrderLineId = x);
        }
    }
}

