#pragma checksum "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd0a48db314784c0bd001da98f3c53a6b7fad39b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_ProductImageList), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/ProductImageList.cshtml")]
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
#line 1 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\_ViewImports.cshtml"
using ETrade.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\_ViewImports.cshtml"
using ETrade.Presentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
using ETrade.Presentation.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd0a48db314784c0bd001da98f3c53a6b7fad39b", @"/Areas/Admin/Views/Product/ProductImageList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"423816c3c6021d1ad5943d40fda22aea51c30989", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_ProductImageList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductImageList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Product Image Transactions</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""/admin/dashboard"">Home</a></li>
                        <li class=""breadcrumb-item active"">Product Image Transactions</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">

                    <!-- /.card -->

                    <div class=""card"">
                        <div class=""card-header"">
 ");
            WriteLiteral(@"                           <h3 class=""card-title"">Product Image List</h3>
                        </div>
                        <!-- /.card-header -->
                        <div class=""card-body"">
                            <table id=""example1"" class=""table table-bordered table-striped"">
                                <thead>
                                    <tr>

                                        <th>Id</th>
                                        <th>Image</th>
                                        <th>ProductId</th>
                                        <th>Name</th>
                                        <th>Sort</th>
                                        <th>Status</th>
                                        <th>AltText</th>
                                        <th>Transactions</th>
                                        
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 55 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                     foreach (var item in Model.List)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n");
#nullable restore
#line 58 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                         if (Model.List.Any(x => x.Id == item.Id))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>");
#nullable restore
#line 60 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><img width=\"150\"");
            BeginWriteAttribute("src", " src=\"", 2544, "\"", 2610, 2);
            WriteAttributeValue("", 2550, "/products/", 2550, 10, true);
#nullable restore
#line 61 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
WriteAttributeValue("", 2560, Model.List.FirstOrDefault(x=>x.Id ==item.Id).Name, 2560, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                                            <td>");
#nullable restore
#line 62 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                           Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 63 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 64 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                           Write(item.Sort);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 65 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 66 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                           Write(item.AltText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                            <td>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 3058, "\"", 3107, 2);
            WriteAttributeValue("", 3065, "/admin/product/ProductImageDelete/", 3065, 34, true);
#nullable restore
#line 69 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
WriteAttributeValue("", 3099, item.Id, 3099, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a> |\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 3173, "\"", 3220, 2);
            WriteAttributeValue("", 3180, "/admin/product/ProductImageEdit/", 3180, 32, true);
#nullable restore
#line 70 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
WriteAttributeValue("", 3212, item.Id, 3212, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                                                \r\n                                            </td>\r\n");
#nullable restore
#line 73 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>");
#nullable restore
#line 76 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><img width=\"150\"");
            BeginWriteAttribute("src", " src=\"", 3594, "\"", 3600, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                                            <td>");
#nullable restore
#line 78 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                           Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 79 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 80 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                           Write(item.Sort);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 81 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 82 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                           Write(item.AltText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                            <td>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4048, "\"", 4097, 2);
            WriteAttributeValue("", 4055, "/admin/product/ProductImageDelete/", 4055, 34, true);
#nullable restore
#line 85 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
WriteAttributeValue("", 4089, item.Id, 4089, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a> |\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4163, "\"", 4210, 2);
            WriteAttributeValue("", 4170, "/admin/product/ProductImageEdit/", 4170, 32, true);
#nullable restore
#line 86 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
WriteAttributeValue("", 4202, item.Id, 4202, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                                                \r\n                                            </td>\r\n");
#nullable restore
#line 89 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 93 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\ProductImageList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                                <tfoot>
                                    <tr>
                                        <th>Id</th>
                                        <th>Image</th>
                                        <th>ProductId</th>
                                        <th>Name</th>
                                        <th>Sort</th>
                                        <th>Status</th>
                                        <th>AltText</th>
                                        <th>Transactions</th>
                                    </tr>
                                </tfoot>
                            </table>
                        </div>
                        <!-- /.card-body -->
                    </div>
                    <!-- /.card -->
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </section>
    ");
            WriteLiteral("<!-- /.content -->\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductImageList> Html { get; private set; }
    }
}
#pragma warning restore 1591
