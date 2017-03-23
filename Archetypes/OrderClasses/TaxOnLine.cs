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
        public string id { get; set; }

        public double Rate { get; set; }

        public string Type
        {
            get { return SetDefault(ref type); }
            set { SetValue(ref type, value); }
        }

        public string Comment
        {
            get { return SetDefault(ref comment); }
            set { SetValue(ref comment, value); }
        }   
    }
}
