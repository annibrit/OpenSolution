using System;
using System.ComponentModel.DataAnnotations;
using Open.Archetypes.OrderClasses;

namespace Open.Logic.OrderClasses
{
    public class OrderLineViewModel
    {
        [Key]
        public string UniqueId { get; set; }
        public string ProductTypeId { get; set; }
        public double Amount { get; set; }
        public string Comment { get; set; }
        public double TaxRate { get; set; }
        public string TaxType { get; set; }
        public int NumberOrdered { get; set; }
        public string OrderId { get; set; }
        public string OrderLineId { get; set; }
        public string LineType { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }

        public OrderLineViewModel() { }

        public OrderLineViewModel(TaxOnLine line)
        {
            ExpectedDeliveryDate = line.ExpectedDeliveryDate;
            LineType = line.GetType().Name;
            UniqueId = line.UniqueId;
            OrderId = line.OrderId;
            OrderLineId = line.OrderLineId;
            TaxRate = line.Rate;
            TaxType = line.Type;
            Comment = line.Comment;
        }

        public OrderLineViewModel(OrderLine line)
        {
            ExpectedDeliveryDate = line.ExpectedDeliveryDate;
            LineType = line.GetType().Name;
            UniqueId = line.UniqueId;
            OrderId = line.OrderId;
            Comment = line.Comment;
            NumberOrdered = line.NumberOrdered;
            ProductTypeId = line.ProductTypeId;
        }

        public OrderLineViewModel(ChargeLine line)
        {
            ExpectedDeliveryDate = line.ExpectedDeliveryDate;
            LineType = line.GetType().Name;
            UniqueId = line.UniqueId;
            OrderId = line.OrderId;
            OrderLineId = line.OrderLineId;
            Comment = line.Comment;
            Amount = line.Amount;
        }

        public void Update(TaxOnLine line)
        {
            line.ExpectedDeliveryDate = ExpectedDeliveryDate;
            line.UniqueId = UniqueId;
            line.OrderId = OrderId;
            line.OrderLineId = OrderLineId;
            line.Rate = TaxRate;
            line.Type = TaxType;
            line.Comment = Comment;
        }

        public void Update(OrderLine line)
        {
            line.ExpectedDeliveryDate = ExpectedDeliveryDate;
            line.UniqueId = UniqueId;
            line.OrderId = OrderId;
            line.Comment = Comment;
            line.NumberOrdered = NumberOrdered;
            line.ProductTypeId = ProductTypeId;
        }

        public void Update(ChargeLine line)
        {
            line.ExpectedDeliveryDate = ExpectedDeliveryDate;
            line.UniqueId = UniqueId;
            line.OrderId = OrderId;
            line.OrderLineId = OrderLineId;
            line.Comment = Comment;
            line.Amount = Amount;
        }
    }
}
