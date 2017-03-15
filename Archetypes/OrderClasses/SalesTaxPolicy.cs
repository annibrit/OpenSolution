using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Order
{

    public class SalesTaxPolicy : Archetype

    {
        private string taxtype;

        public string TaxType
        {
            get { return GetString.EmptyIfNull(taxtype); }
            set { taxtype = value; }
        }

        public double Rate
        {
            get;
            set;
        }
    }
}
