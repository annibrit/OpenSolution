//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Open.Archetypes.OrderClasses;

//namespace Open.Data
//{
//    public class OrderDal
//    {
//        public OrderDal()
//        {
//        }
//        public OrderDal(Order u)
//        {
//            UniqueId = u.UniqueId;
//            Type = u.GetType().ToString();
//            TermsAndConditions = u.TermsAndConditions;
//        }

//        [Key]
//        public string Type { get; set; }
//        public string TermsAndConditions { get; set; }
//        public string UniqueId { get; set; }

//    }
//}
