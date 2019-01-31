#pragma checksum "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1a85fb804044433c6cff4167c8abcc27fa984ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_ProductDetail), @"mvc.1.0.view", @"/Views/Order/ProductDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/ProductDetail.cshtml", typeof(AspNetCore.Views_Order_ProductDetail))]
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
#line 1 "C:\folder1\dotnet\myEcomerce\Views\_ViewImports.cshtml"
using myEcomerce;

#line default
#line hidden
#line 2 "C:\folder1\dotnet\myEcomerce\Views\_ViewImports.cshtml"
using myEcomerce.Data;

#line default
#line hidden
#line 3 "C:\folder1\dotnet\myEcomerce\Views\_ViewImports.cshtml"
using myEcomerce.Models;

#line default
#line hidden
#line 4 "C:\folder1\dotnet\myEcomerce\Views\_ViewImports.cshtml"
using myEcomerce.Views.Shared;

#line default
#line hidden
#line 5 "C:\folder1\dotnet\myEcomerce\Views\_ViewImports.cshtml"
using myEcomerce.Controllers;

#line default
#line hidden
#line 6 "C:\folder1\dotnet\myEcomerce\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1a85fb804044433c6cff4167c8abcc27fa984ca", @"/Views/Order/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"309a90eeb946c77d3faaf0f40ec2cf5bffb2cc26", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
  
    ViewData["Title"] = "ProductDetail";
    Layout = "~/Views/Shared/_Layout.cshtml";
    int[] thumbnails = { 185, 6, 19, 46, 20 };
    Product product = ViewData["product"] as Product;
    Product[] products = ViewData["related"] as Product[];

#line default
#line hidden
            BeginContext(259, 10, true);
            WriteLiteral("\r\n\r\n\r\n<h2>");
            EndContext();
            BeginContext(270, 12, false);
#line 11 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
Write(product.name);

#line default
#line hidden
            EndContext();
            BeginContext(282, 184, true);
            WriteLiteral("</h2>\r\n<hr class=\"border-info border bg-info\">\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-5 border-bottom p-3\">\r\n            <img class=\"w-100 rounded\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 466, "\"", 511, 1);
#line 16 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
WriteAttributeValue("", 472, "/images/product/"+product.id+".jpg", 472, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(512, 83, true);
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"col-lg-4\">\r\n            <h3><span>USD</span>");
            EndContext();
            BeginContext(596, 13, false);
#line 19 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
                           Write(product.price);

#line default
#line hidden
            EndContext();
            BeginContext(609, 86, true);
            WriteLiteral("<span>.00</span></h3>\r\n            <hr class=\"bg-light\" />\r\n            <p>Condition: ");
            EndContext();
            BeginContext(696, 17, false);
#line 21 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
                     Write(product.condition);

#line default
#line hidden
            EndContext();
            BeginContext(713, 28, true);
            WriteLiteral("</p>\r\n            <p>Brand: ");
            EndContext();
            BeginContext(742, 13, false);
#line 22 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
                 Write(product.brand);

#line default
#line hidden
            EndContext();
            BeginContext(755, 29, true);
            WriteLiteral("</p>\r\n            <p>Weight: ");
            EndContext();
            BeginContext(785, 29, false);
#line 23 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
                  Write(product.ParseFeature().weight);

#line default
#line hidden
            EndContext();
            BeginContext(814, 32, true);
            WriteLiteral("</p>\r\n            <p>Dimension: ");
            EndContext();
            BeginContext(847, 33, false);
#line 24 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
                     Write(product.ParseFeature().dimensions);

#line default
#line hidden
            EndContext();
            BeginContext(880, 28, true);
            WriteLiteral("</p>\r\n            <p>Color: ");
            EndContext();
            BeginContext(909, 28, false);
#line 25 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
                 Write(product.ParseFeature().color);

#line default
#line hidden
            EndContext();
            BeginContext(937, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 26 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
             if (product.stock != 0)
            {

#line default
#line hidden
            BeginContext(996, 67, true);
            WriteLiteral("                <span class=\"badge badge-success\">In stock</span>\r\n");
            EndContext();
#line 29 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1111, 73, true);
            WriteLiteral("                <span class=\"badge badge-secondary\">Out of stock</span>\r\n");
            EndContext();
#line 33 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
            }

#line default
#line hidden
            BeginContext(1199, 141, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-lg-3\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    ");
            EndContext();
            BeginContext(1340, 1415, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45d1e67d06134b3793f45cb1bae60277", async() => {
                BeginContext(1346, 164, true);
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <label>Quantity</label>\r\n                            <select class=\"form-control\">\r\n");
                EndContext();
#line 42 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
                                 for (int i = 1; i < product.stock + 1; i++)
                                {

#line default
#line hidden
                BeginContext(1623, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(1659, 19, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "384a2cc4b9db44d58adebe658e1a4cc9", async() => {
                    BeginContext(1668, 1, false);
#line 44 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
                                       Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1678, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 45 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
                                }

#line default
#line hidden
                BeginContext(1715, 1033, true);
                WriteLiteral(@"                            </select>
                        </div>
                        <hr class=""bg-light"" />
                        <button type=""submit"" class=""btn btn-warning w-100"">
                            <span class=""oi oi-cart""></span>
                            Add to cart
                        </button>
                        <hr class=""bg-light"" />
                        <div>
                            <button type=""submit"" class=""btn btn-dark w-100"">
                                <i class=""fab fa-facebook""></i>
                                share on facebook
                            </button>
                        </div>
                        <div>
                            <br />
                            <button type=""submit"" class=""btn btn-info w-100"">
                                <i class=""fab fa-twitter""></i>
                                share on twitter
                            </button>
                        </div>
           ");
                WriteLiteral("         ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2755, 119, true);
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n    <br />\r\n    <div class=\"row\">\r\n\r\n");
            EndContext();
#line 79 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
         foreach (int i in thumbnails)
        {

#line default
#line hidden
            BeginContext(2925, 16, true);
            WriteLiteral("            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2941, "\"", 2981, 1);
#line 81 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
WriteAttributeValue("", 2947, "/images/product/"+i+"_h60.jpg", 2947, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2982, 26, true);
            WriteLiteral(" class=\"product-img-sm\">\r\n");
            EndContext();
#line 82 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
        }

#line default
#line hidden
            BeginContext(3019, 149, true);
            WriteLiteral("\r\n\r\n\r\n\r\n    </div>\r\n    <div class=\"py-3 text-primary\">\r\n        <h2>Description</h2>\r\n        <hr class=\"border border-info bg-info\" />\r\n        <p>");
            EndContext();
            BeginContext(3169, 19, false);
#line 91 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
      Write(product.description);

#line default
#line hidden
            EndContext();
            BeginContext(3188, 134, true);
            WriteLiteral("</p>\r\n    </div>\r\n\r\n    <div class=\"py-3 text-primary\">\r\n        <h2>Reviews</h2>\r\n        <hr class=\"border border-info bg-info\" />\r\n");
            EndContext();
#line 97 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
         for (int i = 0; i < 4; i++)
        {

#line default
#line hidden
            BeginContext(3371, 59, true);
            WriteLiteral("            <i class=\"fa fa-star\" aria-hidden=\"true\"></i>\r\n");
            EndContext();
#line 100 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
        }

#line default
#line hidden
            BeginContext(3441, 42, true);
            WriteLiteral("        <span>Good</span>\r\n        <span>-");
            EndContext();
            BeginContext(3484, 39, false);
#line 102 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
          Write(DateTime.Today.ToString("MMM dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3523, 173, true);
            WriteLiteral("</span>\r\n    </div>\r\n\r\n    <div class=\"py-3 text-primary\">\r\n        <h2>Related Products</h2>\r\n        <hr class=\"border border-info bg-info\" />\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 109 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
         for (int i = 0; i < 4; i++)
        {

#line default
#line hidden
            BeginContext(3743, 48, true);
            WriteLiteral("   <div class=\"col-md-3 col-sm-6\">\r\n            ");
            EndContext();
            BeginContext(3792, 59, false);
#line 111 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
       Write(await Html.PartialAsync("_ProductCardPartial", products[i]));

#line default
#line hidden
            EndContext();
            BeginContext(3851, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 113 "C:\folder1\dotnet\myEcomerce\Views\Order\ProductDetail.cshtml"
        }

#line default
#line hidden
            BeginContext(3884, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
