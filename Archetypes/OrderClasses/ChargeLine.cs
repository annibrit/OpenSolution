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
        public double amount;
        public string description;
        public string Comment;

        //TODO: teiste atribuutidega samamoodi

        private string orderLineIdentifier;

        public string OrderLineIdentifier
        {
            get { return SetDefault(ref orderLineIdentifier); }
            set { SetValue(ref orderLineIdentifier, value); }
        }

    }

    //addTax
    //getTaxes
    //removeTax
}
