#pragma checksum "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\Images.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "303fc6a5d358ba65b1c6962b943dda9e43f0e826"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Images), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Images.cshtml")]
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
#line 1 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\Images.cshtml"
using ETrade.Presentation.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"303fc6a5d358ba65b1c6962b943dda9e43f0e826", @"/Areas/Admin/Views/Product/Images.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"423816c3c6021d1ad5943d40fda22aea51c30989", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Images : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductImageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\Images.cshtml"
   
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Product Image List</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""/admin/dashboard"">Home</a></li>
                        <li class=""breadcrumb-item active"">Product Image List</li>
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
            WriteLiteral(@"             <h3 class=""card-title"">Product Image List</h3>
                        </div>
                        <!-- /.card-header -->
                        <div class=""card-body"">
                            <table id=""example1"" class=""table table-bordered table-striped"">
                                <thead>
                                    <tr>
                                        <th>Image</th>                                     
                                        <th>Transactions</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 47 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\Images.cshtml"
                                     foreach (var item in Model.ProductImages)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n\r\n                                        <td><img");
            BeginWriteAttribute("src", " src=\"", 1994, "\"", 2020, 2);
            WriteAttributeValue("", 2000, "/products/", 2000, 10, true);
#nullable restore
#line 51 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\Images.cshtml"
WriteAttributeValue("", 2010, item.Name, 2010, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" /></td>\r\n                                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2089, "\"", 2138, 2);
            WriteAttributeValue("", 2096, "/admin/product/ProductImageDelete/", 2096, 34, true);
#nullable restore
#line 52 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\Images.cshtml"
WriteAttributeValue("", 2130, item.Id, 2130, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                                        | <a");
            BeginWriteAttribute("href", " href=\"", 2196, "\"", 2243, 2);
            WriteAttributeValue("", 2203, "/admin/product/ProductImageEdit/", 2203, 32, true);
#nullable restore
#line 53 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\Images.cshtml"
WriteAttributeValue("", 2235, item.Id, 2235, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></td> \r\n                                        \r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 57 "C:\Users\90545\Desktop\Bitirme_Projesi\ETrade.Presentation\ETrade.Presentation\Areas\Admin\Views\Product\Images.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                                <tfoot>
                                    <tr>
                                        <th>Image</th>
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
    <!-- /.content -->
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductImageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591