using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
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
    }
}
