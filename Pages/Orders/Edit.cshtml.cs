using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bakery.RazorPages.Admin.Models;
using Bakery.RazorPages.Admin.Services;

namespace Bakery.RazorPages.Admin.Pages.Orders
{
    public class EditModel : PageModel
    {
        private readonly OrderService _orderService;

        public SelectList Statuses { get; set; }

        public List<string> status = new List<string>() {"NEW", "Processed", "Delivered", "Completed"};

        [BindProperty]
        public Order Order { get; set; }

        public EditModel(OrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task OnGet(int id)
        {
            Order = await _orderService.GetOrderById(id);
            Statuses = new SelectList(status); 
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _orderService.UpdateOrder(Order);

            return RedirectToPage("Index");
        }
    }
}
