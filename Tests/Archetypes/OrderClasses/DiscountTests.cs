using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Tests;
using Open.Tests.Archetypes.BaseClasses;
using Order;

namespace Tests
{

    [TestClass]
    public class DiscountTests : OrderCommonTests
    {
        private Discount M;

        [TestInitialize]
        public void Init()
        {
            M = new Discount();
        }

        [TestMethod]
        public void ReasonTest()
        {
            StringPropertyTest(() => M.Reason, x => M.Reason = x);
        }
    }
}

