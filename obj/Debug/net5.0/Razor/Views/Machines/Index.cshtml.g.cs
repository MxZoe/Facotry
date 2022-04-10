#pragma checksum "C:\Users\zwein\epicodus\c#\Factory\Views\Machines\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25d56882a537355195fafaa9b52f65ca2c9ff77a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Machines_Index), @"mvc.1.0.view", @"/Views/Machines/Index.cshtml")]
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
#line 5 "C:\Users\zwein\epicodus\c#\Factory\Views\Machines\Index.cshtml"
using Factory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d56882a537355195fafaa9b52f65ca2c9ff77a", @"/Views/Machines/Index.cshtml")]
    #nullable restore
    public class Views_Machines_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Factory.Models.Machine>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\zwein\epicodus\c#\Factory\Views\Machines\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Machines</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\zwein\epicodus\c#\Factory\Views\Machines\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No machines have been added yet!</h3>\r\n");
#nullable restore
#line 13 "C:\Users\zwein\epicodus\c#\Factory\Views\Machines\Index.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\zwein\epicodus\c#\Factory\Views\Machines\Index.cshtml"
 foreach (Machine machine in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <li>");
#nullable restore
#line 17 "C:\Users\zwein\epicodus\c#\Factory\Views\Machines\Index.cshtml"
 Write(Html.ActionLink($"{machine.Description}", "Details", new { id = machine.MachineId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 18 "C:\Users\zwein\epicodus\c#\Factory\Views\Machines\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 20 "C:\Users\zwein\epicodus\c#\Factory\Views\Machines\Index.cshtml"
Write(Html.ActionLink("Add new machine", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 21 "C:\Users\zwein\epicodus\c#\Factory\Views\Machines\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Factory.Models.Machine>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
