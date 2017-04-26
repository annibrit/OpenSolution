using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.OrderClasses;

namespace Open.Tests.Archetypes.OrderClasses
{
    [TestClass]
    public class OrderTests : CommonTests<Order>
    {
        protected override Order GetRandomObj()
        {
            return Order.Random();
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            OrderLines.Instance.AddRange(OrderLines.Random());
        }

        [TestCleanup]
        public override void TestCleanup()
        {
            base.TestCleanup();
            OrderLines.Instance.Clear();
        }

        [TestMethod]
        public void ConstructorTest()
        {
            var a = new Order().GetType().BaseType;
            //DONE siin kontrollite, et baastüüp oleks UnigueEntity
            Assert.AreEqual(a, typeof(UniqueEntity));
        }

        [TestMethod]
        public void DateCreatedTest()
        {
            TestProperty(() => Obj.DateCreated, x => Obj.DateCreated = x);
        }

        [TestMethod]
        public void SalesChannelTest()
        {
            TestProperty(() => Obj.SalesChannel, x => Obj.SalesChannel = x);
        }

        [TestMethod]
        public void TermsAndConditionsTest()
        {
            TestProperty(() => Obj.TermsAndConditions, x => Obj.TermsAndConditions = x);
        }

        [TestMethod]
        public void AddOrderLineTest()
        {
            var orderLine = OrderLine.Random();
            var count = OrderLines.Instance.Count;
            Obj.AddOrderLine(orderLine);
            Assert.AreEqual(count + 1, OrderLines.Instance.Count);
            Assert.AreEqual(orderLine, OrderLines.Instance.Find(x => x.IsSameContent(orderLine)));
        }

        [TestMethod]
        public void RemoveOrderLineTest()
        {
            var l = OrderLine.Random();
            Obj.AddOrderLine(l);
            var count = Obj.GetOrderLines().Count;
            Assert.AreEqual(l, OrderLines.Instance.Find(x => x.UniqueId == l.UniqueId));
            Obj.RemoveOrderLine(l);
            Assert.AreEqual(count - 1, Obj.GetOrderLines().Count);
            Assert.IsNull(OrderLines.Instance.Find(x => x.UniqueId == l.UniqueId));
        }

        [TestMethod]
        public void GetOrderLinesTest()
        {
            var orderLine = OrderLine.Random();
            orderLine.OrderId = Obj.UniqueId;
            OrderLines.Instance.Add(orderLine);
            Assert.AreEqual(1, Obj.GetOrderLines().Count);
            Assert.AreEqual(orderLine, Obj.GetOrderLines().Get(0));
        }
    }
}