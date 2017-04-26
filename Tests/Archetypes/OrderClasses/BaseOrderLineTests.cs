using Open.Archetypes.OrderClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Open.Tests.Archetypes.OrderClasses
{
    [TestClass]
    public class BaseOrderLineTests : CommonTests<BaseOrderLine>
        {
        protected override BaseOrderLine GetRandomObj()
        {
            return BaseOrderLine.Random();
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
        [TestMethod]
        public void DescriptionTest()
        {
            TestProperty(() => Obj.Description, x => Obj.Description = x);
        }
        [TestMethod]
        public void CommentTest()
        {
            TestProperty(() => Obj.Comment, x => Obj.Comment = x);
        }
        [TestMethod]
        public void OrderIdTest()
        {
            TestProperty(() => Obj.OrderId, x => Obj.OrderId = x);
        }
    }
}

