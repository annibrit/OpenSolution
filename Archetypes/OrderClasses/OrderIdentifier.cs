using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Aids;

namespace Order
{
    public class OrderIdentifier : UniqueIdentifier
    {
        private string identifier;

        public string Identifier
        {
            get { return SetDefault(ref identifier); }
            set { identifier = value; }
        }
    }
}
