#pragma checksum "I:\OneDrive\Документы\GitHub\PieShopProject\PieShopProject\Views\Order\CheckoutComplete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e34f0e5335b39ea5aff840a4bed8f76d6ded467e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_CheckoutComplete), @"mvc.1.0.view", @"/Views/Order/CheckoutComplete.cshtml")]
namespace AspNetCore
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
#line 1 "I:\OneDrive\Документы\GitHub\PieShopProject\PieShopProject\Views\_ViewImports.cshtml"
using PieShopProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\OneDrive\Документы\GitHub\PieShopProject\PieShopProject\Views\_ViewImports.cshtml"
using PieShopProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e34f0e5335b39ea5aff840a4bed8f76d6ded467e", @"/Views/Order/CheckoutComplete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5338443b62174426fcc6470f623f45e4704dacc8", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_CheckoutComplete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "I:\OneDrive\Документы\GitHub\PieShopProject\PieShopProject\Views\Order\CheckoutComplete.cshtml"
  
    ViewData["Title"] = "CheckoutComplete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Checkout complete</h2>\r\n<h3>");
#nullable restore
#line 7 "I:\OneDrive\Документы\GitHub\PieShopProject\PieShopProject\Views\Order\CheckoutComplete.cshtml"
Write(ViewBag.CheckoutCompleteMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>        \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
