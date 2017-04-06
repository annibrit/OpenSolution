using System;
using System.ComponentModel;
using Open.Archetypes.OrderClasses;

namespace Open.Logic.OrderClasses
{
    public class OrderViewModel
    {
        public OrderViewModel(Order order)
        {
            UniqueId = order.UniqueId;
            DateCreated = order.DateCreated;
            SalesChannel = order.SalesChannel;
            TermsAndConditions = order.TermsAndConditions;
        }

        [DisplayName("Order ID")]
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
    }
}