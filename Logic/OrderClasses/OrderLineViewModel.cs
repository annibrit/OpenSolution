using System;
using Open.Archetypes.OrderClasses;

namespace Open.Logic.OrderClasses
{
    public class OrderLineViewModel 
    {
        public OrderLineViewModel(TaxOnLine line)
        {
            LineType = line.GetType().Name;
            UniqueId = line.UniqueId;
            TaxRate = line.Rate;
            Comment = line.Comment;
        }
        public OrderLineViewModel(OrderLine line)
        {
            LineType = line.GetType().Name;
            UniqueId = line.UniqueId;
            NumberOrdered = line.NumberOrdered;
            ExpectedDeliveryDate = line.ExpectedDeliveryDate;
        }
        public OrderLineViewModel(ChargeLine line)
        {
            LineType = line.GetType().Name;
            UniqueId = line.UniqueId;
        }

        public string Comment { get; set; }

        public double TaxRate { get; set; }

        public DateTime ExpectedDeliveryDate { get; set; }

        public int NumberOrdered { get; set; }

        public string UniqueId { get; set; }

        public string LineType { get; set; }

    }
}
