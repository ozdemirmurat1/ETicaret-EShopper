#pragma checksum "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Like\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "332a96e4eb2c1346bb10d5c4b428b6a624640415"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Like_Index), @"mvc.1.0.view", @"/Views/Like/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"332a96e4eb2c1346bb10d5c4b428b6a624640415", @"/Views/Like/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d8c625f3851af6da9746d542beb70ccc20e2d4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Like_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LikeIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Like\Index.cshtml"
   
    Layout = "_LikeLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<!-- Page Header Start -->
<div class=""container-fluid bg-secondary mb-5"">
    <div class=""d-flex flex-column align-items-center justify-content-center"" style=""min-height: 300px"">
        <h1 class=""font-weight-semi-bold text-uppercase mb-3"">Favorite Products</h1>
        <div class=""d-inline-flex"">
            <p class=""m-0"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "332a96e4eb2c1346bb10d5c4b428b6a6246404154588", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</p>
            <p class=""m-0 px-2"">-</p>
            <p class=""m-0"">Favorite Products</p>
        </div>
    </div>
</div>
<!-- Page Header End -->
<!-- Cart Start -->
<div class=""container-fluid pt-5"">
    <div class=""row px-xl-5"">
        <div class=""col-lg-8 table-responsive mb-5"">
            <table class=""table table-bordered text-center mb-0"">
                <thead class=""bg-secondary text-dark"">
                    <tr>
                        <th>Products</th>
                        <th>Price</th>
                        <th>Quantity</th>
                        <th>Total</th>
                        <th>Remove</th>
                    </tr>
                </thead>
                <tbody class=""align-middle"">
");
#nullable restore
#line 34 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Like\Index.cshtml"
                     foreach (var item in Model.Like.LikeProducts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"align-middle\"><img");
            BeginWriteAttribute("src", " src=\"", 1385, "\"", 1412, 2);
            WriteAttributeValue("", 1391, "/products/", 1391, 10, true);
#nullable restore
#line 37 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Like\Index.cshtml"
WriteAttributeValue("", 1401, item.Image, 1401, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1413, "\"", 1419, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 50px;\"><a");
            BeginWriteAttribute("href", " href=\"", 1444, "\"", 1478, 2);
            WriteAttributeValue("", 1451, "/urun/", 1451, 6, true);
#nullable restore
#line 37 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Like\Index.cshtml"
WriteAttributeValue("", 1457, item.Product.SeoName, 1457, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:black\">");
#nullable restore
#line 37 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Like\Index.cshtml"
                                                                                                                                                                       Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                            <td class=\"align-middle\">");
#nullable restore
#line 38 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Like\Index.cshtml"
                                                Write(item.Product.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td class=""align-middle"">
                                <div class=""input-group quantity mx-auto"" style=""width: 100px;"">
                                    <div class=""input-group-btn"">
                                        <button class=""btn btn-sm btn-primary btn-minus""");
            BeginWriteAttribute("onclick", " onclick=\"", 1930, "\"", 1988, 5);
            WriteAttributeValue("", 1940, "window.location", 1940, 15, true);
            WriteAttributeValue(" ", 1955, "=", 1956, 2, true);
            WriteAttributeValue(" ", 1957, "\'/like/minus/", 1958, 14, true);
#nullable restore
#line 42 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Like\Index.cshtml"
WriteAttributeValue("", 1971, item.ProductId, 1971, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1986, "\';", 1986, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                            <i class=""fa fa-minus""></i>
                                        </button>
                                    </div>
                                    <input type=""text"" class=""form-control form-control-sm bg-secondary text-center""");
            BeginWriteAttribute("value", " value=\"", 2276, "\"", 2298, 1);
#nullable restore
#line 46 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Like\Index.cshtml"
WriteAttributeValue("", 2284, item.Quantity, 2284, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"0\" step=\"1\">\r\n                                    <div class=\"input-group-btn\">\r\n                                        <button class=\"btn btn-sm btn-primary btn-plus\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2473, "\"", 2530, 5);
            WriteAttributeValue("", 2483, "window.location", 2483, 15, true);
            WriteAttributeValue(" ", 2498, "=", 2499, 2, true);
            WriteAttributeValue(" ", 2500, "\'/like/plus/", 2501, 13, true);
#nullable restore
#line 48 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Like\Index.cshtml"
WriteAttributeValue("", 2513, item.ProductId, 2513, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2528, "\';", 2528, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                            <i class=""fa fa-plus""></i>
                                        </button>
                                    </div>
                                </div>
                            </td>
                            <td class=""align-middle"">");
#nullable restore
#line 54 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Like\Index.cshtml"
                                                Write(Html.Raw(item.Quantity * item.Product.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"align-middle\"><button class=\"btn btn-sm btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2972, "\"", 3037, 5);
            WriteAttributeValue("", 2982, "window.location", 2982, 15, true);
            WriteAttributeValue(" ", 2997, "=", 2998, 2, true);
            WriteAttributeValue(" ", 2999, "\'/like/RemoveProduct/", 3000, 22, true);
#nullable restore
#line 55 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Like\Index.cshtml"
WriteAttributeValue("", 3021, item.ProductId, 3021, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3036, "\'", 3036, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-times\"></i></button></td>\r\n                        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Like\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </tbody>
            </table>
        </div>
        <div class=""col-lg-4"">            
            <div class=""card border-secondary mb-5"">
                <div class=""card-header bg-secondary border-0"">
                    <h4 class=""font-weight-semi-bold m-0"">Cart Summary</h4>
                </div>
                <div class=""card-body"">
                    <div class=""d-flex justify-content-between mb-3 pt-1"">
                        <h6 class=""font-weight-medium"">Subtotal</h6>
                        <h6 class=""font-weight-medium"">");
#nullable restore
#line 71 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Like\Index.cshtml"
                                                  Write(Html.Raw(Model.Like.LikeProducts.Sum(x => x.Quantity * x.Product.Price)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                    </div>
                    
                </div>
                <div class=""card-footer border-secondary bg-transparent"">
                    <div class=""d-flex justify-content-between mt-2"">
                        <h5 class=""font-weight-bold"">Total</h5>
                        <h5 class=""font-weight-bold"">");
#nullable restore
#line 78 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Views\Like\Index.cshtml"
                                                Write(Html.Raw(Model.Like.LikeProducts.Sum(x => x.Quantity * x.Product.Price)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Cart End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LikeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
