using System;
using Open.Archetypes.OrderClasses;

namespace Open.Logic.OrderClasses
{
    public class LineEditModel
    {
        public string ProductType { get; set; }
        public string OrderId { get; set; }
        public double Amount { get; set; }
        public string OrderLineId { get; set; } = string.Empty;
        public double TaxRate { get; set; }
        public string TaxType { get; set; } = string.Empty;
        public string UniqueId { get; set; } = string.Empty;
        public int NumberOrdered { get; set; }
        public string Comment { get; set; } = string.Empty;
        public DateTime ExpectedDeliveryDate { get; set; }


        public LineEditModel() { }
        public LineEditModel(OrderLine line)
        {
            ExpectedDeliveryDate = line.ExpectedDeliveryDate;
            UniqueId = line.UniqueId;
            OrderId = line.OrderId;
            NumberOrdered = line.NumberOrdered;
            Comment = line.Comment;
            ProductType = line.ProductTypeId;
        }


        public LineEditModel(TaxOnLine line)
        {
            ExpectedDeliveryDate = line.ExpectedDeliveryDate;
            UniqueId = line.UniqueId;
            OrderLineId = line.OrderLineId;
            OrderId = line.OrderId;
            Comment = line.Comment;
            TaxType = line.Type;
            TaxRate = line.Rate;
        }

        public LineEditModel(ChargeLine line)
        {
            ExpectedDeliveryDate = line.ExpectedDeliveryDate;
            UniqueId = line.UniqueId;
            OrderLineId = line.OrderLineId;
            OrderId = line.OrderId;
            Comment = line.Comment;
            Amount = line.Amount;
        }

        public void Update(OrderLine line)
        {
            line.ExpectedDeliveryDate = ExpectedDeliveryDate;
            line.OrderId = OrderId;
            line.UniqueId = UniqueId;
            line.ProductTypeId = ProductType;
            line.Comment = Comment;
            line.NumberOrdered = NumberOrdered;
        }

        public void Update(ChargeLine line)
        {
            line.ExpectedDeliveryDate = ExpectedDeliveryDate;
            line.OrderLineId = OrderLineId;
            line.OrderId = OrderId;
            line.UniqueId = UniqueId;
            line.Comment = Comment;
            line.Amount = Amount;
        }

        public void Update(TaxOnLine line)
        {
            line.ExpectedDeliveryDate = ExpectedDeliveryDate;
            line.OrderLineId = OrderLineId;
            line.OrderId = OrderId;
            line.UniqueId = UniqueId;
            line.Comment = Comment;
            line.Rate = TaxRate;
            line.Type = TaxType;
        }
    }
}
