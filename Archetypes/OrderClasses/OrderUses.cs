using Open.Archetypes.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Aids;

namespace Open.Archetypes.OrderClasses
{
    public class OrderUses : Strings
    {
        public new static OrderUses Random()
        {
            var r = new OrderUses();
            var c = GetRandom.Count(1, 2);
            for (var i = 0; i < c; i++)
                r.Add(GetRandom.String(5, 7));
            return r;
        }
    }

}
