using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class SalesTaxPolicy : Archetype

    {
        private double rate;
        private string taxtype;

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

        public static SalesTaxPolicy Random()
        {
            var x = new SalesTaxPolicy();
            x.SetRandomValues();
            return x;
        }
    }
}