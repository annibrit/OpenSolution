using System.Runtime.Serialization;
using System.Xml.Serialization;
using Open.Archetypes.BaseClasses;

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
        private Order line;
        private OrderUses uses;

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