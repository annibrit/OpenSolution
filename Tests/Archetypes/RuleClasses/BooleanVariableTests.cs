﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Archetypes.RuleClasses;

namespace Open.Tests.Archetypes.RuleClasses
{
    [TestClass]
    public class BooleanVariableTests : CommonTests<BooleanVariable>
    {
        protected override BooleanVariable GetRandomObj()
        {
            return BooleanVariable.Random();
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreEqual(Obj.GetType().BaseType, typeof(Variable<bool>));
        }

        [TestMethod]
        public override void IsEqualTest()
        {
            var s = !Obj.Value;
            Assert.IsFalse(Obj.IsEqual(s));
            Assert.IsTrue(Obj.IsEqual(Obj.Value));
        }

        [TestMethod]
        public void IsNotEqualTest()
        {
            var s = !Obj.Value;
            Assert.IsTrue(Obj.IsNotEqual(s));
            Assert.IsFalse(Obj.IsNotEqual(Obj.Value));
        }

        [TestMethod]
        public void IsGreaterTest()
        {
            Obj = new BooleanVariable {Name = GetRandom.String(), Value = true};
            Assert.IsTrue(Obj.IsGreater(false));
            Assert.IsFalse(Obj.IsGreater(Obj.Value));
        }

        [TestMethod]
        public void IsNotGreaterTest()
        {
            Obj = new BooleanVariable {Name = GetRandom.String(), Value = true};
            Assert.IsFalse(Obj.IsNotGreater(false));
            Assert.IsTrue(Obj.IsNotGreater(Obj.Value));
        }

        [TestMethod]
        public void IsLessTest()
        {
            Obj = new BooleanVariable {Name = GetRandom.String(), Value = false};
            Assert.IsTrue(Obj.IsLess(true));
            Assert.IsFalse(Obj.IsLess(Obj.Value));
        }

        [TestMethod]
        public void IsNotLessTest()
        {
            Obj = new BooleanVariable {Name = GetRandom.String(), Value = false};
            Assert.IsFalse(Obj.IsNotLess(true));
            Assert.IsTrue(Obj.IsNotLess(Obj.Value));
        }

        [TestMethod]
        public void ConvertTest()
        {
            var s = GetRandom.Bool();
            Assert.AreEqual(s, Obj.Convert(s.ToString()));
        }

        [TestMethod]
        public void ValueTest()
        {
            Obj = new BooleanVariable();
            TestProperty(() => Obj.Value, x => Obj.Value = x);
        }

        [TestMethod]
        public void IsEmptyTest()
        {
            Assert.IsTrue(BooleanVariable.Empty.IsEmpty());
            Assert.IsFalse(BooleanVariable.Random().IsEmpty());
            Assert.IsFalse(new BooleanVariable().IsEmpty());
        }

        [TestMethod]
        public void EmptyTest()
        {
            TestSingleton(() => BooleanVariable.Empty);
        }
    }
}