#pragma checksum "C:\Users\hasan\Desktop\simpleBlog\blog\Views\Admin\Panel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4afe885bbbb4b48cda2b7abd48e1be245ab9bce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Panel), @"mvc.1.0.view", @"/Views/Admin/Panel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Panel.cshtml", typeof(AspNetCore.Views_Admin_Panel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4afe885bbbb4b48cda2b7abd48e1be245ab9bce", @"/Views/Admin/Panel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb75ca75589086f3cd7b7a5e09e52e9d3c84d752", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Panel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\hasan\Desktop\simpleBlog\blog\Views\Admin\Panel.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
            BeginContext(37, 31, true);
            WriteLiteral("\r\n<div class=\"row h-100\">\r\n    ");
            EndContext();
            BeginContext(69, 43, false);
#line 6 "C:\Users\hasan\Desktop\simpleBlog\blog\Views\Admin\Panel.cshtml"
Write(await Component.InvokeAsync("AdminSidebar"));

#line default
#line hidden
            EndContext();
            BeginContext(112, 99, true);
            WriteLiteral("\r\n    <div class=\"col-7 col-sm-8 col-md-9 col-lg-10\">\r\n        <p>asjkdajks</p>\r\n    </div>\r\n</div>");
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
