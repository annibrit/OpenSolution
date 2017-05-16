using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.OrderClasses;

namespace Open.Logic.OrderClasses
{
    public class OrderEditModel
    {
        public OrderEditModel() { }
        public OrderEditModel(Order order)
        {
            UniqueId = order.UniqueId;
            DateCreated = order.Valid.From;
            SalesChannel = order.SalesChannel;
            TermsAndConditions = order.TermsAndConditions;
        }

        public string UniqueId { get; set; }

        public DateTime DateCreated { get; set; }

        public string SalesChannel { get; set; }

        public string TermsAndConditions { get; set; }

        public void Update(Order order)
        {
            order.TermsAndConditions = TermsAndConditions;
            order.SalesChannel = SalesChannel;
            order.Valid.From = DateCreated;
        }
    }
}
