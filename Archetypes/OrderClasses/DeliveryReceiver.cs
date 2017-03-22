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

        //TODO: teiste atribuutidega samamoodi

        /*private string orderLineIdentifier;

        public string OrderLineIdentifier
        {
            get { return SetDefault(ref orderLineIdentifier); }
            set { SetValue(ref orderLineIdentifier, value); }
        } */
    }
}
