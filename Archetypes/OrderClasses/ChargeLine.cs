using System;
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
        public OrderLineIdentifier id { get; set; }
    }

    //addTax
    //getTaxes
    //removeTax
}
