using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class ChargeLine : BaseOrderLine
    {
        private double amount;
        private string id;
        private string order_line_id;
        private string taxid;

        public string OrderLineId
        {
            get { return SetDefault(ref order_line_id); }
            set { SetValue(ref order_line_id, value); }
        }

        public string Id
        {
            get { return SetDefault(ref id); }
            set { SetValue(ref id, value); }
        }

        public double Amount
        {
            get { return SetDefault(ref amount); }
            set { SetValue(ref amount, value); }
        }

        public string TaxId
        {
            get { return SetDefault(ref taxid); }
            set { SetValue(ref taxid, value); }
        }
        //TODO kuidas siduda Tax ChargeLine külge ja on seda üldse vaja?
        public TaxOnLine GetTax => OrderLines.GetTaxOnLineByOrderLineId(UniqueId);

        public void AddTax(TaxOnLine tax)
        {
            OrderLines.Instance.Add(tax);
        }

        public void RemoveTax(TaxOnLine tax)
        {
            OrderLines.Instance.Remove(tax);
        }

        public static ChargeLine Random()
        {
            var x = new ChargeLine();
            x.SetRandomValues();
            return x;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            amount = GetRandom.Double();
            id = GetRandom.String();
            order_line_id = GetRandom.String();
            taxid = GetRandom.String();
        }
    }
}