using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.OrderClasses;

namespace Open.Tests.Archetypes.OrderClasses
{

    [TestClass]
    public class OrderLineTests : OrderCommonTests
    {
        private OrderLine m;

        [TestInitialize]
        public void Init()
        {
            m = new OrderLine();
        }

        [TestCleanup]
        public void CleanUp()
        {
            m = null;
            TaxOnLines.Instance.Clear();
            ChargeLines.Instance.Clear();
            DeliveryReceivers.Instance.Clear();
        }

        [TestMethod]
        public void ProductTypeTest()
        {
            StringPropertyTest(() => m.ProductType, x => m.ProductType = x);
        }

        [TestMethod]
        public void ChargeLineIdTest()
        {
            StringPropertyTest(() => m.ChargeLineId, x => m.ChargeLineId = x);
        }

        [TestMethod]
        public void TaxIdTest()
        {
            StringPropertyTest(() => m.TaxId, x => m.TaxId = x);
        }

        [TestMethod]
        public void DeliveryReceiverIdTest()
        {
            StringPropertyTest(() => m.DeliveryReceiverId, x => m.DeliveryReceiverId = x);
        }

        [TestMethod]
        public void SerialNumberTest()
        {
            IntPropertyTest(() => m.SerialNumber, x => m.SerialNumber = x);
        }

        [TestMethod]
        public void NumberOrderedTest()
        {
            IntPropertyTest(() => m.NumberOrdered, x => m.NumberOrdered = x);
        }

        [TestMethod]
        public void UnitPriceTest()
        {
            IntPropertyTest(() => m.UnitPrice, x => m.UnitPrice = x);
        }

        [TestMethod]
        public void AddDeliveryReceiverTest()
        {
            var fakeDeliveryReceiverOne = new DeliveryReceiver();
            var fakeDeliveryReceiverTwo = new DeliveryReceiver();
            m.AddDeliveryReceiver(fakeDeliveryReceiverOne);
            Assert.AreEqual(1, DeliveryReceivers.Instance.Count);
            m.AddDeliveryReceiver(fakeDeliveryReceiverTwo);
            Assert.AreEqual(2, DeliveryReceivers.Instance.Count);
        }

        [TestMethod]
        public void RemoveDeliveryReceiverTest()
        {
            var fakeDeliveryReceiverOne = new DeliveryReceiver();
            fakeDeliveryReceiverOne.receiver = new DeliveryReceiver();
            var fakeDeliveryReceiverTwo = new DeliveryReceiver();
            fakeDeliveryReceiverTwo.receiver = new DeliveryReceiver();
            m.AddDeliveryReceiver(fakeDeliveryReceiverOne);
            m.AddDeliveryReceiver(fakeDeliveryReceiverTwo);
            Assert.AreEqual(2, DeliveryReceivers.Instance.Count);
            m.RemoveDeliveryReceiver(fakeDeliveryReceiverOne.receiver);
            Assert.AreEqual(1, DeliveryReceivers.Instance.Count);
        }

        [TestMethod]
        public void AddTaxTest()
        {
            var fakeTaxOnLineOne = new TaxOnLine();
            var fakeTaxOnLineTwo = new TaxOnLine();
            m.AddTax(fakeTaxOnLineOne);
            Assert.AreEqual(1, TaxOnLines.Instance.Count);
            m.AddTax(fakeTaxOnLineTwo);
            Assert.AreEqual(2, TaxOnLines.Instance.Count);
        }

        [TestMethod]
        public void RemoveTaxOnLineTest()
        {
            var fakeTaxOnLineOne = new TaxOnLine();
            fakeTaxOnLineOne.tax = new TaxOnLine();
            var fakeTaxOnLineTwo = new TaxOnLine();
            fakeTaxOnLineTwo.tax = new TaxOnLine();
            m.AddTax(fakeTaxOnLineOne);
            m.AddTax(fakeTaxOnLineTwo);
            Assert.AreEqual(2, TaxOnLines.Instance.Count);
            m.RemoveTax(fakeTaxOnLineOne.tax);
            Assert.AreEqual(1, TaxOnLines.Instance.Count);
        }

        [TestMethod]
        public void AddChargeLineTest()
        {
            var fakeChargeLineOne = new ChargeLine();
            var fakeChargeLineTwo = new ChargeLine();
            m.AddChargeLine(fakeChargeLineOne);
            Assert.AreEqual(1, ChargeLines.Instance.Count);
            m.AddChargeLine(fakeChargeLineTwo);
            Assert.AreEqual(2, ChargeLines.Instance.Count);
        }

        [TestMethod]
        public void RemoveChargeLineTest()
        {
            var fakeChargeLineOne = new ChargeLine();
            fakeChargeLineOne.id = new OrderLineIdentifier();
            var fakeChargeLineTwo = new ChargeLine();
            fakeChargeLineTwo.id = new OrderLineIdentifier();
            m.AddChargeLine(fakeChargeLineOne);
            m.AddChargeLine(fakeChargeLineTwo);
            Assert.AreEqual(2, ChargeLines.Instance.Count);
            m.RemoveChargeLine(fakeChargeLineOne.id);
            Assert.AreEqual(1, ChargeLines.Instance.Count);
        }
    }
}

