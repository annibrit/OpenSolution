using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.OrderClasses;

namespace Open.Logic.OrderClasses
{
    public class TaxOnLineDetailsViewModel
    {
        private object p;

        public TaxOnLineDetailsViewModel() : this(null) { }
        public TaxOnLineDetailsViewModel(TaxOnLine taxonline)
        {
            Id = taxonline.Id;
            Type = taxonline.Type;
            Rate = taxonline.Rate;
        }

        public TaxOnLineDetailsViewModel(object p)
        {
            this.p = p;
        }

        public string Id { get; set; }

        public string Type { get; set; }

        public double Rate { get; set; }

    }
}
