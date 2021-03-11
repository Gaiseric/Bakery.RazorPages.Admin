using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bakery.RazorPages.Admin.Models;
using Bakery.RazorPages.Admin.Services;

namespace Bakery.RazorPages.Admin.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly ProductService _productService;

        [BindProperty]
        public Product Product { get; set; }

        public EditModel(ProductService productService)
        {
            _productService = productService;
        }

        public async Task OnGet(int id)
        {
            Product = await _productService.GetProductById(id);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _productService.UpdateProduct(Product);

            return RedirectToPage("Index");
        }
    }
}
