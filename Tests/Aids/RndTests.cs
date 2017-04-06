using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;

namespace Tests.Aids
{
    [TestClass]
    public class RndTests
    {
        [TestMethod]
        public void CharTest()
        {
            var c1 = Rnd.Char();
            var c2 = Rnd.Char();
            for (var i = 0; i < 2; i++)
            {
                if (c1 != c2) break;
                c2 = Rnd.Char();
            }
            Assert.AreNotEqual(c1, c2);
        }

        [TestMethod]
        public void StringTest()
        {
            Assert.AreNotEqual(Rnd.String(), Rnd.String());
        }

        [TestMethod]
        public void DoubleTest()
        {
            Assert.AreNotEqual(Rnd.Double(), Rnd.Double());
            Assert.AreEqual(1, Rnd.Double(1, 1));
        }
    }
}