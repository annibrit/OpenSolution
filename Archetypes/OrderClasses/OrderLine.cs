using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Order
{
    public class OrderLine : UniqueEntity
    {
        private string producttype;

        //public string OrderLineId { get; set; } pole vaja
        public string ProductType
        {
            get { return SetDefault(ref producttype); }
            set { SetValue(ref producttype, value); }
        }
        public string DeliveryReceiverId { get; set; }
        public int SerialNumber { get; set; }
        public int NumberOrdered { get; set; }
        public int UnitPrice { get; set; }

        //incrementNumberOrdered - Increments the number of ProductInstance recorded by the OrderLine
        //getNumberOrdered() - Returns the number of ProductInstances recorded by the OrderLine
        //decrementNumberOrdered - Decrements the number of ProductInstances recorded by the OrderLine

        public void AddDeliveryReceiver(DeliveryReceiver reciever)
        {
            DeliveryReceivers.Instance.Add(reciever);
        }

        public DeliveryReceivers GetDeliveryReceiver()
        {
            return DeliveryReceivers.GetDeliveryReceivers(DeliveryReceiverId);
        }


        public void RemoveDeliveryReceiver(DeliveryReceiver receiver)
        {
            DeliveryReceivers.RemoveByOrderLineReceiver(receiver);
        }


        public void AddTax(TaxOnLine tax)
        {
            TaxOnLines.Instance.Add(tax);
        }

        //public TaxOnLines GetTaxes()
        //{
        //    //todo return TaxOnLines.Instances.Select(x=>x.)
        //    return TaxOnLines.Instances;
        //} //Returns all the TaxOnLines for this OrderLine

        public void RemoveTax(TaxOnLine tax)
        {
            TaxOnLines.RemoveByOrderLineTax(tax);
        } //Removes a TaxOnLine from the OrderLine

        public void AddChargeLine(ChargeLine line)
        {
            ChargeLines.Instance.Add(line);
        }

        //public ChargeLines GetChargeLines()
        //{
        //    //todo return ChargeLines.Instances.Select(x=>x.)
        //    return ChargeLines.Instances;
        //} //Returns all the ChargeLines associated with this OrderLine

        public void RemoveChargeLine(string id)
        {
            ChargeLines.RemoveByOrderLineId(id);
        } //Removes a ChargeLine from the OrderLine

        public OrderLine Clone()
        {
            return new OrderLine();
        } //Makes a copy of the OrderLine and any associated objects that can be used to create an amended OrderLine
    }
}
