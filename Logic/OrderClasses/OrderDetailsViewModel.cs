using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Open.Archetypes.OrderClasses;
using Open.Archetypes.BaseClasses;
using Open.Logic.OrderLineClasses;

namespace Open.Logic.OrderClasses
{
    public class OrderDetailsViewModel
    {
        public OrderDetailsViewModel(): this(null) {}
        public OrderDetailsViewModel(Order order)
        {
            DateCreated = order.DateCreated; 
            SalesChannel = order.SalesChannel;
            TermsAndConditions= order.TermsAndConditions;
            OrderLines = new OrderLinesViewModel();

            foreach (var line in order.GetOrderLines())
            {
                if (line is TaxOnLine) OrderLines.Add(new LineViewModel((TaxOnLine)line));
                if (line is ChargeLine) OrderLines.Add(new LineViewModel((ChargeLine)line));
                if (line is OrderLine) OrderLines.Add(new LineViewModel((OrderLine)line));
            }
            UniqueId = order.UniqueId;
        }
        public string UniqueId { get; set; }

        public string TermsAndConditions { get; set; }

        public string SalesChannel { get; set; }

        public DateTime DateCreated { get; set; }

        public OrderLinesViewModel OrderLines { get; set; }
    }

}


