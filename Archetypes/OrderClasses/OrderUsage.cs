using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.BaseClasses;
using Open.Archetypes.ContactClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Open.Archetypes.OrderClasses
{
    [KnownType(typeof(ChargeLine))]
    [KnownType(typeof(OrderLine))]
    [KnownType(typeof(OrderStatus))]
    [KnownType(typeof(TaxOnLine))]
    [XmlInclude(typeof(ChargeLine))]
    [XmlInclude(typeof(OrderLine))]
    [XmlInclude(typeof(OrderStatus))]
    [XmlInclude(typeof(TaxOnLine))]
    public class OrderUsage : UniqueEntity
    {
        private OrderUses uses;
        private Order line;
        public Order Line
        {
            get { return SetDefault(ref line); }
            set { SetValue(ref line, value); }
        }
        public OrderUses Uses
        {
            get { return SetDefault(ref uses); }
            set { SetValue(ref uses, value); }
        }
        public static OrderUsage Random()
        {
            var x = new OrderUsage();
            x.SetRandomValues();
            return x;
        }
        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            uses = OrderUses.Random();
            //line = Order.RandomInherited();
        }
    }
}

