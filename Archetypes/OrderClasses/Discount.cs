using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class Discount : Archetype
    {
        private string reason;

        public string Reason
        {
            get { return SetDefault(ref reason); }
            set { SetValue(ref reason, value); }
        }
        //CalculateDiscountPrice(price : Price) : Price
    }
}

