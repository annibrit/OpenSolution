using System;
using Open.Aids;

namespace Open.Archetypes.OrderClasses
{
    public class OrderLine : BaseOrderLine
    {
        //DONE Alati peab privaatsed muutujad väärtustama (SetRandomValues)
        private int number_ordered;
        private string product_type_id;
        private string delivery_receiver_id;
        private DateTime date_expected;

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
            get { return SetDefault(ref date_expected); }
            set { SetValue(ref date_expected, value); }
        }

        public string DeliveryReceiverId
        {
            get { return SetDefault(ref delivery_receiver_id); }
            set { SetValue(ref delivery_receiver_id, value); }
        }

        public TaxOnLine GetTax => OrderLines.GetTaxOnLineByOrderLineId(UniqueId);
        public ChargeLine GetChargeLine => OrderLines.GetChargeLineByOrderLineId(UniqueId);

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


        public void AddDeliveryReceiver(DeliveryReceiver deliveryReceiver)
        {

            if (IsNull(deliveryReceiver)) return;
            delivery_receiver_id = deliveryReceiver.UniqueId;
        }

        public void RemoveDeliveryReceiver()
        {
            delivery_receiver_id = null;
        }

        //TODO Nimekordus - kuidas parandada?
        public new  static OrderLine Random()
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
            product_type_id = GetRandom.String();
        }
    }
}