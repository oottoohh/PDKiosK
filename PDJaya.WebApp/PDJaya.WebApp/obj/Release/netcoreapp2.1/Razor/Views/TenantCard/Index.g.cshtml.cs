#pragma checksum "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4339a07106cde2b09dc72858097ef810fc9a9113"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TenantCard_Index), @"mvc.1.0.view", @"/Views/TenantCard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TenantCard/Index.cshtml", typeof(AspNetCore.Views_TenantCard_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4339a07106cde2b09dc72858097ef810fc9a9113", @"/Views/TenantCard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"728e3435fa095a64215a224bb1f7a2e9f415a6b5", @"/Views/_ViewImports.cshtml")]
    public class Views_TenantCard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PDJaya.WebApp.Models.TenantCard>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTenantCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
            BeginContext(95, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(138, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(167, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39f37f97d9c346118c2cbc02656758e9", async() => {
                BeginContext(200, 10, true);
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
            BeginContext(214, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(307, 38, false);
#line 20 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(345, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(401, 42, false);
#line 23 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CardID));

#line default
#line hidden
            EndContext();
            BeginContext(443, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(499, 43, false);
#line 26 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StoreNo));

#line default
#line hidden
            EndContext();
            BeginContext(542, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(598, 42, false);
#line 29 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CardNo));

#line default
#line hidden
            EndContext();
            BeginContext(640, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(696, 44, false);
#line 32 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CardType));

#line default
#line hidden
            EndContext();
            BeginContext(740, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(796, 42, false);
#line 35 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(838, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 41 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(973, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1034, 37, false);
#line 45 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1139, 41, false);
#line 48 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CardID));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1248, 42, false);
#line 51 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StoreNo));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1358, 41, false);
#line 54 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CardNo));

#line default
#line hidden
            EndContext();
            BeginContext(1399, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1467, 43, false);
#line 57 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CardType));

#line default
#line hidden
            EndContext();
            BeginContext(1510, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1578, 41, false);
#line 60 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1619, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1687, 48, false);
#line 63 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1735, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1760, 54, false);
#line 64 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1814, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1839, 52, false);
#line 65 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1891, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 68 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\TenantCard\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1946, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PDJaya.WebApp.Models.TenantCard>> Html { get; private set; }
    }
}
#pragma warning restore 1591
