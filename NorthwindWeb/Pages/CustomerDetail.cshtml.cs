using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using Packt.shared;
using Microsoft.AspNetCore.Mvc;

namespace NorthwindWeb.Pages
{
    public class CustomerDetailModel : PageModel
    {

        private Northwind db;
        public Customer Customer { get; set; }

        public CustomerDetailModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet(string customerId)
        {
            ViewData["Title"] = "Northwind Web Site - Customer Detail";

            Customer = db.Customers.FirstOrDefault(x => x.CustomerID == customerId);
        }
    }
}