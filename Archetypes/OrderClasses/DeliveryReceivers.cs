using Open.Archetypes.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class DeliveryReceivers : Archetypes<DeliveryReceiver>
    {
        public static DeliveryReceivers Instance
        { get; } = new DeliveryReceivers();

        public static DeliveryReceivers GetDeliveryReceivers(string uniqueId)
        {
            var r = new DeliveryReceivers();
            var l = Instance.FindAll(x => x.id == uniqueId);
            r.AddRange(l);
            return r;
        }
        public static void RemoveByOrderLineReceiver(DeliveryReceiver receiver)
        {
            var aa = Instance.ToList().Find(x => x.receiver == receiver);
            if (aa == null)
                return;
            Instance.Remove(aa);
        }
    }
}
