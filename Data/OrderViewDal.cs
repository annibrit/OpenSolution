//using System;
//using System.ComponentModel.DataAnnotations;
//using Open.Archetypes.OrderClasses;

//namespace Open.Data
//{
//    public class OrderViewDal
//    {
//        public OrderViewDal()
//        {
//        }

//        public OrderViewDal(Order u)
//        {
//            Id = u.UniqueId;
//            DateCreated = u.Valid.From;
//            ValidTo = u.Valid.To;
//            SalesChannel = u.SalesChannel;
//        }

//        [Key]
//        public string Id { get; set; }
//        public string SalesChannel { get; set; }
//        public string TermsAndConditions { get; set; }
//        public DateTime DateCreated { get; set; }
//        public DateTime ValidTo { get; set; }

//        public void Update(Order u)
//        {
//            u.UniqueId = Id;
//            u.TermsAndConditions = TermsAndConditions;
//            u.SalesChannel = SalesChannel;
//            u.Valid.From = DateCreated;
//            u.Valid.To = ValidTo;
//        }
//    }
//}
