#pragma checksum "C:\Users\melm_\source\repos\SE_Labs_Pic\Bakery.RazorPages.Admin\Pages\Invoices\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9ee0dd543436197a15007dc976b769698d6cff6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Bakery.RazorPages.Admin.Pages.Invoices.Pages_Invoices_Index), @"mvc.1.0.razor-page", @"/Pages/Invoices/Index.cshtml")]
namespace Bakery.RazorPages.Admin.Pages.Invoices
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\melm_\source\repos\SE_Labs_Pic\Bakery.RazorPages.Admin\Pages\_ViewImports.cshtml"
using Bakery.RazorPages.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ee0dd543436197a15007dc976b769698d6cff6", @"/Pages/Invoices/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b021df6a9116cbcfc59174508ad355fcf8f7e14", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Invoices_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\melm_\source\repos\SE_Labs_Pic\Bakery.RazorPages.Admin\Pages\Invoices\Index.cshtml"
  
    ViewData["Title"] = "Admin Invoices";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<meta http-equiv=""Refresh"" content=""15"" />

<h1>Invoices Administration</h1>

<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">Date</th>
            <th scope=""col"">Price</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\melm_\source\repos\SE_Labs_Pic\Bakery.RazorPages.Admin\Pages\Invoices\Index.cshtml"
         foreach (var invoice in Model.Invoices)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\melm_\source\repos\SE_Labs_Pic\Bakery.RazorPages.Admin\Pages\Invoices\Index.cshtml"
               Write(invoice.InvoiceDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\melm_\source\repos\SE_Labs_Pic\Bakery.RazorPages.Admin\Pages\Invoices\Index.cshtml"
                Write($"{invoice.InvoicePrice:C}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "C:\Users\melm_\source\repos\SE_Labs_Pic\Bakery.RazorPages.Admin\Pages\Invoices\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<span id=\"spanError\" class=\"text-danger\"></span><br />");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bakery.RazorPages.Admin.Pages.Invoices.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bakery.RazorPages.Admin.Pages.Invoices.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bakery.RazorPages.Admin.Pages.Invoices.IndexModel>)PageContext?.ViewData;
        public Bakery.RazorPages.Admin.Pages.Invoices.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
