#pragma checksum "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b87ca1ae699ce968b05a736cb9959568495f4f14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bills_Details), @"mvc.1.0.view", @"/Views/Bills/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bills/Details.cshtml", typeof(AspNetCore.Views_Bills_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b87ca1ae699ce968b05a736cb9959568495f4f14", @"/Views/Bills/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"728e3435fa095a64215a224bb1f7a2e9f415a6b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Bills_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PDJaya.WebApp.Models.Bills>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(109, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53578b5b1688493782f44eb54e2e24c6", async() => {
                BeginContext(115, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(211, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(213, 2014, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1368a37ed0f241a2b6890f675e494ad5", async() => {
                BeginContext(219, 125, true);
                WriteLiteral("\r\n\r\n    <div>\r\n        <h4>Bills</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(345, 38, false);
#line 21 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(383, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(439, 34, false);
#line 24 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(473, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(529, 42, false);
#line 27 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.BillID));

#line default
#line hidden
                EndContext();
                BeginContext(571, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(627, 38, false);
#line 30 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayFor(model => model.BillID));

#line default
#line hidden
                EndContext();
                BeginContext(665, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(721, 44, false);
#line 33 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.MarketNo));

#line default
#line hidden
                EndContext();
                BeginContext(765, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(821, 40, false);
#line 36 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayFor(model => model.MarketNo));

#line default
#line hidden
                EndContext();
                BeginContext(861, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(917, 43, false);
#line 39 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.StoreNo));

#line default
#line hidden
                EndContext();
                BeginContext(960, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1016, 39, false);
#line 42 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayFor(model => model.StoreNo));

#line default
#line hidden
                EndContext();
                BeginContext(1055, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1111, 51, false);
#line 45 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.TransactionCode));

#line default
#line hidden
                EndContext();
                BeginContext(1162, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1218, 47, false);
#line 48 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayFor(model => model.TransactionCode));

#line default
#line hidden
                EndContext();
                BeginContext(1265, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1321, 42, false);
#line 51 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
                EndContext();
                BeginContext(1363, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1419, 38, false);
#line 54 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
                EndContext();
                BeginContext(1457, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1513, 47, false);
#line 57 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
                EndContext();
                BeginContext(1560, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1616, 43, false);
#line 60 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
                EndContext();
                BeginContext(1659, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1715, 41, false);
#line 63 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Month));

#line default
#line hidden
                EndContext();
                BeginContext(1756, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1812, 37, false);
#line 66 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayFor(model => model.Month));

#line default
#line hidden
                EndContext();
                BeginContext(1849, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1905, 40, false);
#line 69 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
                EndContext();
                BeginContext(1945, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(2001, 36, false);
#line 72 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
           Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
                EndContext();
                BeginContext(2037, 67, true);
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(2105, 51, false);
#line 77 "C:\Users\ASUS\source\repos\PDJaya.WebApp\PDJaya.WebApp\Views\Bills\Details.cshtml"
   Write(Html.ActionLink("Edit", "Edit", new { id = Model }));

#line default
#line hidden
                EndContext();
                BeginContext(2156, 12, true);
                WriteLiteral(" |\r\n        ");
                EndContext();
                BeginContext(2168, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c630f1acf2a5465490d346943969c849", async() => {
                    BeginContext(2190, 12, true);
                    WriteLiteral("Back to List");
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
                BeginContext(2206, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2227, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PDJaya.WebApp.Models.Bills> Html { get; private set; }
    }
}
#pragma warning restore 1591
