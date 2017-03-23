using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Archetypes.BaseClasses;
namespace Open.Tests.Archetypes.OrderClasses
{

    [TestClass]
    public class OrderTests : ClassTests<Open.Archetypes.OrderClasses.Order>
    {
        [TestMethod]
        public void ConstructorTest()
        {
            var a = new Open.Archetypes.OrderClasses.Order().GetType().BaseType;
            Assert.AreEqual(a, typeof(Archetype));
        }
    }
}