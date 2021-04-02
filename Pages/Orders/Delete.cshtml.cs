using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bakery.RazorPages.Admin.Models;
using Bakery.RazorPages.Admin.Services;

namespace Bakery.RazorPages.Admin.Pages.Orders
{
    public class DeleteModel : PageModel
    {
        private readonly OrderService _orderService;
        private readonly InvoiceService _invoiceService;

        [BindProperty]
        public Order Order { get; set; }

        public Invoice Invoice { get; set; }

        public DeleteModel(OrderService orderService, InvoiceService invoiceService)
        {
            _orderService = orderService;
            _invoiceService = invoiceService;
        }

        public async Task OnGet(int id)
        {
            Order = await _orderService.GetOrderById(id);
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {

            Order = await _orderService.GetOrderById(id);
            Invoice = new Invoice();

            Invoice.InvoiceDate = DateTime.Now;
            Invoice.InvoicePrice = Order.OrderPrice;

            await _invoiceService.CreateInvoice(Invoice);
            await _orderService.DeleteOrder(Order.Id);
    
            return RedirectToPage("Index");
        }
    }
}
