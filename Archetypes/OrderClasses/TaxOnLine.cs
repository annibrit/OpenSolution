using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Order
{
    public class TaxOnLine : Archetype
    {

        private string type;
        private string comment;
        //taxationRate:Real
        public TaxOnLine tax { get; set; }

        public double Rate { get; set; }

        public string Type
        {
            get { return GetString.EmptyIfNull(type); }
            set { type = value; }
        }

        public string Comment
        {
            get { return GetString.EmptyIfNull(comment); }
            set { comment = value; }
        }   
    }
}
