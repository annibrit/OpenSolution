using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.BaseClasses;

namespace Order
{
    public class DeliveryReceiver : Archetype
    {
        public DeliveryReceiver receiver { get; set; }
        public string id { get; set; }
    }
}
