using System;
using Open.Aids;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.OrderClasses;

namespace Open.Archetypes.OrderClasses
{
    public class OrderLine : BaseOrderLine
    {
        //TODO kas alati peab privaatsed muutujad väärtustama? (SetRandomValues)
        private int number_ordered;
        private DateTime expected_delivery_date;
        private string product_type_id;
        private string order_line_id;
        private string delivery_receiver_id;

        public string OrderLineId
        {
            get { return SetDefault(ref order_line_id); }
            set { SetValue(ref order_line_id, value); }
        }

        public int NumberOrdered
        {
            get { return SetDefault(ref number_ordered); }
            set { SetValue(ref number_ordered, value); }
        }

        public string ProductTypeId
        {
            get { return SetDefault(ref product_type_id); }
            set { SetValue(ref product_type_id, value); }
        }
        public DateTime ExpectedDeliveryDate
        {
            get { return SetDefault(ref expected_delivery_date); }
            set { SetValue(ref expected_delivery_date, value); }
        }

        public string DeliveryReceiverId
        {
            get { return SetDefault(ref delivery_receiver_id); }
            set { SetValue(ref delivery_receiver_id, value); }
        }


        public TaxOnLine GetTax => OrderLines.GetTaxOnLineByOrderLineId(UniqueId);
        public ChargeLine GetChargeLine => OrderLines.GetChargeLineByOrderLineId(UniqueId);
        public OrderLine Clone => this;

        public void IncrementNumberOrdered(int value)
        {
            number_ordered += value;
        }

        public void DecrementNumberOrdered(int value)
        {
            number_ordered -= value;
        }

        public void AddTax(TaxOnLine tax)
        {
            OrderLines.Instance.Add(tax);
        }

        public void RemoveTax(TaxOnLine tax)
        {
            OrderLines.Instance.Remove(tax);
        }

        public void AddChargeLine(ChargeLine chargeLine)
        {
            if (IsNull(chargeLine)) return;
            chargeLine.OrderLineId = UniqueId;
            chargeLine.OrderId = OrderId;
            OrderLines.Instance.Add(chargeLine);
        }

        public void RemoveChargeLine(ChargeLine chargeLine)
        {
            OrderLines.Instance.Remove(chargeLine);
        }
        //TODO nimekordus - kuidas parandada?
        public static OrderLine Random()
        {
            var o = new OrderLine();
            o.SetRandomValues();
            return o;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            number_ordered = GetRandom.Int32();
            delivery_receiver_id = GetRandom.String();
            expected_delivery_date = GetRandom.DateTime();
            product_type_id = GetRandom.String();
            order_line_id = GetRandom.String();
        }

        public DeliveryReceiver GetDeliveryReceiver => OrderLines.GetDeliveryReceiverByOrderLineId(UniqueId);

        public void AddDeliveryReceiver(DeliveryReceiver deliveryReceiver)
        {

            if (IsNull(deliveryReceiver)) return;
            deliveryReceiver.OrderLineId = UniqueId;
            deliveryReceiver.OrderId = OrderId;
            OrderLines.Instance.Add(deliveryReceiver);
        }

        public void RemoveDeliveryReceiver(DeliveryReceiver receiver)
        {
            OrderLines.Instance.Remove(receiver);
        }
    }
}