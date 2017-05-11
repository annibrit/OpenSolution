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
        private OrderLine orderline;
        // GET: Order
        public ActionResult OrderLineDetails(string id)
        {
            var orderline = OrderLines.Instance.Find(x => x.IsThisUniqueId(id));
            var model = new OrderLineDetailsViewModel(orderline);
            return View(model);
        }

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
            return View(m);
        }

        // GET: Order/Details/5
        public ActionResult OrderDetails(string id)
        {
            var order = Orders.Instance.Find(x => x.IsThisUniqueId(id));
            var model = new OrderDetailsViewModel(order);
            return View(model);
        }

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

        public ActionResult EditOrderLine(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var order = OrderLines.Instance.Find(x => x.IsThisUniqueId(id));
            if (order == null) return HttpNotFound();
            return View("EditOrderLine", new OrderLineEditModel(orderline));
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
            var order = OrderLines.Instance.Find(x => x.IsThisUniqueId(id));
            if (order == null) return HttpNotFound();
            return View("DeleteOrderLine", new OrderLineViewModel(orderline));
        }
        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult DeleteOrderLine(string id, FormCollection collection)
        {
            try
            {
                var orderline = OrderLines.Instance.Find(x => x.IsThisUniqueId(id));
                orderline.Valid.To = DateTime.Now;
            }
            catch
            {
                ;
            }
            return RedirectToAction("OrderDetails");
        }
    }
}