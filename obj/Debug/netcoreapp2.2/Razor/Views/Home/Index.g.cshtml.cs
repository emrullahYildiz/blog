#pragma checksum "C:\Users\hasan\Desktop\simpleBlog\blog\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b97427c6536f3dd1e4ea66406dc9fee1ebf57a78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b97427c6536f3dd1e4ea66406dc9fee1ebf57a78", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb75ca75589086f3cd7b7a5e09e52e9d3c84d752", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\hasan\Desktop\simpleBlog\blog\Views\Home\Index.cshtml"
  
    Layout = "_LayoutMain";
    ViewData["pageTitle"]="Anasayfa";

#line default
#line hidden
            BeginContext(97, 94, true);
            WriteLiteral("<div class=\"container mt-2 mb-5 container-background border rounded\">\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 8 "C:\Users\hasan\Desktop\simpleBlog\blog\Views\Home\Index.cshtml"
         foreach (var item in Model.articles)
        {
            

#line default
#line hidden
            BeginContext(262, 50, false);
#line 10 "C:\Users\hasan\Desktop\simpleBlog\blog\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("ArticlePreview",item));

#line default
#line hidden
            EndContext();
#line 10 "C:\Users\hasan\Desktop\simpleBlog\blog\Views\Home\Index.cshtml"
                                                               
        }

#line default
#line hidden
            BeginContext(325, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(346, 66, false);
#line 14 "C:\Users\hasan\Desktop\simpleBlog\blog\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Pagination",@Model.currentPageNumber));

#line default
#line hidden
            EndContext();
            BeginContext(412, 1, true);
            WriteLiteral(";");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
