using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.OrderClasses;

namespace Open.Tests.Archetypes.OrderClasses
{

    [TestClass]
    public class TaxOnLineTests : OrderCommonTests
    {
        private TaxOnLine T;

        [TestInitialize]
        public void Initialize()
        {
            T = new TaxOnLine();
        }

        [TestMethod]
        public void CommentTest()
        {
            StringPropertyTest(() => T.Comment, x => T.Comment = x);
        }


        [TestMethod]
        public void TypeTest()
        {
            StringPropertyTest(() => T.Type, x => T.Type = x);
        }
    }
}

