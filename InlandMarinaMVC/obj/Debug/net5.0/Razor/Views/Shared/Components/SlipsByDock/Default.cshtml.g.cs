#pragma checksum "C:\Users\BibBibsRig\source\repos\InlandMarinaWebApp\InlandMarinaMVC\Views\Shared\Components\SlipsByDock\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b4f7161d9911d30d0ebaa381d4dfd9dde46a7de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SlipsByDock_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SlipsByDock/Default.cshtml")]
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
#line 1 "C:\Users\BibBibsRig\source\repos\InlandMarinaWebApp\InlandMarinaMVC\Views\_ViewImports.cshtml"
using InlandMarinaMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BibBibsRig\source\repos\InlandMarinaWebApp\InlandMarinaMVC\Views\_ViewImports.cshtml"
using InlandMarinaMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b4f7161d9911d30d0ebaa381d4dfd9dde46a7de", @"/Views/Shared/Components/SlipsByDock/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fef231f29a414e6bcf915f5743de44a710e5e4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SlipsByDock_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InlandMarinaData.Slip>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\BibBibsRig\source\repos\InlandMarinaWebApp\InlandMarinaMVC\Views\Shared\Components\SlipsByDock\Default.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1></h1>\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\BibBibsRig\source\repos\InlandMarinaWebApp\InlandMarinaMVC\Views\Shared\Components\SlipsByDock\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\BibBibsRig\source\repos\InlandMarinaWebApp\InlandMarinaMVC\Views\Shared\Components\SlipsByDock\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\BibBibsRig\source\repos\InlandMarinaWebApp\InlandMarinaMVC\Views\Shared\Components\SlipsByDock\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Length));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\BibBibsRig\source\repos\InlandMarinaWebApp\InlandMarinaMVC\Views\Shared\Components\SlipsByDock\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.DockID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n            </th>\r\n</thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\BibBibsRig\source\repos\InlandMarinaWebApp\InlandMarinaMVC\Views\Shared\Components\SlipsByDock\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\BibBibsRig\source\repos\InlandMarinaWebApp\InlandMarinaMVC\Views\Shared\Components\SlipsByDock\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\BibBibsRig\source\repos\InlandMarinaWebApp\InlandMarinaMVC\Views\Shared\Components\SlipsByDock\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\BibBibsRig\source\repos\InlandMarinaWebApp\InlandMarinaMVC\Views\Shared\Components\SlipsByDock\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Length));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\BibBibsRig\source\repos\InlandMarinaWebApp\InlandMarinaMVC\Views\Shared\Components\SlipsByDock\Default.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dock.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 43 "C:\Users\BibBibsRig\source\repos\InlandMarinaWebApp\InlandMarinaMVC\Views\Shared\Components\SlipsByDock\Default.cshtml"
           Write(Html.ActionLink("Lease this slip", "Create", "Lease", new { slipID = item.ID, dockID = item.DockID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n            <tr>\r\n            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\BibBibsRig\source\repos\InlandMarinaWebApp\InlandMarinaMVC\Views\Shared\Components\SlipsByDock\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InlandMarinaData.Slip>> Html { get; private set; }
    }
}
#pragma warning restore 1591
