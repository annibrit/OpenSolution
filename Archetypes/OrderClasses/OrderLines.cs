using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class OrderLines : Archetypes<OrderLine>
    {
        public static OrderLines Instance { get; } = new OrderLines();

        public static OrderLines GetOrderLinesByOrderId(string uniqueId)
        {
            var r = new OrderLines();
            var l = Instance.FindAll(x => x.OrderId == uniqueId);
            r.AddRange(l);
            return r;
        }

        public static OrderLines Random()
        {
            var r = new OrderLines();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(OrderLine.Random());
            return r;
        }
    }
}