using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.OrderClasses;

namespace Open.Logic.OrderClasses
{
   public class OrderViewModel
    {
        public OrderViewModel(OrderUsage a)
        {
            Type = a.Line.GetType().Name;
            UniqueId = a.UniqueId;
            Content = a.Line.Content;
            Usages = a.Uses.Content;  
        }
       
        public string UniqueId { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public string Usages { get; set; }
        public string UsagesColor { get; set; }
    }
}

