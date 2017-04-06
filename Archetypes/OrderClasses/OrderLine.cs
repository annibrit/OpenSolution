using System;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class OrderLine : UniqueEntity
    {
        private string comment;
        private string delivery_receiver_id;
        private string description;
        private DateTime expected_delivery_date;
        private int number_ordered;
        private string order_id;
        private string product_type_id;

        public string OrderId
        {
            get { return SetDefault(ref order_id); }
            set { SetValue(ref order_id, value); }
        }

        public string DeliveryReceiverId
        {
            get { return SetDefault(ref delivery_receiver_id); }
            set { SetValue(ref delivery_receiver_id, value); }
        }

        public string ProductTypeId
        {
            get { return SetDefault(ref product_type_id); }
            set { SetValue(ref product_type_id, value); }
        }

        public string Description
        {
            get { return SetDefault(ref description); }
            set { SetValue(ref description, value); }
        }

        public string Comment
        {
            get { return SetDefault(ref comment); }
            set { SetValue(ref comment, value); }
        }

        public int NumberOrdered
        {
            get { return SetDefault(ref number_ordered); }
            set { SetValue(ref number_ordered, value); }
        }

        public DateTime ExpectedDeliveryDate
        {
            get { return SetDefault(ref expected_delivery_date); }
            set { SetValue(ref expected_delivery_date, value); }
        }

        public DeliveryReceiver GetDeliveryReceiver => DeliveryReceivers.Find(DeliveryReceiverId);
        public TaxOnLines GetTaxes => TaxOnLines.GetTaxOnLinesByOrderLineId(UniqueId);
        public ChargeLines GetChargeLine => ChargeLines.GetChargeLinesByOrderLineId(UniqueId);
        public OrderLine Clone => this;

        public void IncrementNumberOrdered(int value)
        {
            number_ordered += value;
        }

        public void DecrementNumberOrdered(int value)
        {
            number_ordered -= value;
        }

        public void AddDeliveryReceiver(DeliveryReceiver reciever)
        {
            DeliveryReceivers.Instance.Add(reciever);
        }

        public void RemoveDeliveryReceiver(DeliveryReceiver receiver)
        {
            DeliveryReceivers.Instance.Remove(receiver);
        }

        public void AddTax(TaxOnLine tax)
        {
            TaxOnLines.Instance.Add(tax);
        }

        public void RemoveTax(TaxOnLine tax)
        {
            TaxOnLines.Instance.Remove(tax);
        }

        public void AddChargeLine(ChargeLine chargeLine)
        {
            ChargeLines.Instance.Add(chargeLine);
        }

        public void RemoveChargeLine(ChargeLine chargeLine)
        {
            ChargeLines.Instance.Remove(chargeLine);
        }

        public static OrderLine Random()
        {
            var x = new OrderLine();
            x.SetRandomValues();
            return x;
        }

        //public Money UnitPrice { get; set; }

        //public SerialNumber SerialNumber { get; set; }
    }
}