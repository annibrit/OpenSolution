using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.OrderClasses;

namespace Open.Logic.OrderLineClasses
{
    public class OrderLineEditModel
    {
        public OrderLineEditModel() { }
        public OrderLineEditModel(OrderLine orderline)
        {
            UniqueId = orderline.UniqueId;
            ExpectedDeliveryDate = orderline.Valid.From;
            NumberOrdered = orderline.NumberOrdered;
            Comment = orderline.Comment;
        }

        public string UniqueId { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public int NumberOrdered { get; set; }
        public string Comment { get; set; }

        public void Update(OrderLine orderline)
        {
            orderline.Comment = Comment;
            orderline.NumberOrdered = NumberOrdered;
            orderline.Valid.From = ExpectedDeliveryDate;
        }
    }
}
