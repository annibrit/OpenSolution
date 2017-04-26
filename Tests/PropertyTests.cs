using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Tests
{
    public class PropertyTests : Serializable
    {
        protected void TestProperty(Func<string> get, Action<string> set)
        {
            var s = GetRandom.String();
            Assert.AreNotEqual(s, get());
            set(s);
            Assert.AreEqual(s, get());
            set(null);
            Assert.AreEqual(s, get());
        }

        protected void TestProperty<T>(Func<T> get, Action<T> set) where T : new()
        {
            Assert.IsNotNull(get());
            Assert.IsInstanceOfType(get(), typeof(T));
            var a1 = get();
            var a2 = new T();
            set(a2);
            Assert.AreEqual(a2, get());
            Assert.AreNotEqual(a1, get());
            set(default(T));
            Assert.IsNotNull(get());
        }
         public void TestProperty(Func<DateTime> get, Action<DateTime> set)
        {
            var s = GetRandom.DateTime();
            Assert.AreNotEqual(s, get());
            set(s);
            Assert.AreEqual(s, get());
        }
        public void TestProperty(Func<bool> get, Action<bool> set)
        {
            var b = !get();
            Assert.AreNotEqual(b, get());
            set(b);
            Assert.AreEqual(b, get());
        }
        
        public void TestProperty(Func<double> get, Action<double> set)
        {
            var s = GetRandom.Double();
            Assert.AreNotEqual(s, get());
            set(s);
            Assert.AreEqual(s, get());
        }

        
        public void TestProperty(Func<decimal> get, Action<decimal> set)
        {
            var s = GetRandom.Decimal();
            Assert.AreNotEqual(s, get());
            set(s);
            Assert.AreEqual(s, get());
        }

        
        public void TestProperty(Func<int> get, Action<int> set)
        {
            var s = GetRandom.Int32();
            Assert.AreNotEqual(s, get());
            set(s);
            Assert.AreEqual(s, get());
        }

        public void TestProperty(Func<uint> get, Action<uint> set)
        {
            var s = GetRandom.UInt32();
            Assert.AreNotEqual(s, get());
            set(s);
            Assert.AreEqual(s, get());
        }

        public void TestEnumProperty<T>(Func<T> get, Action<T> set)
        {
            Assert.IsTrue(typeof(T).IsEnum);
            var i = GetEnum.Value<T>(0);
            Assert.AreEqual(i, get());
            var s = GetRandom.Enum<T>();
            set(s);
            Assert.AreEqual(s, get());
        }

        protected void TestSingleton<T>(Func<T> get)
        {
            var s = get();
            Assert.IsNotNull(s);
            Assert.AreEqual(s, get());
        }
    }
}