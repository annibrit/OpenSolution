using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Order
{

    public class SalesTaxPolicy : Archetype

    {

        //TODO: teiste atribuutidega samamoodi

        /*private string orderLineIdentifier;

        public string OrderLineIdentifier
        {
            get { return SetDefault(ref orderLineIdentifier); }
            set { SetValue(ref orderLineIdentifier, value); }
        } */

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
