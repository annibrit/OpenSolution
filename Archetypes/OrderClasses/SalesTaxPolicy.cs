using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Order
{

    public class SalesTaxPolicy : Archetype

    {
        private string taxtype;
        private double rate;

        public string TaxType
        {
            get { return SetDefault(ref taxtype); }
            set { SetValue(ref taxtype, value); }
        }

        public double Rate
        {
            get { return SetDefault(ref rate); }
            set { SetValue(ref rate, value); }
        }
    }
}
