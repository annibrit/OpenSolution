using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order;

namespace Tests
{

    [TestClass]
    public class DiscountTests : CommonTests
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

