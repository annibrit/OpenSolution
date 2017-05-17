using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.OrderClasses;

namespace Open.Tests.Archetypes.OrderClasses
{
    [TestClass]
    public class ChargeLineTests : CommonTests<ChargeLine>
    {
        protected override ChargeLine GetRandomObj()
        {
            return ChargeLine.Random();
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
        public void AmountTest()
        {
            TestProperty(() => Obj.Amount, x => Obj.Amount = x);
        }
        
        [TestMethod]
        public void IdTest()
        {
            TestProperty(() => Obj.UniqueId, x => Obj.UniqueId = x);
        }
        [TestMethod]
        public void OrderLineIdTest()
        {
            TestProperty(() => Obj.OrderLineId, x => Obj.OrderLineId = x);
        }
    }
}