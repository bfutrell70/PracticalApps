using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using Packt.shared;
using Microsoft.AspNetCore.Mvc;

namespace NorthwindWeb.Pages
{
    public class CustomersByCountryModel : PageModel
    {

        private Northwind db;
        public IEnumerable<Customer> Customers { get; set; }

        public CustomersByCountryModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Site - Customers by Country";

            Customers = db.Customers.OrderBy(x => x.Country).ThenBy(x => x.CompanyName);
        }
    }
}