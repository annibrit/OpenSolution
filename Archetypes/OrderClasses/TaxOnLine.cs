﻿using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Order
{
    public class TaxOnLine : Archetype
    {
        //TODO: teiste atribuutidega samamoodi

        /*private string orderLineIdentifier;

        public string OrderLineIdentifier
        {
            get { return SetDefault(ref orderLineIdentifier); }
            set { SetValue(ref orderLineIdentifier, value); }
        } */

        private string type;
        private string comment;
        //taxationRate:Real
        public TaxOnLine tax { get; set; }

        public double Rate { get; set; }

        public string Type
        {
            get { return GetString.EmptyIfNull(type); }
            set { type = value; }
        }

        public string Comment
        {
            get { return GetString.EmptyIfNull(comment); }
            set { comment = value; }
        }   
    }
}
