#pragma checksum "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ContactUs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d96000c52b14eab31ca61f8d44bce31b726f239"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContactUs_Index), @"mvc.1.0.view", @"/Views/ContactUs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ContactUs/Index.cshtml", typeof(AspNetCore.Views_ContactUs_Index))]
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
#line 1 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\_ViewImports.cshtml"
using MarketWeb;

#line default
#line hidden
#line 2 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\_ViewImports.cshtml"
using MarketWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d96000c52b14eab31ca61f8d44bce31b726f239", @"/Views/ContactUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d030c069520c706fca90803c1839df023169deab", @"/Views/_ViewImports.cshtml")]
    public class Views_ContactUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MarketWeb.Models.ViewModels.ContactUs>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ContactUs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19e4decc8e9c48a6be1914bbc3389b27", async() => {
                BeginContext(154, 10, true);
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
            BeginContext(168, 100, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(269, 41, false);
#line 16 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ContactUs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Names));

#line default
#line hidden
            EndContext();
            BeginContext(310, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(378, 42, false);
#line 19 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ContactUs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Emails));

#line default
#line hidden
            EndContext();
            BeginContext(420, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(488, 42, false);
#line 22 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ContactUs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Phones));

#line default
#line hidden
            EndContext();
            BeginContext(530, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(598, 44, false);
#line 25 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ContactUs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Contents));

#line default
#line hidden
            EndContext();
            BeginContext(642, 90, true);
            WriteLiteral("\r\n                </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ContactUs\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(764, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(813, 40, false);
#line 34 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ContactUs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Names));

#line default
#line hidden
            EndContext();
            BeginContext(853, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(909, 41, false);
#line 37 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ContactUs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Emails));

#line default
#line hidden
            EndContext();
            BeginContext(950, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1006, 41, false);
#line 40 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ContactUs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phones));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1103, 43, false);
#line 43 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ContactUs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Contents));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1201, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae2260ba50af48d58bb193dace3da036", async() => {
                BeginContext(1255, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ContactUs\Index.cshtml"
                                       WriteLiteral(item.ContactUsID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1263, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1283, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97efd2fa538d48ecb8022326cac1b971", async() => {
                BeginContext(1340, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ContactUs\Index.cshtml"
                                          WriteLiteral(item.ContactUsID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1351, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1371, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6f6288ef07f48a0992c5e559702564e", async() => {
                BeginContext(1427, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ContactUs\Index.cshtml"
                                         WriteLiteral(item.ContactUsID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1437, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ContactUs\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1476, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MarketWeb.Models.ViewModels.ContactUs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
