using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bakery.RazorPages.Admin.Services;
using Bakery.RazorPages.Admin.Models;
using Bakery.RazorPages.Admin.Extensions;

namespace Bakery.RazorPages.Admin.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly OrderService _orderService;

        public string AntiforgeryToken => HttpContext.GetAntiforgeryTokenForJs();
        public IEnumerable<Order> Orders { get; private set; } = new List<Order>();

        public IndexModel(OrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task OnGet()
        {
            Orders = await _orderService.GetOrders();
        }
    
        public async Task<IActionResult> OnDelete(int orderId)
        {
            try
            {
                await _orderService.DeleteOrder(orderId);
                return new NoContentResult();
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
