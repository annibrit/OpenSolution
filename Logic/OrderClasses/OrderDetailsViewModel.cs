using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Open.Archetypes.OrderClasses;
using Open.Archetypes.BaseClasses;

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
                if (line is TaxOnLine) OrderLines.Add(new OrderLineViewModel((TaxOnLine)line));
                if (line is ChargeLine) OrderLines.Add(new OrderLineViewModel((ChargeLine)line));
                if (line is OrderLine) OrderLines.Add(new OrderLineViewModel((OrderLine)line));
            }
            UniqueId = order.UniqueId;
        }
        public string UniqueId { get; set; }

        public string TermsAndConditions { get; set; }

        public string SalesChannel { get; set; }

        public DateTime DateCreated { get; set; }
        public OrderLinesViewModel OrderLines { get; set; }
    }

    public class OrderLinesViewModel : Archetypes<OrderLineViewModel>
    {
    }

    public class OrderLineViewModel
    {
        public OrderLineViewModel(TaxOnLine line)
        {
            LineType = line.GetType().Name;
            UniqueId = line.UniqueId;
            TaxRate = line.Rate;
            Comment = line.Comment;
        }

        public string Comment { get; set; }

        public double TaxRate { get; set; }

        public OrderLineViewModel(OrderLine line)
        {
            LineType = line.GetType().Name;
            UniqueId = line.UniqueId;
            NumberOrdered = line.NumberOrdered;
            ExpectedDeliveryDate= line.ExpectedDeliveryDate;
        }
        public OrderLineViewModel(ChargeLine line)
        {
            LineType = line.GetType().Name;
            UniqueId = line.UniqueId;
        }

        public DateTime ExpectedDeliveryDate { get; set; }

        public int NumberOrdered { get; set; }
        public string UniqueId { get; set; }

        public string LineType { get; set; }

    }
}

