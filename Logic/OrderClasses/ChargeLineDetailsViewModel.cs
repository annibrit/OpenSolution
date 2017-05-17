using Open.Archetypes.OrderClasses;

namespace Open.Logic.OrderClasses
{
    public class ChargeLineDetailsViewModel
    {
        private object p;

        public ChargeLineDetailsViewModel() : this(null) { }
        public ChargeLineDetailsViewModel(ChargeLine chargeline)
        {
            UniqueId = chargeline.UniqueId;
            Amount = chargeline.Amount;
        }

        public ChargeLineDetailsViewModel(object p)
        {
            this.p = p;
        }

        public string UniqueId { get; set; }

        public double Amount { get; set; }

    }
}
