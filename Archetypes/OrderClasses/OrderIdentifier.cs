using Open.Aids;

namespace Open.Archetypes.OrderClasses
{
    public class OrderIdentifier : UniqueIdentifier
    {
        private string identifier;

        public string Identifier
        {
            get { return SetDefault(ref identifier); }
            set { SetValue(ref identifier, value); }
        }

        public static OrderIdentifier Random()
        {
            var x = new OrderIdentifier();
            x.SetRandomValues();
            return x;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            identifier = GetRandom.String();
        }
    }
}