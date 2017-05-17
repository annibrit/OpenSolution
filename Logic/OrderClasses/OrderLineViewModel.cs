using System;
using System.ComponentModel.DataAnnotations;
using Open.Archetypes.OrderClasses;

namespace Open.Logic.OrderClasses
{
    public class OrderLineViewModel 
    {
        public OrderLineViewModel()
        {
            
        }

        public OrderLineViewModel(TaxOnLine line)
        {
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
            LineType = line.GetType().Name;
            UniqueId = line.UniqueId;
            OrderId = line.OrderId;
            Comment = line.Comment;
            NumberOrdered = line.NumberOrdered;
            ExpectedDeliveryDate = line.ExpectedDeliveryDate;
            ProductTypeId = line.ProductTypeId;
        }

        public string ProductTypeId { get; set; }

        public OrderLineViewModel(ChargeLine line)
        {
            LineType = line.GetType().Name;
            UniqueId = line.UniqueId;
            OrderId = line.OrderId;
            OrderLineId = line.OrderLineId;
            Comment = line.Comment;
            Amount = line.Amount;
        }

        public double Amount { get; set; }

        public string Comment { get; set; }

        public double TaxRate { get; set; }
        public string TaxType { get; set; }

        public DateTime ExpectedDeliveryDate { get; set; }

        public int NumberOrdered { get; set; }

        [Key]
        public string UniqueId { get; set; }
        public string OrderId { get; set; }
        public string OrderLineId { get; set; }


        public string LineType { get; set; }

        public void Update(TaxOnLine line)
        {
            line.UniqueId = UniqueId;
            line.OrderId= OrderId;
            line.OrderLineId = OrderLineId;
            //TODO
            //TaxRate = line.Rate;
            //TaxType = line.Type;
            //Comment = line.Comment;
        }
        public void Update(OrderLine line)
        {
            line.UniqueId = UniqueId;
            line.OrderId = OrderId;
            line.Comment = Comment;
            line.NumberOrdered = NumberOrdered;
            line.Valid.From = ExpectedDeliveryDate;
            line.ProductTypeId = ProductTypeId;
        }


        public void Update(ChargeLine line)
        {
            line.UniqueId = UniqueId;
            line.OrderId = OrderId;
            line.OrderLineId = OrderLineId;
            //TODO
            //Comment = line.Comment;
            //Amount = line.Amount;
        }

    }
}
