using System.Collections.Generic;
using System.Web.Mvc;
using Open.Archetypes.OrderClasses;
using Open.Logic.OrderClasses;

namespace Soft.Controllers
{
    public class OrderController : Controller
    {
        private static bool isCreated;
        // GET: Order
        public ActionResult Index()
        {
            if (!isCreated) Orders.Instance.AddRange(Orders.Random());
            isCreated = true;
            var m = new List<OrderViewModel>();
            foreach (var e in Orders.Instance)
            {
                var x = new OrderViewModel(e);
                m.Add(x);
            }
            return View(m);
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}