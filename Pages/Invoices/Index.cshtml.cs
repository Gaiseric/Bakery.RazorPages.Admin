using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bakery.RazorPages.Admin.Services;
using Bakery.RazorPages.Admin.Models;
using Bakery.RazorPages.Admin.Extensions;

namespace Bakery.RazorPages.Admin.Pages.Invoices
{
    public class IndexModel : PageModel
    {
        private readonly InvoiceService _invoiceService;

        public IEnumerable<Invoice> Invoices { get; private set; } = new List<Invoice>();

        public IndexModel(InvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        public async Task OnGet()
        {
            Invoices = await _invoiceService.GetInvoices();
        }
    }
}
