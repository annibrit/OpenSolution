﻿using System;
using Open.Aids;

namespace Open.Archetypes.OrderClasses
{
    public class TaxOnLine : BaseOrderLine
    {
        private string order_line_id;
        private string type;
        private double rate;
        private DateTime date_expected;

        public DateTime ExpectedDeliveryDate
        {
            get { return SetDefault(ref date_expected); }
            set { SetValue(ref date_expected, value); }
        }

        public string OrderLineId
        {
            get { return SetDefault(ref order_line_id); }
            set { SetValue(ref order_line_id, value); }
        }

        public string Type
        {
            get { return SetDefault(ref type); }
            set { SetValue(ref type, value); }
        }

        public double Rate
        {
            get { return SetDefault(ref rate); }
            set { SetValue(ref rate, value); }
        }


        public new static TaxOnLine Random()
        {
            var x = new TaxOnLine();
            x.SetRandomValues();
            return x;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            rate = GetRandom.Double();
            order_line_id = GetRandom.String();
            type = GetRandom.String();
        }
    }
}