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

        //[TestMethod]
        //public void ChargeLineIdTest() {
        //    TestProperty(() => Obj.ChargeLineId, x => Obj.ChargeLineId = x);
        //}

        //[TestMethod]
        //public void TaxIdTest() {
        //    TestProperty(() => Obj.TaxId, x => Obj.TaxId = x);
        //}

        //[TestMethod]
        //public void DeliveryReceiverIdTest() {
        //    TestProperty(() => Obj.DeliveryReceiverId, x => Obj.DeliveryReceiverId = x);
        //}

        //[TestMethod]
        //public void SerialNumberTest() {
        //    TestProperty(() => Obj.SerialNumber, x => Obj.SerialNumber = x);
        //}

        //[TestMethod]
        //public void NumberOrderedTest() {
        //    TestProperty(() => Obj.NumberOrdered, x => Obj.NumberOrdered = x);
        //}

        //[TestMethod]
        //public void UnitPriceTest() {
        //    TestProperty(() => Obj.UnitPrice, x => Obj.UnitPrice = x);
        //}

        [TestMethod]
        public void AddDeliveryReceiverTest()
        {
            var fakeDeliveryReceiverOne = new DeliveryReceiver();
            var fakeDeliveryReceiverTwo = new DeliveryReceiver();
            Obj.AddDeliveryReceiver(fakeDeliveryReceiverOne);
            Assert.AreEqual(1, DeliveryReceivers.Instance.Count);
            Obj.AddDeliveryReceiver(fakeDeliveryReceiverTwo);
            Assert.AreEqual(2, DeliveryReceivers.Instance.Count);
        }

        //[TestMethod]
        //public void RemoveDeliveryReceiverTest() {
        //    var fakeDeliveryReceiverOne = new DeliveryReceiver();
        //    fakeDeliveryReceiverOne.receiver = new DeliveryReceiver();
        //    var fakeDeliveryReceiverTwo = new DeliveryReceiver();
        //    fakeDeliveryReceiverTwo.receiver = new DeliveryReceiver();
        //    Obj.AddDeliveryReceiver(fakeDeliveryReceiverOne);
        //    Obj.AddDeliveryReceiver(fakeDeliveryReceiverTwo);
        //    Assert.AreEqual(2, DeliveryReceivers.Instance.Count);
        //    Obj.RemoveDeliveryReceiver(fakeDeliveryReceiverOne.receiver);
        //    Assert.AreEqual(1, DeliveryReceivers.Instance.Count);
        //}

        [TestMethod]
        public void AddTaxTest()
        {
            var fakeTaxOnLineOne = new TaxOnLine();
            var fakeTaxOnLineTwo = new TaxOnLine();
            Obj.AddTax(fakeTaxOnLineOne);
            Assert.AreEqual(1, TaxOnLines.Instance.Count);
            Obj.AddTax(fakeTaxOnLineTwo);
            Assert.AreEqual(2, TaxOnLines.Instance.Count);
        }

        //[TestMethod]
        //public void RemoveTaxOnLineTest()
        //{
        //    var fakeTaxOnLineOne = new TaxOnLine();
        //    fakeTaxOnLineOne.tax = new TaxOnLine();
        //    var fakeTaxOnLineTwo = new TaxOnLine();
        //    fakeTaxOnLineTwo.tax = new TaxOnLine();
        //    Obj.AddTax(fakeTaxOnLineOne);
        //    Obj.AddTax(fakeTaxOnLineTwo);
        //    Assert.AreEqual(2, TaxOnLines.Instance.Count);
        //    Obj.RemoveTax(fakeTaxOnLineOne.tax);
        //    Assert.AreEqual(1, TaxOnLines.Instance.Count);
        //}

        [TestMethod]
        public void AddChargeLineTest()
        {
            var fakeChargeLineOne = new ChargeLine();
            var fakeChargeLineTwo = new ChargeLine();
            Obj.AddChargeLine(fakeChargeLineOne);
            Assert.AreEqual(1, ChargeLines.Instance.Count);
            Obj.AddChargeLine(fakeChargeLineTwo);
            Assert.AreEqual(2, ChargeLines.Instance.Count);
        }


        /*
        [TestMethod]
        public void RemoveChargeLineTest()
        {
            var fakeChargeLineOne = new ChargeLine();
            fakeChargeLineOne.id = new OrderLineIdentifier();
            var fakeChargeLineTwo = new ChargeLine();
            fakeChargeLineTwo.id = new OrderLineIdentifier();
            Obj.AddChargeLine(fakeChargeLineOne);
            Obj.AddChargeLine(fakeChargeLineTwo);
            Assert.AreEqual(2, ChargeLines.Instance.Count);
            Obj.RemoveChargeLine(fakeChargeLineOne.id);
            Assert.AreEqual(1, ChargeLines.Instance.Count);
        }
        */
    }
}