#pragma checksum "C:\Users\LuisA\Downloads\Course_Project\Course_Project-master\static\ReminderSite\Views\Home\UserStuff.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd20421436e2db6126ee71cddb2b2bdd9af33d2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserStuff), @"mvc.1.0.view", @"/Views/Home/UserStuff.cshtml")]
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
#line 1 "C:\Users\LuisA\Downloads\Course_Project\Course_Project-master\static\ReminderSite\Views\_ViewImports.cshtml"
using ReminderSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LuisA\Downloads\Course_Project\Course_Project-master\static\ReminderSite\Views\_ViewImports.cshtml"
using ReminderSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd20421436e2db6126ee71cddb2b2bdd9af33d2e", @"/Views/Home/UserStuff.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf1cc00babd0d6410208c8e6fe04aa1ae412d1c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserStuff : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReminderSite.Models.UserInfo>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LuisA\Downloads\Course_Project\Course_Project-master\static\ReminderSite\Views\Home\UserStuff.cshtml"
  
    ViewData["title"] = "UserInfo";
    Layout = null;
 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd20421436e2db6126ee71cddb2b2bdd9af33d2e3665", async() => {
                WriteLiteral("\r\n\r\n    <title>UserInfo</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd20421436e2db6126ee71cddb2b2bdd9af33d2e4666", async() => {
                WriteLiteral(@"
    <h2>Here is the list of registeers</h2>
    <table>
        <thead>
            <tr>
                <th>FirstName</th>
                <th>LastName</th>
                <th>UserName</th>
                <th>Email</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 25 "C:\Users\LuisA\Downloads\Course_Project\Course_Project-master\static\ReminderSite\Views\Home\UserStuff.cshtml"
             foreach (var r in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\LuisA\Downloads\Course_Project\Course_Project-master\static\ReminderSite\Views\Home\UserStuff.cshtml"
                   Write(Html.DisplayFor(modelItem => r.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\LuisA\Downloads\Course_Project\Course_Project-master\static\ReminderSite\Views\Home\UserStuff.cshtml"
                   Write(Html.DisplayFor(modelItem => r.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\LuisA\Downloads\Course_Project\Course_Project-master\static\ReminderSite\Views\Home\UserStuff.cshtml"
                   Write(Html.DisplayFor(modelItem => r.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\LuisA\Downloads\Course_Project\Course_Project-master\static\ReminderSite\Views\Home\UserStuff.cshtml"
                   Write(Html.DisplayFor(modelItem => r.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 34 "C:\Users\LuisA\Downloads\Course_Project\Course_Project-master\static\ReminderSite\Views\Home\UserStuff.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReminderSite.Models.UserInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
