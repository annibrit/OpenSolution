using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.OrderClasses;
using Order;

namespace Open.Tests.Archetypes.OrderClasses
{

    [TestClass]
    public partial class MyTests : OrderCommonTests
    {
        private SalesTaxPolicy s;

        [TestInitialize]
        public void Initializer()
        {
            s = new SalesTaxPolicy();
        }

        [TestMethod]
        public void TaxTypeTest()
        {
            StringPropertyTest(() => s.TaxType, x => s.TaxType = x);
        }

        [TestMethod]
        public void RateTest()
        {
            DoublePropertyTest(() => s.Rate, x => s.Rate = x);
        }
    }
}

