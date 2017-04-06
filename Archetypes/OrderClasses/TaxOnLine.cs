using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class TaxOnLine : UniqueEntity
    {
        private string order_line_id;

        public string OrderLineId
        {
            get { return SetDefault(ref order_line_id); }
            set { SetValue(ref order_line_id, value); }
        }

        //private string type;
        //private string comment;

        //public int taxationRate { get; set; }

        ////public TaxOnLine tax { get; set; }

        //public string id { get; set; }

        //public double Rate { get; set; }

        //public string Type
        //{
        //    get { return SetDefault(ref type); }
        //    set { SetValue(ref type, value); }
        //}

        //public string Comment
        //{
        //    get { return SetDefault(ref comment); }
        //    set { SetValue(ref comment, value); }
        //}

        public static TaxOnLine Random()
        {
            var x = new TaxOnLine();
            x.SetRandomValues();
            return x;
        }
    }
}