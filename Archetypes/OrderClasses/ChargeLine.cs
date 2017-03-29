using Open.Archetypes.BaseClasses;
using Open.Archetypes.OrderClasses;

namespace Open.Archetypes.OrderClasses
{
    public class ChargeLine : UniqueEntity
    {
        
        private double amount;
        private string description;
        private string comment;
        private string taxid;
        public string id;

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

        public TaxOnLines GetTax()
        {

            return TaxOnLines.GetTaxOnLines(TaxId);
        }

        public void RemoveTax(TaxOnLine tax)
        {
            TaxOnLines.RemoveByOrderLineTax(tax);
        }

        public new static ChargeLine Random()
        {
            var x = new ChargeLine();
            x.SetRandomValues();
            return x;
        }
    }

    
}
