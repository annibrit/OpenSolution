using Order;

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
    }
}
