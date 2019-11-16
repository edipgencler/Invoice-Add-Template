using invoiceCreate.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace invoiceCreate.Controllers
{
    public class HomeController : Controller
    {
        private readonly CustomerContext _context;

        public HomeController(CustomerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new InvoiceViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(InvoiceViewModel model)
        {
            var customer = new Customer()
            {
                Adress = model.Address,
                Name = model.Name,
                Phone = model.Phone,
                Surname = model.SurName,
                Invoice = new Invoice
                {
                    InvoiceDate = model.InvoiceDate,
                    InvoiceNo = model.InvoiceNo,
                    ProductName = model.ProductName,
                    ProductPriceAmount = model.ProductPriceAmount,
                    ProductQuantity = model.ProductQuantity,
                    ProductSubAmount = model.ProductSubAmount,
                    ProductTotalAmount = model.ProductTotalAmount,
                }
            };

            _context.Add<Customer>(customer);
            _context.SaveChanges();

            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
