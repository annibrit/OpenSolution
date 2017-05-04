using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class Orders : Archetypes<Order>
    {
        public static Orders Instance { get; } = new Orders();

        public static Orders Random()
        {
            var r = new Orders();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(Order.Random());
            return r;
        }
    }
}