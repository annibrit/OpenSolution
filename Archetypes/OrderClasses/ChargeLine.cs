using System;
using System.Collections.Generic;
using Open.Archetypes.BaseClasses;

namespace Order
{
    public class ChargeLine : UniqueEntity
    {
        
        private double amount;
        private string description;
        private string comment;
        public string id { get; set; }

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

    //addTax (pärinevad taxonline'st)
    //getTaxes
    //removeTax
}
