#pragma checksum "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ce0a6da48e9791bd78625df767c8e525853e163"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Delete), @"mvc.1.0.view", @"/Views/Products/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Delete.cshtml", typeof(AspNetCore.Views_Products_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ce0a6da48e9791bd78625df767c8e525853e163", @"/Views/Products/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d030c069520c706fca90803c1839df023169deab", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MarketWeb.Models.ViewModels.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(88, 150, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        ");
            EndContext();
            BeginContext(238, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8508675a49cc434db454d151948fcda7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 14 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductID);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(281, 28, true);
            WriteLiteral("\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(310, 47, false);
#line 16 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(357, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(401, 43, false);
#line 19 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(444, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(488, 41, false);
#line 22 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(529, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(573, 37, false);
#line 25 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(610, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(654, 49, false);
#line 28 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SelfStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(703, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(747, 45, false);
#line 31 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SelfStartDate));

#line default
#line hidden
            EndContext();
            BeginContext(792, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(836, 47, false);
#line 34 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SelfEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(883, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(927, 43, false);
#line 37 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SelfEndDate));

#line default
#line hidden
            EndContext();
            BeginContext(970, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1014, 41, false);
#line 40 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1099, 37, false);
#line 43 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1180, 51, false);
#line 46 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationUser));

#line default
#line hidden
            EndContext();
            BeginContext(1231, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1275, 50, false);
#line 49 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationUser.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1369, 44, false);
#line 52 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1413, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1457, 45, false);
#line 55 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1502, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1546, 41, false);
#line 58 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
            EndContext();
            BeginContext(1587, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1631, 44, false);
#line 61 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Color.Colors));

#line default
#line hidden
            EndContext();
            BeginContext(1675, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1719, 41, false);
#line 64 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(1760, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1804, 44, false);
#line 67 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Model.Models));

#line default
#line hidden
            EndContext();
            BeginContext(1848, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1892, 43, false);
#line 70 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Storage));

#line default
#line hidden
            EndContext();
            BeginContext(1935, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1979, 48, false);
#line 73 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Storage.Storages));

#line default
#line hidden
            EndContext();
            BeginContext(2027, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2065, 230, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acc36958b6e9452aa6a5f6fa7d146349", async() => {
                BeginContext(2091, 137, true);
                WriteLiteral("\r\n        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
                EndContext();
                BeginContext(2228, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81bcde37b6cf4c90afcb551ba948c271", async() => {
                    BeginContext(2250, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2266, 22, true);
                WriteLiteral("\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2295, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MarketWeb.Models.ViewModels.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
