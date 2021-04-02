using System;
using System.ComponentModel.DataAnnotations;

namespace Bakery.RazorPages.Admin.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        [Display(Name = "Date")]
        [Required]
        public DateTime InvoiceDate { get; set; }

        [Display(Name = "Price")]
        [Required]
        [Range(0.01, 9999.99)]
        public decimal InvoicePrice {get; set; }
    }
}