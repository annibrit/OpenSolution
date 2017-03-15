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
    }
}

