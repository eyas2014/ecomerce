#pragma checksum "C:\folder1\dotnet\myEcomerce\Views\Shared\_OneLineFormcontrol.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5568762e75fc90f518d5ffa86e74e1a4b4e5172"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__OneLineFormcontrol), @"mvc.1.0.view", @"/Views/Shared/_OneLineFormcontrol.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_OneLineFormcontrol.cshtml", typeof(AspNetCore.Views_Shared__OneLineFormcontrol))]
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
#line 2 "C:\folder1\dotnet\myEcomerce\Views\Shared\_OneLineFormcontrol.cshtml"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5568762e75fc90f518d5ffa86e74e1a4b4e5172", @"/Views/Shared/_OneLineFormcontrol.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"309a90eeb946c77d3faaf0f40ec2cf5bffb2cc26", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__OneLineFormcontrol : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OneLineFormcontrol>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 142, true);
            WriteLiteral("\r\n<div class=\"form-group\">\r\n    <div class=\"input-group input-group-sm\">\r\n        <div class=\"col-md-4\">\r\n        <label for=\"user_firstname\">");
            EndContext();
            BeginContext(204, 11, false);
#line 7 "C:\folder1\dotnet\myEcomerce\Views\Shared\_OneLineFormcontrol.cshtml"
                               Write(Model.label);

#line default
#line hidden
            EndContext();
            BeginContext(215, 27, true);
            WriteLiteral("</label>:\r\n        </div>\r\n");
            EndContext();
#line 9 "C:\folder1\dotnet\myEcomerce\Views\Shared\_OneLineFormcontrol.cshtml"
         if (Model.icon != null)
        {

#line default
#line hidden
            BeginContext(287, 149, true);
            WriteLiteral("            <div class=\"input-group-prepend ml-2\">\r\n                <div class=\"input-group-text text-white  border border-secondary bg-secondary\">\r\n");
            EndContext();
#line 13 "C:\folder1\dotnet\myEcomerce\Views\Shared\_OneLineFormcontrol.cshtml"
                     if (Model.icon.Substring(0, 2) == "oi")
                    {

#line default
#line hidden
            BeginContext(521, 30, true);
            WriteLiteral("                        <small");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 551, "\"", 570, 1);
#line 15 "C:\folder1\dotnet\myEcomerce\Views\Shared\_OneLineFormcontrol.cshtml"
WriteAttributeValue("", 559, Model.icon, 559, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(571, 11, true);
            WriteLiteral("></small>\r\n");
            EndContext();
#line 16 "C:\folder1\dotnet\myEcomerce\Views\Shared\_OneLineFormcontrol.cshtml"
                    }
                    else if (Model.icon.Substring(0, 2) == "fa")
                    {

#line default
#line hidden
            BeginContext(694, 26, true);
            WriteLiteral("                        <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 720, "\"", 739, 1);
#line 19 "C:\folder1\dotnet\myEcomerce\Views\Shared\_OneLineFormcontrol.cshtml"
WriteAttributeValue("", 728, Model.icon, 728, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(740, 7, true);
            WriteLiteral("></i>\r\n");
            EndContext();
#line 20 "C:\folder1\dotnet\myEcomerce\Views\Shared\_OneLineFormcontrol.cshtml"
                    }

#line default
#line hidden
            BeginContext(770, 44, true);
            WriteLiteral("                </div>\r\n            </div>\r\n");
            EndContext();
#line 23 "C:\folder1\dotnet\myEcomerce\Views\Shared\_OneLineFormcontrol.cshtml"
        }

#line default
#line hidden
            BeginContext(825, 71, true);
            WriteLiteral("        <input type=\"text\" class=\"form-control border border-secondary\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 896, "\"", 914, 1);
#line 24 "C:\folder1\dotnet\myEcomerce\Views\Shared\_OneLineFormcontrol.cshtml"
WriteAttributeValue("", 903, Model.name, 903, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(915, 25, true);
            WriteLiteral(">\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OneLineFormcontrol> Html { get; private set; }
    }
}
#pragma warning restore 1591
