#pragma checksum "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f54ae14a0d0faebd338c79e4251cc072a9cc91b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineers_Index), @"mvc.1.0.view", @"/Views/Engineers/Index.cshtml")]
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
#line 5 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\Index.cshtml"
using Factory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f54ae14a0d0faebd338c79e4251cc072a9cc91b8", @"/Views/Engineers/Index.cshtml")]
    #nullable restore
    public class Views_Engineers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Factory.Models.Engineer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Engineers</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No engineers have been added yet!</h3>\r\n");
#nullable restore
#line 13 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\Index.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 16 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\Index.cshtml"
   foreach(Engineer engineer in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 18 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\Index.cshtml"
   Write(Html.ActionLink($"{engineer.Name}", "Details", new { id = engineer.EngineerId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 19 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<p>");
#nullable restore
#line 22 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\Index.cshtml"
Write(Html.ActionLink("Add new engineer", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 23 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Factory.Models.Engineer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
