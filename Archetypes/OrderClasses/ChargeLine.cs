using System;
using Open.Aids;

namespace Open.Archetypes.OrderClasses
{
    public class ChargeLine : BaseOrderLine
    {
        private double amount;
        private string order_line_id;
        private DateTime date_expected;

        public string OrderLineId
        {
            get { return SetDefault(ref order_line_id); }
            set { SetValue(ref order_line_id, value); }
        }

        public double Amount
        {
            get { return SetDefault(ref amount); }
            set { SetValue(ref amount, value); }
        }

        //TODO Kuidas siduda Tax ChargeLine külge ja on seda üldse vaja?
        public TaxOnLine GetTax => OrderLines.GetTaxOnLineByOrderLineId(UniqueId);

        public DateTime ExpectedDeliveryDate
        {
            get { return SetDefault(ref date_expected); }
            set { SetValue(ref date_expected, value); }
        }

        public void AddTax(TaxOnLine tax)
        {
            OrderLines.Instance.Add(tax);
        }

        public void RemoveTax(TaxOnLine tax)
        {
            OrderLines.Instance.Remove(tax);
        }

        public new static ChargeLine Random()
        {
            var x = new ChargeLine();
            x.SetRandomValues();
            return x;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            amount = GetRandom.Double();
            order_line_id = GetRandom.String();
        }
    }
}