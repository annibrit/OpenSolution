using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order;

namespace Tests
{

    [TestClass]
    public partial class MyTests : CommonTests
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
    }
}

