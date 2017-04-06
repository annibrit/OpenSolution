using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class ChargeLines : Archetypes<ChargeLine>
    {
        public static ChargeLines Instance { get; } = new ChargeLines();

        public static ChargeLines GetChargeLinesByOrderLineId(string uniqueId)
        {
            var r = new ChargeLines();
            var l = Instance.FindAll(x => x.OrderLineId == uniqueId);
            r.AddRange(l);
            return r;
        }
    }
}