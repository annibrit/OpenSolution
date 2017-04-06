using System;
using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class Order : UniqueEntity
    {
        private DateTime date_created;
        private string sales_channel;
        private string terms_and_conditions;

        public DateTime DateCreated
        {
            get { return SetDefault(ref date_created); }
            set { SetValue(ref date_created, value); }
        }

        public string SalesChannel
        {
            get { return SetDefault(ref sales_channel); }
            set { SetValue(ref sales_channel, value); }
        }

        public string TermsAndConditions
        {
            get { return SetDefault(ref terms_and_conditions); }
            set { SetValue(ref terms_and_conditions, value); }
        }

        public OrderLines GetOrderLines => OrderLines.GetOrderLinesByOrderId(UniqueId); 

        public void AddOrderLine(OrderLine orderLine)
        {
            OrderLines.Instance.Add(orderLine);
        }

        public void RemoveOrderLine(OrderLine orderLine)
        {
            OrderLines.Instance.Remove(orderLine);
        }

        public static Order Random()
        {
            var a = new Order();
            a.SetRandomValues();
            return a;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            DateCreated = GetRandom.DateTime();
            SalesChannel = GetRandom.String();
            TermsAndConditions = GetRandom.String();

        }
    }
}