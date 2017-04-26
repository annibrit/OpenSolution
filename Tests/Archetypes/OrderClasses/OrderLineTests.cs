using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.OrderClasses;

namespace Open.Tests.Archetypes.OrderClasses
{
    [TestClass]
    public class OrderLineTests : CommonTests<OrderLine>
    {
        protected override OrderLine GetRandomObj()
        {
            return OrderLine.Random();
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            //DONE kui te iga testi juures lisate midagi order line instance kollektsiooni siis siin on mõistlik alati OrderLine nullida
            OrderLines.Instance.Clear();
        }

        [TestCleanup]
        public override void TestCleanup()
        {
            base.TestCleanup();
        }

        [TestMethod]
        public void OrderIdTest()
        {
            TestProperty(() => Obj.OrderId, x => Obj.OrderId = x);
        }

        [TestMethod]
        public void NumberOrderedTest()
        {
            TestProperty(() => Obj.NumberOrdered, x => Obj.NumberOrdered = x);
        }

        [TestMethod]
        public void AddTaxTest()
        {
            var fakeTaxOnLineOne = new TaxOnLine();
            var fakeTaxOnLineTwo = new TaxOnLine();
            Obj.AddTax(fakeTaxOnLineOne);
            Assert.AreEqual(1, OrderLines.Instance.Count);
            Obj.AddTax(fakeTaxOnLineTwo);
            Assert.AreEqual(2, OrderLines.Instance.Count);
        }

        [TestMethod]
        public void RemoveTaxOnLineTest()
        {
            var fakeTaxOnLineOne = TaxOnLine.Random();
            var fakeTaxOnLineTwo = TaxOnLine.Random();
            Obj.AddTax(fakeTaxOnLineOne);
            Obj.AddTax(fakeTaxOnLineTwo);
            Assert.AreEqual(2, OrderLines.Instance.Count);
            Obj.RemoveTax(fakeTaxOnLineOne);
            Assert.AreEqual(1, OrderLines.Instance.Count);
        }

        [TestMethod]
        public void AddChargeLineTest()
        {
            var fakeChargeLineOne = new ChargeLine();
            var fakeChargeLineTwo = new ChargeLine();
            Obj.AddChargeLine(fakeChargeLineOne);
            Assert.AreEqual(1, OrderLines.Instance.Count);
            Obj.AddChargeLine(fakeChargeLineTwo);
            Assert.AreEqual(2, OrderLines.Instance.Count);
        }

        [TestMethod]
        public void RemoveChargeLineTest()
        {
            var fakeChargeLineOne = ChargeLine.Random();
            var fakeChargeLineTwo = ChargeLine.Random();
            Obj.AddChargeLine(fakeChargeLineOne);
            Obj.AddChargeLine(fakeChargeLineTwo);
            Assert.AreEqual(2, OrderLines.Instance.Count);
            Obj.RemoveChargeLine(fakeChargeLineOne);
            Assert.AreEqual(1, OrderLines.Instance.Count);
        }
        
        [TestMethod]
        public void DeliveryReceiverIdTest()
        {
            TestProperty(() => Obj.DeliveryReceiverId, x => Obj.DeliveryReceiverId = x);
        }

        [TestMethod]
        public void AddDeliveryReceiverTest()
        {
            //TODO mis on obj? testi loogika on imelik 
            var fakeDeliveryReceiverOne = DeliveryReceiver.Random();
            var fakeDeliveryReceiverTwo = DeliveryReceiver.Random();
            Obj.AddDeliveryReceiver(fakeDeliveryReceiverOne);
            Assert.AreEqual(1, OrderLines.Instance.Count);
            Obj.AddDeliveryReceiver(fakeDeliveryReceiverTwo);
            Assert.AreEqual(2, OrderLines.Instance.Count);
        }

        [TestMethod]
        public void RemoveDeliveryReceiverTest()
        {
            //DONE kasutage ikka random asju testimisel
            var fakeDeliveryReceiverOne = DeliveryReceiver.Random();
            var fakeDeliveryReceiverTwo = DeliveryReceiver.Random();
            Obj.AddDeliveryReceiver(fakeDeliveryReceiverOne);
            Obj.AddDeliveryReceiver(fakeDeliveryReceiverTwo);
            Assert.AreEqual(2, OrderLines.Instance.Count);
            Obj.RemoveDeliveryReceiver(fakeDeliveryReceiverOne);
            Assert.AreEqual(1, OrderLines.Instance.Count);
        }
    }
}