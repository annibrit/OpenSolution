using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.OrderClasses;

namespace Open.Logic.OrderClasses
{
    public class ChargeLineDetailsViewModel
    {
        private object p;

        public ChargeLineDetailsViewModel() : this(null) { }
        public ChargeLineDetailsViewModel(ChargeLine chargeline)
        {
            UniqueId = chargeline.UniqueId;
            Amount = chargeline.Amount;
            TaxId = chargeline.TaxId;

            //foreach (var line in orderline.GetOrderLines())
            //{
            //    if (line is TaxOnLine) OrderLines.Add(new OrderLineViewModel((TaxOnLine)line));
            //    if (line is ChargeLine) OrderLines.Add(new OrderLineViewModel((ChargeLine)line));
            //    if (line is OrderLine) OrderLines.Add(new OrderLineViewModel((OrderLine)line));
            //}
        }

        public ChargeLineDetailsViewModel(object p)
        {
            this.p = p;
        }

        public string UniqueId { get; set; }

        public double Amount { get; set; }

        public string TaxId { get; set; }
    
}
}
