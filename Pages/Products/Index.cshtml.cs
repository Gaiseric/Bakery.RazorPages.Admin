using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bakery.RazorPages.Admin.Services;
using Bakery.RazorPages.Admin.Models;
using Bakery.RazorPages.Admin.Extensions;

namespace Bakery.RazorPages.Admin.Pages.Products
{
    public class IndexModel : PageModel
    {
         private readonly ProductService _productService;

        public string AntiforgeryToken => HttpContext.GetAntiforgeryTokenForJs();
        public IEnumerable<Product> Products { get; private set; } = new List<Product>();

        public IndexModel(ProductService productService)
        {
            _productService = productService;
        }

        public async Task OnGet()
        {
            Products = await _productService.GetProducts();
        }
    
        public async Task<IActionResult> OnDelete(int productId)
        {
            try
            {
                await _productService.DeleteProduct(productId);
                return new NoContentResult();
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
