using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order;

namespace Tests
{

    [TestClass]
    public class OrderLineTests : CommonTests
    {
        private OrderLine M;

        [TestInitialize]
        public void Init()
        {
            M = new OrderLine();
        }

        [TestCleanup]
        public void CleanUp()
        {
            M = null;
        }

        [TestMethod]
        public void ProductTypeTest()
        {
            StringPropertyTest(() => M.ProductType, x => M.ProductType = x);
        }

        [TestMethod]
        public void SerialNumberTest()
        {
            IntPropertyTest(() => M.SerialNumber, x => M.SerialNumber = x);
        }

        [TestMethod]
        public void NumberOrderedTest()
        {
            IntPropertyTest(() => M.NumberOrdered, x => M.NumberOrdered = x);
        }

        [TestMethod]
        public void UnitPriceTest()
        {
            IntPropertyTest(() => M.UnitPrice, x => M.UnitPrice = x);
        }

        [TestMethod]
        public void AddDeliveryReceiverTest()
        {
            var fakeDeliveryReceiverOne = new DeliveryReceiver();
            var fakeDeliveryReceiverTwo = new DeliveryReceiver();
            M.AddDeliveryReceiver(fakeDeliveryReceiverOne);
            Assert.AreEqual(1, DeliveryReceivers.Instance.Count);
            M.AddDeliveryReceiver(fakeDeliveryReceiverTwo);
            Assert.AreEqual(2, DeliveryReceivers.Instance.Count);
        }

        [TestMethod]
        public void RemoveDeliveryReceiverTest()
        {
            var fakeDeliveryReceiverOne = new DeliveryReceiver();
            fakeDeliveryReceiverOne.receiver = new DeliveryReceiver();
            var fakeDeliveryReceiverTwo = new DeliveryReceiver();
            fakeDeliveryReceiverTwo.receiver = new DeliveryReceiver();
            M.AddDeliveryReceiver(fakeDeliveryReceiverOne);
            M.AddDeliveryReceiver(fakeDeliveryReceiverTwo);
            Assert.AreEqual(2, DeliveryReceivers.Instance.Count);
            M.RemoveDeliveryReceiver(fakeDeliveryReceiverOne.receiver);
            Assert.AreEqual(1, DeliveryReceivers.Instance.Count);
        }

        [TestMethod]
        public void AddTaxTest()
        {
            var fakeTaxOnLineOne = new TaxOnLine();
            var fakeTaxOnLineTwo = new TaxOnLine();
            M.AddTax(fakeTaxOnLineOne);
            Assert.AreEqual(1, TaxOnLines.Instance.Count);
            M.AddTax(fakeTaxOnLineTwo);
            Assert.AreEqual(2, TaxOnLines.Instance.Count);
        }

        [TestMethod]
        public void RemoveTaxOnLineTest()
        {
            var fakeTaxOnLineOne = new TaxOnLine();
            fakeTaxOnLineOne.tax = new TaxOnLine();
            var fakeTaxOnLineTwo = new TaxOnLine();
            fakeTaxOnLineTwo.tax = new TaxOnLine();
            M.AddTax(fakeTaxOnLineOne);
            M.AddTax(fakeTaxOnLineTwo);
            Assert.AreEqual(2, TaxOnLines.Instance.Count);
            M.RemoveTax(fakeTaxOnLineOne.tax);
            Assert.AreEqual(1, TaxOnLines.Instance.Count);
        }

        [TestMethod]
        public void AddChargeLineTest()
        {
            var fakeChargeLineOne = new ChargeLine();
            var fakeChargeLineTwo = new ChargeLine();
            M.AddChargeLine(fakeChargeLineOne);
            Assert.AreEqual(1, ChargeLines.Instance.Count);
            M.AddChargeLine(fakeChargeLineTwo);
            Assert.AreEqual(2, ChargeLines.Instance.Count);
        }

        [TestMethod]
        public void RemoveChargeLineTest()
        {
            var fakeChargeLineOne = new ChargeLine();
            fakeChargeLineOne.id = new OrderLineIdentifier();
            var fakeChargeLineTwo = new ChargeLine();
            fakeChargeLineTwo.id = new OrderLineIdentifier();
            M.AddChargeLine(fakeChargeLineOne);
            M.AddChargeLine(fakeChargeLineTwo);
            Assert.AreEqual(2, ChargeLines.Instance.Count);
            M.RemoveChargeLine(fakeChargeLineOne.id);
            Assert.AreEqual(1, ChargeLines.Instance.Count);
        }
    }
}

