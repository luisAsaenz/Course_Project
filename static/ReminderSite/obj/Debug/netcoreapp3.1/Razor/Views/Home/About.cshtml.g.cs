#pragma checksum "C:\Users\LuisA\OneDrive\Desktop\Course_Project\static\ReminderSite\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a1d794361ad161d59e7d6f7ad0cdbf4e9687801"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Users\LuisA\OneDrive\Desktop\Course_Project\static\ReminderSite\Views\_ViewImports.cshtml"
using ReminderSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LuisA\OneDrive\Desktop\Course_Project\static\ReminderSite\Views\_ViewImports.cshtml"
using ReminderSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a1d794361ad161d59e7d6f7ad0cdbf4e9687801", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf1cc00babd0d6410208c8e6fe04aa1ae412d1c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LuisA\OneDrive\Desktop\Course_Project\static\ReminderSite\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    h1{\r\n        color: white;\r\n    }\r\n    p{\r\n        color: white;\r\n    }\r\n</style>\r\n<h1>");
#nullable restore
#line 12 "C:\Users\LuisA\OneDrive\Desktop\Course_Project\static\ReminderSite\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Click<a href=\"UserStuff\"> here</a> to see the repository</p>\r\n");
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
