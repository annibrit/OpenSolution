using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.OrderClasses;

namespace Open.Tests.Archetypes.OrderClasses
{

    [TestClass]
    public class DiscountTests : OrderCommonTests
    {
        private Discount m;

        [TestInitialize]
        public void Init()
        {
            m = new Discount();
        }

        [TestMethod]
        public void ReasonTest()
        {
            StringPropertyTest(() => m.Reason, x => m.Reason = x);
        }
    }
}

