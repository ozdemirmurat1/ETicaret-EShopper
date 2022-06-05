#pragma checksum "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Shared\Components\OrderDetail\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8b1c1feee21abd636eb69ce2200f3ccbc7796a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_OrderDetail_Default), @"mvc.1.0.view", @"/Views/Shared/Components/OrderDetail/Default.cshtml")]
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
#line 1 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\_ViewImports.cshtml"
using ETrade.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\_ViewImports.cshtml"
using ETrade.Presentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\_ViewImports.cshtml"
using ETrade.Presentation.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8b1c1feee21abd636eb69ce2200f3ccbc7796a1", @"/Views/Shared/Components/OrderDetail/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d8c625f3851af6da9746d542beb70ccc20e2d4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_OrderDetail_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasketModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card border-secondary mb-5"">
    <div class=""card-header bg-secondary border-0"">
        <h4 class=""font-weight-semi-bold m-0"">Order Total</h4>
    </div>
    <div class=""card-body"">
        <h5 class=""font-weight-medium mb-3"">Products</h5>
");
#nullable restore
#line 8 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Shared\Components\OrderDetail\Default.cshtml"
         foreach (var item in Model.BasketProducts)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"d-flex justify-content-between\">\r\n                <p>");
#nullable restore
#line 11 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Shared\Components\OrderDetail\Default.cshtml"
              Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><p><b>");
#nullable restore
#line 11 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Shared\Components\OrderDetail\Default.cshtml"
                                          Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                <p>");
#nullable restore
#line 12 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Shared\Components\OrderDetail\Default.cshtml"
              Write(Html.Raw(item.Product.Price*item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 14 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Shared\Components\OrderDetail\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <hr class=\"mt-0\">\r\n        <div class=\"d-flex justify-content-between mb-3 pt-1\">\r\n            <h6 class=\"font-weight-medium\">Subtotal</h6>\r\n            <h6 class=\"font-weight-medium\">");
#nullable restore
#line 20 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Shared\Components\OrderDetail\Default.cshtml"
                                      Write(Html.Raw(Model.BasketProducts.Sum(x => x.Product.Price * x.Quantity).ToString("C")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
        </div>
        <div class=""d-flex justify-content-between"">
            <h6 class=""font-weight-medium"">Shipping</h6>
            <h6 class=""font-weight-medium"">$10</h6>
        </div>
    </div>
    <div class=""card-footer border-secondary bg-transparent"">
        <div class=""d-flex justify-content-between mt-2"">
            <h5 class=""font-weight-bold"">Total</h5>
            <h5 class=""font-weight-bold"">");
#nullable restore
#line 30 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Shared\Components\OrderDetail\Default.cshtml"
                                    Write(Html.Raw(Model.BasketProducts.Sum(x => x.Quantity * x.Product.Price) + 10));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketModel> Html { get; private set; }
    }
}
#pragma warning restore 1591