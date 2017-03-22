﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.BaseClasses;

namespace Order
{
    public class ChargeLine : UniqueEntity
    {
        public OrderLineIdentifier id { get; set; }
        private double amount;
        private string description;
        private string comment;

        public double Amount
        {
            get { return SetDefault(ref amount); }
            set { SetValue(ref amount, value); }
        }
        public string Description
        {
            get { return SetDefault(ref description); }
            set { SetValue(ref description, value); }
        }
        public string Comment
        {
            get { return SetDefault(ref comment); }
            set { SetValue(ref comment, value); }
        }
    }

    //addTax
    //getTaxes
    //removeTax
}