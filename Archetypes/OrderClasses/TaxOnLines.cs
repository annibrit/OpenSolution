using System.Linq;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class TaxOnLines : Archetypes<TaxOnLine>
    {
        public static TaxOnLines Instance
        { get; } = new TaxOnLines();
       
    public static TaxOnLines GetTaxOnLines(string uniqueId)
        {
            var r = new TaxOnLines();
            var l = Instance.FindAll(x => x.id == uniqueId);
            r.AddRange(l);
            return r;
        }

        public static void RemoveByOrderLineTax(TaxOnLine tax)
        {
            var aa = Instance.ToList().Find(x => x.tax == tax);
            if (aa == null)
                return;
            Instance.Remove(aa);
        }
    }
}
