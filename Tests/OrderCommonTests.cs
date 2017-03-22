using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Tests.Archetypes.BaseClasses;

namespace Open.Tests
{
    public class OrderCommonTests : CommonTests
    {

        public double MinDouble = double.MinValue;
        public double MaxDouble = double.MaxValue;

        public void ObjectPropertyTest<T>(Func<T> get, Action<T> set)
            where T : new()
        {
            Assert.IsNotNull(get());
            set(default(T));
            Assert.IsNotNull(get());
            var s = new T();
            set(s);
            Assert.AreEqual(s, get());
        }

        public void StringPropertyTest(Func<string> get, Action<string> set)
        {
            Assert.AreEqual(string.Empty, get());
            set(null);
            Assert.AreEqual(string.Empty, get());
            var s = Rnd.String();
            set(s);
            Assert.AreEqual(s, get());
        }

        public void IntPropertyTest(Func<int> get, Action<int> set)
        {
            Assert.AreEqual(0, get());
            var d = Rnd.Integer();
            set(d);
            Assert.AreEqual(d, get());
        }

    }
}
