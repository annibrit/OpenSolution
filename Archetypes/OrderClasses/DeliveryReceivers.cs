using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class DeliveryReceivers : Archetypes<DeliveryReceiver>
    {
        public static DeliveryReceivers Instance { get; } = new DeliveryReceivers();

        public static DeliveryReceiver Find(string uniqueId)
        {
            return Instance.Find(x => x.IsThisUniqueId(uniqueId));
        }
    }
}