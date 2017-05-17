using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Archetypes.OrderClasses;
using Open.Logic.OrderClasses;

namespace Open.Data
{
    public class Business
    {
        public static void Save(Orders instance)
        {
            var db = new DefaultConnection();
            foreach (var i in instance) {
                db.Orders.Add(new OrderViewModel(i));
            }
            db.SaveChanges();
        }
        public static void Save(OrderLines instance)
        {
            var db = new DefaultConnection();
            foreach (var i in instance)
            {
                var t = i as TaxOnLine;
                var c = i as ChargeLine;
                var l = i as OrderLine;
                if (t != null)
                db.OrderLines.Add(new OrderLineViewModel(t));
                if (c != null)
                    db.OrderLines.Add(new OrderLineViewModel(c));
                if (l != null)
                    db.OrderLines.Add(new OrderLineViewModel(l));
            }
            db.SaveChanges();
        }
        public static void Load(Orders instance)
        {
            var db = new DefaultConnection();
            foreach (var u in db.Orders)
            {
                var o = new Order();
                u.Update(o);
                instance.Add(o);
            }
        }
        public static void Load(OrderLines instance)
        {
            var db = new DefaultConnection();
            foreach (var u in db.OrderLines)
            {
                BaseOrderLine l = null;
                if (u.LineType == "OrderLine") l = addOrderLine(u);
                else if (u.LineType == "TaxOnLine") l= addTaxLine(u);
                else if (u.LineType == "ChargeLine") l = addChargeLine(u);
                if (l == null) continue;
                instance.Add(l);
            }
        }

        private static ChargeLine addChargeLine(OrderLineViewModel l)
        {
            var o = new ChargeLine();
            l.Update(o);
            return o;
        }

        private static TaxOnLine addTaxLine(OrderLineViewModel l)
        {
            var o = new TaxOnLine();
            l.Update(o);
            return o;
        }

        private static OrderLine addOrderLine(OrderLineViewModel l)
        {
            var o = new OrderLine();
            l.Update(o);
            return o;
        }

        public static void Save(OrderLine instance)
        {
            var db = new DefaultConnection();
            db.OrderLines.AddOrUpdate(new OrderLineViewModel(instance));
            db.SaveChanges();
        }

        public static void Delete(OrderLine instance)
        {
            var db = new DefaultConnection();
            db.OrderLines.Remove(new OrderLineViewModel(instance));
            db.SaveChanges();
        }
    }
}
