using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using Open.Archetypes.OrderClasses;
using Open.Logic.OrderClasses;
using Open.Logic.OrderLineClasses;

namespace Soft.Controllers
{
    public class OrderController : Controller
    {
        private static bool isCreated;

        public ActionResult Index()
        {
            if (!isCreated) Orders.Instance.AddRange(Orders.Random());
            isCreated = true;
            var m = new List<OrderViewModel>();
            foreach (var e in Orders.Instance)
            {
                if (e.Valid.To < DateTime.Now) continue;
                var x = new OrderViewModel(e);
                m.Add(x);
            }
            return View("Index", m);
        }

        // GET: Order/Details/5
        public ActionResult OrderDetails(string id)
        {
            var order = Orders.Instance.Find(x => x.IsThisUniqueId(id));
            var model = new OrderDetailsViewModel(order);
            return View(model);
        }

        // GET: Order
        public ActionResult OrderLineDetails(string id)
        {
            var line = OrderLines.Instance.Find(x => x.IsThisUniqueId(id));
            if (line is OrderLine) return View("OrderLineDetails", new OrderLineDetailsViewModel((OrderLine)line));
            if (line is ChargeLine) return View("ChargeLineDetails", new ChargeLineDetailsViewModel((ChargeLine)line));
            if (line is TaxOnLine) return View("TaxOnLineDetails", new TaxOnLineDetailsViewModel((TaxOnLine)line));
            return View(line);
        }

        //public ActionResult OrderLineDetails(string id)
        //{
        //    var line = OrderLines.Instance.Find(x => x.IsThisUniqueId(id));
        //    var model = new OrderLineDetailsViewModel(line);
        //    return View(model);
        //}

        // GET: Order/Create
        public ActionResult CreateOrder()
        {
            var e = new OrderEditModel();
            return View("CreateOrder", e);
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult CreateOrder(
            [Bind(Include = "UniqueID, DateCreated, SalesChannel, TermsAndConditions")]
        OrderEditModel k)
        {
            if (!ModelState.IsValid) return View("EditOrder", k);
            var order = new Order();
            k.Update(order);
            Orders.Instance.Add(order);
            return RedirectToAction("Index");
       }

        //// GET: Order/Create
        //public ActionResult CreateOrderLine()
        //{
        //    var e = new OrderEditModel();
        //    return View("CreateOrderLine", e);
        //}

        //// POST: Order/Create
        //[HttpPost]
        //public ActionResult CreateOrderLine(
        //    [Bind(Include = "UniqueID, ExpectedDeliveryDate, NumberOrdered, Comment")]
        //OrderEditModel k)
        //{
        //    if (!ModelState.IsValid) return View("EditOrderLine", k);
        //    var line = new OrderLine();
        //    k.Update(line);
        //    OrderLines.Instance.Add(line);
        //    return RedirectToAction("OrderDetails");
        //}

        // GET: Order/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var order = Orders.Instance.Find(x => x.IsThisUniqueId(id));
            if (order == null) return HttpNotFound();
            return View("EditOrder", new OrderEditModel(order));
        }

        // POST: Order/Edit/5
        
             [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditEmail(
            [Bind(Include = "UniqueID, DateCreated, SalesChannel, TermsAndConditions")] OrderEditModel e)
        {
            if (!ModelState.IsValid) return View("EditOrder", e);
            var order = Orders.Instance.Find(x => x.IsThisUniqueId(e.UniqueId));
            if (order == null) return HttpNotFound();
            e.Update(order);
            return RedirectToAction("Index");
        }

        public ActionResult EditLine(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var l = OrderLines.Instance.Find(x => x.IsThisUniqueId(id));
            if (l is TaxOnLine) return View("EditTaxOnLine", new LineEditModel((TaxOnLine)l));
            if (l is ChargeLine) return View("EditChargeLine", new LineEditModel((ChargeLine)l));
            if (l is OrderLine) return View("EditOrderLine", new LineEditModel((OrderLine)l));
            return HttpNotFound();
        }


        // GET: Order/Delete/5
        public ActionResult DeleteOrder(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var order = Orders.Instance.Find(x => x.IsThisUniqueId(id));
            if (order == null) return HttpNotFound();
            return View("Delete", new OrderViewModel(order));
        }
        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                var order = Orders.Instance.Find(x => x.IsThisUniqueId(id));
                order.Valid.To = DateTime.Now;
            }
            catch
            {
                ;
            }
            return RedirectToAction("Index");
        }

        // GET: Order/Delete/5
        public ActionResult DeleteOrderLine(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var l = OrderLines.Instance.Find(x => x.IsThisUniqueId(id));
            if (l is TaxOnLine) return View("DeleteOrderLine", new OrderLineViewModel((TaxOnLine)l));
            if (l is ChargeLine) return View("DeleteOrderLine", new OrderLineViewModel((ChargeLine)l));
            if (l is OrderLine) return View("DeleteOrderLine", new OrderLineViewModel((OrderLine)l));
            return HttpNotFound();
        }
        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult DeleteOrderLine(string id, FormCollection collection)
        {
            try
            {
                var l = OrderLines.Instance.Find(x => x.IsThisUniqueId(id));
                l.Valid.To = DateTime.Now;
                var order = Orders.Instance.Find(x => x.IsThisUniqueId(l.OrderId));
                var model = new OrderDetailsViewModel(order);
                return View("OrderDetails", model);
            }
            catch
            {
                ;
            }
            return RedirectToAction("Index");
        }
    }
}