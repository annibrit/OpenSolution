﻿using Open.Archetypes.OrderClasses;

namespace Open.Logic.OrderClasses
{
    public class OrderLineDetailsViewModel
    {
        private object p;

        public OrderLineDetailsViewModel() : this(null) { }
        public OrderLineDetailsViewModel(OrderLine orderline, DeliveryReceiver deliveryreceiver)
        {
            NumberOrdered = orderline.NumberOrdered;
            DeliveryReceiverId = orderline.DeliveryReceiverId;
            DeliveryReceiverName = deliveryreceiver.Name;
            DeliveryReceiverPhone = deliveryreceiver.MobilePhone;
            DeliveryReceiverAddress = deliveryreceiver.Address;

            //foreach (var line in orderline.GetOrderLines())
            //{
            //    if (line is TaxOnLine) OrderLines.Add(new OrderLineViewModel((TaxOnLine)line));
            //    if (line is ChargeLine) OrderLines.Add(new OrderLineViewModel((ChargeLine)line));
            //    if (line is OrderLine) OrderLines.Add(new OrderLineViewModel((OrderLine)line));
            //}
            UniqueId = orderline.UniqueId;
        }

        public OrderLineDetailsViewModel(object p)
        {
            this.p = p;
        }

        public string UniqueId { get; set; }

        public string DeliveryReceiverId { get; set; }

        public int NumberOrdered { get; set; }

        public string DeliveryReceiverName { get; set; }

        public uint DeliveryReceiverPhone { get; set; }

        public string DeliveryReceiverAddress { get; set; }
       
    }

}


