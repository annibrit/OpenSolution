using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.RuleClasses
{
    public abstract class RuleElement : Archetype
    {
        private string name;

        protected RuleElement() : this(string.Empty)
        {
        }

        protected RuleElement(string name)
        {
            this.name = name;
        }

        public virtual string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }

        public virtual bool IsOperand()
        {
            return false;
        }

        public virtual bool IsOperator()
        {
            return false;
        }

        public virtual bool IsVariable()
        {
            return false;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            name = GetRandom.String();
        }

        public static RuleElement Random()
        {
            var i = GetRandom.Int32() % 8;
            switch (i)
            {
                case 1:
                    return Operator.Random();
                case 2:
                    return BooleanVariable.Random();
                case 3:
                    return IntegerVariable.Random();
                case 4:
                    return DoubleVariable.Random();
                case 5:
                    return DecimalVariable.Random();
                case 6:
                    return DateTimeVariable.Random();
                case 7:
                    return StringVariable.Random();
                default:
                    return Operand.Random();
            }
        }
    }
}