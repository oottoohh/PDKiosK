#pragma checksum "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "369c36b387989d78ed2f50748b135cd8a8fa0d39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserProfile_Index), @"mvc.1.0.view", @"/Views/UserProfile/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserProfile/Index.cshtml", typeof(AspNetCore.Views_UserProfile_Index))]
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
#line 1 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\_ViewImports.cshtml"
using PDJaya.WebApp;

#line default
#line hidden
#line 2 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\_ViewImports.cshtml"
using PDJaya.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"369c36b387989d78ed2f50748b135cd8a8fa0d39", @"/Views/UserProfile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"728e3435fa095a64215a224bb1f7a2e9f415a6b5", @"/Views/_ViewImports.cshtml")]
    public class Views_UserProfile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PDJaya.WebApp.Models.UserProfile>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(96, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
  
    ViewData["Title"] = "UserProfile";

#line default
#line hidden
            BeginContext(147, 35, true);
            WriteLiteral("\r\n<h2>UserProfile</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(182, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0069215111ad492d8a3f4f1bed60acb9", async() => {
                BeginContext(205, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(219, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(312, 45, false);
#line 21 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(357, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(413, 45, false);
#line 24 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(458, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(514, 43, false);
#line 27 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Created));

#line default
#line hidden
            EndContext();
            BeginContext(557, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(613, 43, false);
#line 30 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Updated));

#line default
#line hidden
            EndContext();
            BeginContext(656, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(712, 42, false);
#line 33 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(754, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(810, 44, false);
#line 36 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(854, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(910, 44, false);
#line 39 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(954, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1010, 44, false);
#line 42 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1110, 46, false);
#line 45 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1212, 42, false);
#line 48 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Branch));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1310, 44, false);
#line 51 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(1354, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1410, 45, false);
#line 54 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(1455, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1511, 44, false);
#line 57 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(1555, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1611, 41, false);
#line 60 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1708, 40, false);
#line 63 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Role));

#line default
#line hidden
            EndContext();
            BeginContext(1748, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1804, 41, false);
#line 66 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1845, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 72 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1980, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2041, 44, false);
#line 76 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2085, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2153, 44, false);
#line 79 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UpdatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2197, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2265, 42, false);
#line 82 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Created));

#line default
#line hidden
            EndContext();
            BeginContext(2307, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2375, 42, false);
#line 85 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Updated));

#line default
#line hidden
            EndContext();
            BeginContext(2417, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2485, 37, false);
#line 88 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2522, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2590, 41, false);
#line 91 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(2631, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2699, 43, false);
#line 94 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(2742, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2810, 43, false);
#line 97 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(2853, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2921, 43, false);
#line 100 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2964, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3032, 45, false);
#line 103 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
            EndContext();
            BeginContext(3077, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3145, 41, false);
#line 106 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Branch));

#line default
#line hidden
            EndContext();
            BeginContext(3186, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3254, 43, false);
#line 109 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(3297, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3365, 44, false);
#line 112 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(3409, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3477, 43, false);
#line 115 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(3520, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3588, 40, false);
#line 118 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3628, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3696, 39, false);
#line 121 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Role));

#line default
#line hidden
            EndContext();
            BeginContext(3735, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3803, 40, false);
#line 124 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(3843, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3911, 48, false);
#line 127 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(3959, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(3984, 54, false);
#line 128 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(4038, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(4063, 52, false);
#line 129 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(4115, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 132 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\UserProfile\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(4170, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PDJaya.WebApp.Models.UserProfile>> Html { get; private set; }
    }
}
#pragma warning restore 1591
