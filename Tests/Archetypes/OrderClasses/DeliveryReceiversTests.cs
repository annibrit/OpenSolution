using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.OrderClasses;

namespace Open.Tests.Archetypes.OrderClasses
{

    [TestClass]
    public class DeliveryReceiversTests : CommonTests<DeliveryReceiver>
    {
        protected override DeliveryReceiver GetRandomObj()
        {
            return DeliveryReceiver.Random();
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
    }
}
