#pragma checksum "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\AddMachine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "585f731eae0d50f86a63fd165b91b63d0e7743fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineers_AddMachine), @"mvc.1.0.view", @"/Views/Engineers/AddMachine.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"585f731eae0d50f86a63fd165b91b63d0e7743fa", @"/Views/Engineers/AddMachine.cshtml")]
    #nullable restore
    public class Views_Engineers_AddMachine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Engineer>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\AddMachine.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h4>Add a machine to this engineer: ");
#nullable restore
#line 7 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\AddMachine.cshtml"
                               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\AddMachine.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\AddMachine.cshtml"
Write(Html.HiddenFor(model => model.EngineerId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\AddMachine.cshtml"
Write(Html.Label("Select machine"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\AddMachine.cshtml"
Write(Html.DropDownList("MachineId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\r\n");
#nullable restore
#line 17 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\AddMachine.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 19 "C:\Users\zwein\epicodus\c#\Factory\Views\Engineers\AddMachine.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Engineer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
