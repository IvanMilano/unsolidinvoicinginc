using System.Web.Mvc;

namespace UnSolid.Invoicing.Inc.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: Invoice
        public ActionResult Index()
        {
            return View();
        }
    }
}