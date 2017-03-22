using Open.Archetypes.BaseClasses;

namespace Order
{
   public class OrderStatus : Archetype
    {
        public enum Status
        {
            Makstud = 0,
            Laos = 1,
            Tellimisel = 2,
            Kohaletoimetamisel = 3,
            Kohaletoimetatud = 4,
            Tühistatud = 5,
            Tagastatud = 6
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
