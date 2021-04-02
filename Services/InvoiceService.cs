using Bakery.RazorPages.Admin.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bakery.RazorPages.Admin.Services
{
    public class InvoiceService
    {
         private readonly string _route;

        private readonly HttpClient _httpClient;

        public InvoiceService(
            HttpClient httpClient,
            IConfiguration configuration)
        {
            _httpClient = httpClient;
            _route = configuration["InvoiceService:ControllerRoute"];
        }

        public async Task<IEnumerable<Invoice>> GetInvoices()
        {
            var response = await _httpClient.GetAsync(_route);
            response.EnsureSuccessStatusCode();

            var invoices = await response.Content.ReadAsAsync<IEnumerable<Invoice>>();

            return invoices;
        }

        public async Task<Invoice> GetInvoiceById(int invoiceId)
        {
            var response = await _httpClient.GetAsync($"{_route}/{invoiceId}");
            response.EnsureSuccessStatusCode();

            var invoice = await response.Content.ReadAsAsync<Invoice>();

            return invoice;
        }

        public Task CreateInvoice(Invoice invoice) =>
            _httpClient.PostAsJsonAsync(_route, invoice);

        public Task DeleteInvoice(int invoiceId) =>
            _httpClient.DeleteAsync($"{_route}/{invoiceId}");
    }
}