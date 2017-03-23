using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.OrderClasses;
using Order;

namespace Open.Tests.Archetypes.OrderClasses
{
    [TestClass]
    public class ChargeLineTests : OrderCommonTests
    {
        private ChargeLine m;

        [TestInitialize]
        public void Init()
        {
            m = new ChargeLine();
        }
        [TestMethod]
        public void AmountTest()
        {
            DoublePropertyTest(() => m.Amount, x => m.Amount = x);
        }
        [TestMethod]
        public void CommentTest()
        {
            StringPropertyTest(() => m.Comment, x => m.Comment = x);
        }
        [TestMethod]
        public void DescriptionTest()
        {
            StringPropertyTest(() => m.Description, x => m.Description = x);
        }     
    }
}
