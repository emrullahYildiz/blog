#pragma checksum "C:\Users\hasan\Desktop\simpleBlog\blog\Views\Shared\Components\AdminSidebar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "250aee6a7f468a6515cc24b12fefb2897a855b24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AdminSidebar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AdminSidebar/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/AdminSidebar/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_AdminSidebar_Default))]
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
#line 1 "C:\Users\hasan\Desktop\simpleBlog\blog\Views\_ViewImports.cshtml"
using blog;

#line default
#line hidden
#line 2 "C:\Users\hasan\Desktop\simpleBlog\blog\Views\_ViewImports.cshtml"
using blog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"250aee6a7f468a6515cc24b12fefb2897a855b24", @"/Views/Shared/Components/AdminSidebar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb75ca75589086f3cd7b7a5e09e52e9d3c84d752", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AdminSidebar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 770, true);
            WriteLiteral(@"    <div class=""col-5 col-sm-4 col-md-3 col-lg-2 bg-secondary"">
        <ul class=""nav flex-column"">
            <li class=""nav-item"">
                <a class=""btn btn-primary w-100 my-1 ml-1"" role=""button w-100"" href=""#"">Makaleler</a>
            </li>
            <li class=""nav-item"">
                <a class=""btn btn-primary w-100 my-1 ml-1"" role=""button w-100"" href=""/Admin/Comments"">Yorumlar</a>
            </li>
            <li class=""nav-item"">
                <a class=""btn btn-primary w-100 my-1 ml-1"" role=""button w-100"" href=""#"">Mesajlar</a>
            </li>
            <li class=""nav-item"">
                <a class=""btn btn-primary w-100 my-1 ml-1"" role=""button w-100"" href=""#"">Kategoriler</a>
            </li>
        </ul>
    </div>");
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
