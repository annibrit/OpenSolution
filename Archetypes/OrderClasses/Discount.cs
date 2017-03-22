using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Order
{
    public class Discount : Archetype
    {
        public string reason;

        public string Reason
        {
            get { return GetString.EmptyIfNull(reason); }
            set { reason = value; }
        }

        //TODO: teiste atribuutidega samamoodi

        /*private string orderLineIdentifier;

        public string OrderLineIdentifier
        {
            get { return SetDefault(ref orderLineIdentifier); }
            set { SetValue(ref orderLineIdentifier, value); }
        } */
    }
}

