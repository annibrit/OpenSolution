using Open.Archetypes.BaseClasses;
using Order;

namespace Open.Archetypes.OrderClasses
{
    public class OrderLine : UniqueEntity
    {
        private string producttype;
        private string chargelineid;
        private string taxid;
        private string deliveryreciverid;
        
        public string ProductType
        {
            get { return SetDefault(ref producttype); }
            set { SetValue(ref producttype, value); }
        }

        public  string ChargeLineId
        { 
                get { return SetDefault(ref chargelineid); }
                set { SetValue(ref chargelineid, value); }
        }

        public string TaxId
        {
            get { return SetDefault(ref taxid); }
            set { SetValue(ref taxid, value); }
        }

        public string DeliveryReceiverId
        {
            get { return SetDefault(ref deliveryreciverid); }
            set { SetValue(ref deliveryreciverid, value); }
        }

        public int SerialNumber { get; set; }
        public int NumberOrdered { get; set; }
        public int UnitPrice { get; set; }

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

        public TaxOnLines GetTax()
        {

            return TaxOnLines.GetTaxOnLines(TaxId);
        } 

        public void RemoveTax(TaxOnLine tax)
        {
            TaxOnLines.RemoveByOrderLineTax(tax);
        } 

        public void AddChargeLine(ChargeLine line)
        {
            ChargeLines.Instance.Add(line);
        }

        public ChargeLines GetChargeLine()
        {
           return ChargeLines.GetChargeLines(ChargeLineId);
        } 

        public void RemoveChargeLine(string id)
        {
            ChargeLines.RemoveByOrderLineId(id);
        } 

        public OrderLine Clone()
        {
            return new OrderLine();
        }


        public new static OrderLine Random()
        {
            var x = new OrderLine();
            x.SetRandomValues();
            return x;
        }


        //incrementNumberOrdered - Increments the number of ProductInstance recorded by the OrderLine
        //getNumberOrdered() - Returns the number of ProductInstances recorded by the OrderLine
        //decrementNumberOrdered - Decrements the number of ProductInstances recorded by the OrderLine
    }
}
