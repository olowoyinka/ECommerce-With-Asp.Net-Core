#pragma checksum "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "002012909838726fd805c78efbd2282e47e76047"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_CheckOut), @"mvc.1.0.view", @"/Views/ShoppingCart/CheckOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShoppingCart/CheckOut.cshtml", typeof(AspNetCore.Views_ShoppingCart_CheckOut))]
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
#line 1 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"002012909838726fd805c78efbd2282e47e76047", @"/Views/ShoppingCart/CheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d030c069520c706fca90803c1839df023169deab", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_CheckOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(84, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
#line 7 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"
  
    ViewData["Title"] = "CheckOut";

#line default
#line hidden
            BeginContext(136, 38, true);
            WriteLiteral("\r\n<h2>Check Out Shopping Cart</h2>\r\n\r\n");
            EndContext();
#line 13 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"
  
    if (HttpContextAccessor.HttpContext.Session.GetString("Cart") != null)
    {



#line default
#line hidden
            BeginContext(265, 216, true);
            WriteLiteral("        <table class=\"table table-hover\">\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Price</th>\r\n                <th>Quantity</th>\r\n                <th>Sub Total</th>\r\n            </tr>\r\n\r\n");
            EndContext();
#line 26 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"
             foreach (var cart in @HttpContextAccessor.HttpContext.Session.GetObjectFromJson<List<Cart>>("Cart"))
                {

#line default
#line hidden
            BeginContext(615, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(687, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81270791307c4f6099b199f3becaa59c", async() => {
                BeginContext(777, 24, false);
#line 30 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"
                                                                                                            Write(cart.Product.ProductName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"
                                                                            WriteLiteral(cart.Product.ProductID);

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
            BeginContext(805, 80, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        $");
            EndContext();
            BeginContext(886, 18, false);
#line 33 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"
                    Write(cart.Product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(904, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(984, 13, false);
#line 36 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"
                   Write(cart.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(997, 82, true);
            WriteLiteral("\r\n\r\n                    </td>\r\n                    <td>\r\n                        $");
            EndContext();
            BeginContext(1081, 59, false);
#line 40 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"
                     Write(String.Format("{0:N0}", cart.Product.Price * cart.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 43 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"

            }

#line default
#line hidden
            BeginContext(1210, 119, true);
            WriteLiteral("\r\n            <tr style=\"color:red;font-size:20px\">\r\n                <td colspan=\"3\">TOTAL</td>\r\n                <td>\r\n");
            EndContext();
#line 49 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"
                      
                        List<Cart> temp = HttpContextAccessor.HttpContext.Session.GetObjectFromJson<List<Cart>>("Cart");
                        var total = String.Format("{0:N0}", temp.Sum(x => x.Quantity * x.Product.Price));
                    

#line default
#line hidden
            BeginContext(1605, 23, true);
            WriteLiteral("\r\n                    $");
            EndContext();
            BeginContext(1629, 5, false);
#line 54 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"
                Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(1634, 62, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n");
            EndContext();
#line 58 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"




                        }

                        else
                        {

#line default
#line hidden
            BeginContext(1790, 100, true);
            WriteLiteral("                            <h1> No Items in Your Cart!!!</h1>\r\n                            <br />\r\n");
            EndContext();
            BeginContext(1919, 55, false);
#line 68 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"
                       Write(Html.ActionLink("Start Shopping?", "Index", "Products"));

#line default
#line hidden
            EndContext();
#line 68 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"
                                                                                    
                        }

#line default
#line hidden
            BeginContext(2006, 18, true);
            WriteLiteral("\r\n\r\n\r\n<hr />\r\n\r\n\r\n");
            EndContext();
#line 77 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"
 using (Html.BeginForm("ProcessOrder", "ShoppingCart", FormMethod.Post, new { id = "customer-form" }))
{

#line default
#line hidden
            BeginContext(2131, 1298, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-4"">
            <table class=""table table-hover"">
                <tr>
                    <th>CUSTOMER'S INFORMATION</th>
                </tr>
                <tr>
                    <td>
                        <input type=""text"" class=""form-control"" placeholder=""Customer Name"" name=""cusName"" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type=""number"" class=""form-control"" placeholder=""Customer Phone"" name=""cusPhone"" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type=""email"" class=""form-control"" placeholder=""Customer Email"" name=""cusEmail"" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type=""text"" class=""form-control"" placeholder=""Customer Address"" name=""cusAddress"" />
                    </td>");
            WriteLiteral(@"
                </tr>
                <tr>
                    <td>
                        <input type=""submit"" class=""btn btn-default"" value=""Process Order"" />
                    </td>
                </tr>


            </table>

        </div>
    </div>
");
            EndContext();
#line 116 "c:\Users\fela\Documents\Visual Studio 2017\Projects\Web Development\Core 2 Application\MarketWeb\MarketWeb\Views\ShoppingCart\CheckOut.cshtml"
}

#line default
#line hidden
            BeginContext(3432, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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