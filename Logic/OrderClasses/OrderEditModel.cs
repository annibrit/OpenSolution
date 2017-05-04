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

        [DisplayName("Date Created")]
        public DateTime DateCreated { get; set; }

        [Description(
            "The sales channel through which the Order was raised.\nExamples of sales channels are: Mail, Telephone, Internet etc."
        )]
        [DisplayName("Sales Channel")]
        public string SalesChannel { get; set; }

        [Description("Example:\"delivery within 28 days\" or details of payment terms")]
        [DisplayName("Terms and Conditions")]
        public string TermsAndConditions { get; set; }

        public void Update(Order order)
        {
           
            order.TermsAndConditions = TermsAndConditions;
            order.SalesChannel = SalesChannel;
            order.Valid.From = DateCreated;

        }
    }
}
