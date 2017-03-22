using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order;

namespace Open.Tests.Archetypes.OrderClasses
{
    [TestClass]
    public class ChargeLineTests : OrderCommonTests
    {
        private ChargeLine M;

        [TestInitialize]
        public void Init()
        {
            M = new ChargeLine();
        }
        [TestMethod]
        public void AmountTest()
        {
            DoublePropertyTest(() => M.Amount, x => M.Amount = x);
        }
        [TestMethod]
        public void CommentTest()
        {
            StringPropertyTest(() => M.Comment, x => M.Comment = x);
        }
        [TestMethod]
        public void DescriptionTest()
        {
            StringPropertyTest(() => M.Description, x => M.Description = x);
        }     
    }
}
