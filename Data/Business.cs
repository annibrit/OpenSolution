using System;
using System.Collections.Generic;
using Open.Archetypes.OrderClasses;
using static Open.Data.OrderViewDal;

namespace Open.Data
{
    public class Business
    {
        public static void Save(Orders instance)
        {
            var db = new OrderDatabase();
            foreach (var i in instance)
            {
                db.OrderV.Add(new OrderViewDal(i));
                db.OrderD.Add(new OrderDal(i));
            }
            db.SaveChanges();
        }
        public static List<Order> Load()
        {
            var db = new OrderDatabase();
            var l = new List<Order>();
            foreach (var u in db.OrderV)
            {
                var au = new Order();
                u.Update(au);
                l.Add(au);
            }
            return l;
        }



    }
}
