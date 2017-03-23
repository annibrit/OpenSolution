using System.Linq;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class ChargeLines : Archetypes<ChargeLine>
    {
        public static ChargeLines Instance
        { get; } = new ChargeLines();

        public static ChargeLines GetChargeLines(string uniqueId)
        {
            var r = new ChargeLines();
            var l = Instance.FindAll(x => x.id == uniqueId);
            r.AddRange(l);
            return r;
        }

        public static void RemoveByOrderLineId(string id)
        {
            var aa = Instance.ToList().Find(x => x.id == id);
            if (aa == null)
                return;
            Instance.Remove(aa);
        }
    }
}
