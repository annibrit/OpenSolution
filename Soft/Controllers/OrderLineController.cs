using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using Open.Archetypes.OrderClasses;
using Open.Logic.OrderClasses;
using Open.Logic.OrderLineClasses;

namespace Soft.Controllers
{
    public class OrderLineController : Controller
    {
        private static bool isCreated;
        private OrderLine orderline;
        
        // GET: Order/Details/5
        public ActionResult OrderLineDetails(string id)
        {
            var orderline = OrderLines.Instance.Find(x => x.IsThisUniqueId(id));
            var model = new OrderLineDetailsViewModel(orderline);
            return View(model);
        }

    // GET: Order/Create
    public ActionResult CreateOrderLine()
        {
            var e = new LineEditModel();
            return View("CreateOrderLine", e);
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult CreateOrderLine(
            [Bind(Include = "UniqueID, ExpectedDeliveryDate, NumberOrdered, Comment")]
        LineEditModel k)
        {
            if (!ModelState.IsValid) return View("EditOrderLine", k);
            var orderline = new OrderLine();
            k.Update(orderline);
            OrderLines.Instance.Add(orderline);
            return RedirectToAction("OrderDetails");
        }

        // GET: Order/Details/5
        public ActionResult OrderDetails(string id)
        {
            var order = Orders.Instance.Find(x => x.IsThisUniqueId(id));
            var model = new OrderDetailsViewModel(order);
            return View(model);
        }

        // GET: Order/Edit/5
        public ActionResult EditOrderLine(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var order = OrderLines.Instance.Find(x => x.IsThisUniqueId(id));
            if (order == null) return HttpNotFound();
            return View("EditOrderLine", new LineEditModel(orderline));
        }

    }
}