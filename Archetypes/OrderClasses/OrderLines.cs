using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class OrderLines : Archetypes<BaseOrderLine>
    {
        public static OrderLines Instance { get; } = new OrderLines();

        public static OrderLines Random()
        {
            var r = new OrderLines();
            var c = GetRandom.Count();
            for (var i = 0; i < c; i++) r.Add(BaseOrderLine.Random());
            return r;
        }

        public static OrderLines GetOrderLinesByOrderId(string uniqueId)
        {
            var r = new OrderLines();
            var l = Instance.FindAll(x => x.OrderId == uniqueId);
            r.AddRange(l);
            return r;
        }      

        public static OrderLines GetTaxOnLinesByOrderId(string id) {
            var o = new OrderLines();
            var l = Instance.FindAll(x=>(x is TaxOnLine) && x.OrderId == id);
            o.AddRange(l);
            return o;
        }

        public static TaxOnLine GetTaxOnLineByOrderLineId(string id)
        {
            var l = Instance.Find(x => x is TaxOnLine && ((TaxOnLine) x).OrderLineId == id);
            return l as TaxOnLine;
        }

        public static ChargeLine GetChargeLineByOrderLineId(string id) {
            var l = Instance.Find(x => x is ChargeLine && ((ChargeLine)x).OrderLineId == id);
            return l as ChargeLine;
        }

    }
}