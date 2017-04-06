using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class ChargeLine : UniqueEntity
    {
        private double amount;
        private string comment;
        private string description;
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

        public string TaxId
        {
            get { return SetDefault(ref taxid); }
            set { SetValue(ref taxid, value); }
        }

        public void AddTax(TaxOnLine tax)
        {
            TaxOnLines.Instance.Add(tax);
        }

        //public TaxOnLines GetTax()
        //{

        //    return TaxOnLines.GetTaxOnLines(TaxId);
        //}

        //public void RemoveTax(TaxOnLine tax)
        //{
        //    TaxOnLines.RemoveByOrderLineTax(tax);
        //}

        public static ChargeLine Random()
        {
            var x = new ChargeLine();
            x.SetRandomValues();
            return x;
        }

        //public override Order Type { get; }
    }
}