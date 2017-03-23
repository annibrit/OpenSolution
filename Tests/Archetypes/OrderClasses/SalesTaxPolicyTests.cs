using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Tests;
using Order;

namespace Tests
{

    [TestClass]
    public partial class MyTests : OrderCommonTests
    {
        private SalesTaxPolicy S;

        [TestInitialize]
        public void Initializer()
        {
            S = new SalesTaxPolicy();
        }

        [TestMethod]
        public void TaxTypeTest()
        {
            StringPropertyTest(() => S.TaxType, x => S.TaxType = x);
        }

        [TestMethod]
        public void RateTest()
        {
            DoublePropertyTest(() => S.Rate, x => S.Rate = x);
        }
    }
}

