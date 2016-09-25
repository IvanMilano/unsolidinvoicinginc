using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnSolid.Invoicing.Inc.DAL;
using UnSolid.Invoicing.Inc.Models;

namespace UnSolid.Invoicing.Inc.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            using (var db = new UnsolidInvoicingContext())
            {
                var unitTypes = db.ProductUnits.ToList();
                ViewData["UnitTypes"]  = new SelectList(unitTypes, "Id", "Name");
            }

            return View();

        }

        public ActionResult Delete()
        {
            return View("Index");
        }
    }
}