using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.BaseClasses;

namespace Order
{
    public class TaxOnLines : Archetypes<TaxOnLine>
    {
        public static TaxOnLines Instance
        { get; } = new TaxOnLines();

        public static void RemoveByOrderLineTax(TaxOnLine tax)
        {
            var aa = Instance.ToList().Find(x => x.tax == tax);
            if (aa == null)
                return;
            Instance.Remove(aa);
        }
    }
}
