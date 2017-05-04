using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.OrderClasses;

namespace Open.Logic.OrderClasses
{
    public class OrderDetailsModel
    {
        public OrderDetailsModel(OrderLine orderline)
        {
            OrderLineId = orderline.OrderLineId;
            ProductTypeId = orderline.ProductTypeId;
            NumberOrdered = orderline.NumberOrdered;
            ExpectedDeliveryDate = orderline.ExpectedDeliveryDate;
            
        }

        public OrderDetailsModel(DeliveryReceiver receiver)
        {
            Name = receiver.Name;
        }

        public string OrderLineId { get; set; }

        [DisplayName("Product type ID")]
        public string ProductTypeId { get; set; }

        [Description( "You can see how many instances of this product have been ordered")]
        [DisplayName("Number ordered")]
        public int NumberOrdered { get; set; }

        [DisplayName("Expected delivery date")]
        public DateTime ExpectedDeliveryDate { get; set; }

        [DisplayName("Receiver's Name")]
        public string Name { get; set; }
    }
}

