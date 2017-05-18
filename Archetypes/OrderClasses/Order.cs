using System;
using System.Collections;
using Open.Aids;
using Open.Archetypes.BaseClasses;
using System.ComponentModel.DataAnnotations;

namespace Open.Archetypes.OrderClasses
{
    public class Order : UniqueEntity, IEnumerable
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

        //DONE teeme selle meetodiks, kuna JSON läheb lambdaga tehes lolliks
        public OrderLines GetOrderLines()
        {
            return OrderLines.GetOrderLinesByOrderId(UniqueId);
        }

        public void AddOrderLine(OrderLine orderLine)
        {
            if (IsNull(orderLine)) return;
            orderLine.OrderId = UniqueId;
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

        //DONE siin on parem kasutada omistamist privaatsetele muutujatele
        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            date_created = GetRandom.DateTime();
            sales_channel = GetRandom.String();
            terms_and_conditions = GetRandom.String();
            var lines = OrderLines.Random();
            foreach (var l in lines)
            {
                l.OrderId = UniqueId;
                OrderLines.Instance.Add(l);

            }
        }

        //public static void SaveEmployee(Order e)
        //{
        //    if (ReferenceEquals(null, e)) return;
        //    var orders = new Order();
        //    orders.Add(e);
        //    //employees.SaveChanges();
        //}
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}