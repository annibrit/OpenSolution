using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.OrderClasses;

namespace Open.Tests.Archetypes.OrderClasses
{
    [TestClass]
    public class TaxOnLineTests : CommonTests<TaxOnLine>
    {
        protected override TaxOnLine GetRandomObj()
        {
            return TaxOnLine.Random();
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
        public void OrderLineIdTest()
        {
            TestProperty(() => Obj.OrderLineId, x => Obj.OrderLineId = x);
        }

        [TestMethod]
        public void IdTest()
        {
            TestProperty(() => Obj.Id, x => Obj.Id = x);
        }

        [TestMethod]
        public void TypeTest()
        {
            TestProperty(() => Obj.Type, x => Obj.Type = x);
        }

        [TestMethod]
        public void RateTest()
        {
            TestProperty(() => Obj.Rate, x => Obj.Rate = x);
        }
    }
}