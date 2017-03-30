using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Soft.Controllers
{
    public class OrderLineController : Controller
    {
        // GET: OrderLine
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrderLine/Details/5
        public ActionResult Details(int id)
        {
            return null;
        }

        // GET: OrderLine/Create
        public ActionResult Create()
        {
            return null;
        }

        // POST: OrderLine/Create
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
                return null;
            }
        }

        // GET: OrderLine/Edit/5
        public ActionResult Edit(int id)
        {
            return null;
        }

        // POST: OrderLine/Edit/5
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
                return null;
            }
        }

        // GET: OrderLine/Delete/5
        public ActionResult Delete(int id)
        {
            return null;
        }

        // POST: OrderLine/Delete/5
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
                return null;
            }
        }
    }
}
