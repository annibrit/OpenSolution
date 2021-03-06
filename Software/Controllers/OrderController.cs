﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using Open.Archetypes.OrderClasses;
using Open.Data;
using Open.Logic.OrderClasses;

namespace Software.Controllers
{
    public class OrderController : Controller
    {
        public ActionResult Index()
        {
            Business.Load(Orders.Instance);
            if (Orders.Instance.Count == 0)
            {
                Orders.Instance.AddRange(Orders.Random());
                Business.Save(Orders.Instance);
            }

            var m = new List<OrderViewModel>();
            foreach (var e in Orders.Instance)
            {
                if (e.Valid.To < DateTime.Now) continue;
                var x = new OrderViewModel(e);
                m.Add(x);
            }
            return View("Index", m);
        }


        // GET
        public ActionResult OrderDetails(string id)
        {
            OrderLines.Instance.Clear();
            Business.Load(OrderLines.Instance);
            var order = Orders.Instance.Find(x => x.IsThisUniqueId(id));
            var model = new OrderDetailsViewModel(order);
            return View(model);
        }

        // GET
        public ActionResult LineDetails(string id)
        {
            var line = OrderLines.Instance.Find(x => x.IsThisUniqueId(id));
            if (line is OrderLine) return View("OrderLineDetails", new OrderLineDetailsViewModel((OrderLine)line));
            if (line is ChargeLine) return View("ChargeLineDetails", new ChargeLineDetailsViewModel((ChargeLine)line));
            if (line is TaxOnLine) return View("TaxOnLineDetails", new TaxOnLineDetailsViewModel((TaxOnLine)line));
            return View("Index");
        }

        // GET
        public ActionResult CreateOrder()
        {
            var e = new OrderEditModel();
            return View("CreateOrder", e);
        }

        // POST
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

        // GET
        public ActionResult CreateOrderLine(string id)
        {
            var e = new LineEditModel();
            e.OrderId = id;
            e.UniqueId = Guid.NewGuid().ToString();
            return View("CreateOrderLine", e);
        }

        // POST
        [HttpPost]
        public ActionResult CreateOrderLine(
            [Bind(Include = "UniqueID, OrderId, ProductTypeId, ExpectedDeliveryDate, NumberOrdered, Comment")] LineEditModel k)
        {
            if (!ModelState.IsValid) return View("EditOrderLine", k);
            var line = new OrderLine();
            k.Update(line);
            Business.Save(line);
            return RedirectToAction("OrderDetails", "Order", new {id = k.OrderId});
    }

        // GET
        public ActionResult CreateChargeLine(string id)
        {
            var e = new LineEditModel();
            e.OrderId = id;
            e.UniqueId = Guid.NewGuid().ToString();
            return View("CreateChargeLine", e);
        }

        // POST
        [HttpPost]
        public ActionResult CreateChargeLine(
            [Bind(Include = "UniqueId, OrderId, OrderLineId, ExpectedDeliveryDate, Amount, Comment")]
        LineEditModel k)
        {
            if (!ModelState.IsValid) return View("EditChargeLine", k);
            var line = new ChargeLine();
            k.Update(line);
            OrderLines.Instance.Add(line);
            return RedirectToAction("OrderDetails", "Order", new {id = k.OrderId});
        }

        // GET: Order/Create
        public ActionResult CreateTaxOnLine(string id)
        {
            var e = new LineEditModel();
            e.OrderId = id;
            e.UniqueId = Guid.NewGuid().ToString();
            return View("CreateTaxOnLine", e);
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult CreateTaxOnLine(
            [Bind(Include = "UniqueID, OrderId, OrderLineId, TaxType, TaxRate, Comment")]
            LineEditModel k)
        {
            if (!ModelState.IsValid) return View("EditTaxOnLine", k);
            var line = new TaxOnLine();
            k.Update(line);
            Business.Save(line);
            return RedirectToAction("OrderDetails", "Order", new { id = k.OrderId });
        }

        // GET: Order/Edit/5
        public ActionResult EditOrder(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var order = Orders.Instance.Find(x => x.IsThisUniqueId(id));
            if (order == null) return HttpNotFound();
            return View("EditOrder", new OrderEditModel(order));
        }

        // POST: Order/Edit/5
        
             [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditOrder(
            [Bind(Include = "UniqueID, DateCreated, SalesChannel, TermsAndConditions")] OrderEditModel e)
        {
            if (!ModelState.IsValid) return View("EditOrder", e);
            var order = Orders.Instance.Find(x => x.IsThisUniqueId(e.UniqueId));
            if (order == null) return HttpNotFound();
            e.Update(order);
            return RedirectToAction("Index");
        }
        //GET
        public ActionResult EditLine(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var l = OrderLines.Instance.Find(x => x.IsThisUniqueId(id));
            if (l is TaxOnLine) return View("EditTaxOnLine", new LineEditModel((TaxOnLine)l));
            if (l is ChargeLine) return View("EditChargeLine", new LineEditModel((ChargeLine)l));
            if (l is OrderLine) return View("CreateOrderLine", new LineEditModel((OrderLine)l));
            return HttpNotFound();
        }

        // GET
        public ActionResult DeleteOrder(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var order = Orders.Instance.Find(x => x.IsThisUniqueId(id));
            if (order == null) return HttpNotFound();
            return View("Delete", new OrderViewModel(order));
        }
        // POST
        [HttpPost]
        public ActionResult DeleteOrder(string id, FormCollection collection)
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

        // GET
        public ActionResult DeleteLine(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var l = OrderLines.Instance.Find(x => x.IsThisUniqueId(id));
            if (l is TaxOnLine) return View("DeleteLine", new LineViewModel((TaxOnLine)l));
            if (l is ChargeLine) return View("DeleteLine", new LineViewModel((ChargeLine)l));
            if (l is OrderLine) return View("DeleteLine", new LineViewModel((OrderLine)l));
            return HttpNotFound();
        }
        // POST: Order/Delete/5

        //FIX THIS SHIET!


        //[HttpPost]
        //public ActionResult DeleteLine(string id, FormCollection collection)
        //{
        //    try
        //    {
        //        var l = OrderLines.Instance.Find(x => x.IsThisUniqueId(id));

        //        Business.Delete();

        //        var order = Orders.Instance.Find(x => x.IsThisUniqueId(l.OrderId));
        //        var model = new OrderDetailsViewModel(order);
        //        return View("OrderDetails", model);
        //    }
        //    catch
        //    {
        //        ;
        //    }
        //    return RedirectToAction("Index");
        //}

    }
}