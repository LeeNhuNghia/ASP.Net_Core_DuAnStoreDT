#pragma checksum "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\Store\PhanLoai.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f97bebf7f9b015acdcdb492e1baf3135a460e60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_PhanLoai), @"mvc.1.0.view", @"/Views/Store/PhanLoai.cshtml")]
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
#line 1 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\_ViewImports.cshtml"
using DuAnASPnetCore_storeDT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\_ViewImports.cshtml"
using DuAnASPnetCore_storeDT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f97bebf7f9b015acdcdb492e1baf3135a460e60", @"/Views/Store/PhanLoai.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fa115db3edee23a274a1ec2f851097489386e32", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_PhanLoai : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("quick-view"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\Store\PhanLoai.cshtml"
  
    ViewData["Title"] = "PhanLoai";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- SECTION -->
<div class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <!-- ASIDE -->
            <div id=""aside"" class=""col-md-3"">
                <!-- aside Widget -->
                <div class=""aside"">
                    <h3 class=""aside-title"">Nhà cung cấp</h3>
                    <div class=""checkbox-filter"">
                        <div class=""input-checkbox"">
                            <input type=""checkbox"" id=""brand-1"">
                            <label for=""brand-1"">
                                <span></span>
                                SAMSUNG
                                <small>(15)</small>
                            </label>
                        </div>
                    </div>

                    <div class=""checkbox-filter"">
                        <div class=""input-checkbox"">
                            <input type=""checkbox"" id=""brand-2"">
                            <la");
            WriteLiteral(@"bel for=""brand-2"">
                                <span></span>
                                APPBLE
                                <small>(20)</small>
                            </label>
                        </div>
                    </div>

                    <div class=""checkbox-filter"">
                        <div class=""input-checkbox"">
                            <input type=""checkbox"" id=""brand-3"">
                            <label for=""brand-3"">
                                <span></span>
                                OPPO
                                <small>(22)</small>
                            </label>
                        </div>
                    </div>

                    <div class=""checkbox-filter"">
                        <div class=""input-checkbox"">
                            <input type=""checkbox"" id=""brand-4"">
                            <label for=""brand-4"">
                                <span></span>
                                LG");
            WriteLiteral(@"
                                <small>(31)</small>
                            </label>
                        </div>
                    </div>
                </div>
                <!-- /aside Widget -->
                <!-- aside Widget -->
                <div class=""aside"">
                    <h3 class=""aside-title"">Top selling</h3>
");
#nullable restore
#line 66 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\Store\PhanLoai.cshtml"
                     foreach (var tsl in Model.Take(3))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"product-widget\">\r\n                            <div class=\"product-img\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1f97bebf7f9b015acdcdb492e1baf3135a460e609021", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2746, "~/", 2746, 2, true);
#nullable restore
#line 70 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\Store\PhanLoai.cshtml"
AddHtmlAttributeValue("", 2748, tsl.ProductImg, 2748, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"product-body\">\r\n                                <p class=\"product-category\">");
#nullable restore
#line 73 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\Store\PhanLoai.cshtml"
                                                       Write(tsl.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <h3 class=\"product-name\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f97bebf7f9b015acdcdb492e1baf3135a460e6011177", async() => {
#nullable restore
#line 74 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\Store\PhanLoai.cshtml"
                                                                                                                                                  Write(tsl.ProductName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idprd", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\Store\PhanLoai.cshtml"
                                                                                                                           WriteLiteral(tsl.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idprd"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idprd", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idprd"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n                                <h4 class=\"product-price\">$");
#nullable restore
#line 75 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\Store\PhanLoai.cshtml"
                                                      Write(tsl.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <del class=\"product-old-price\">$990.00</del></h4>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 78 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\Store\PhanLoai.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <!-- /aside Widget -->
            </div>
            <!-- /ASIDE -->
            <!-- STORE -->
            <div id=""store"" class=""col-md-9"">
                <!-- store products -->
                <div class=""row"">
");
#nullable restore
#line 87 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\Store\PhanLoai.cshtml"
                     foreach (var items in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <!-- product -->\r\n                        <div class=\"col-md-4 col-xs-6\">\r\n                            <div class=\"product\">\r\n                                <div class=\"product-img\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1f97bebf7f9b015acdcdb492e1baf3135a460e6015841", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3930, "~/", 3930, 2, true);
#nullable restore
#line 93 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\Store\PhanLoai.cshtml"
AddHtmlAttributeValue("", 3932, items.ProductImg, 3932, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <div class=""product-label"">
                                        <span class=""sale"">-30%</span>
                                        <span class=""new"">NEW</span>
                                    </div>
                                </div>
                                <div class=""product-body"">
                                    <p class=""product-category"">");
#nullable restore
#line 100 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\Store\PhanLoai.cshtml"
                                                           Write(items.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <h3 class=\"product-name\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f97bebf7f9b015acdcdb492e1baf3135a460e6018275", async() => {
#nullable restore
#line 101 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\Store\PhanLoai.cshtml"
                                                                                                                                                        Write(items.ProductName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idprd", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\Store\PhanLoai.cshtml"
                                                                                                                               WriteLiteral(items.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idprd"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idprd", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idprd"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n                                    <h4 class=\"product-price\">$");
#nullable restore
#line 102 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\Store\PhanLoai.cshtml"
                                                          Write(items.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <del class=""product-old-price"">$990.00</del></h4>
                                    <div class=""product-rating"">
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                    </div>
                                    <div class=""product-btns"">
                                        <button class=""add-to-wishlist""><i class=""fa fa-heart-o""></i><span class=""tooltipp"">add to wishlist</span></button>
                                        <button class=""add-to-compare""><i class=""fa fa-exchange""></i><span class=""tooltipp"">add to compare</span></button>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f97bebf7f9b015acdcdb492e1baf3135a460e6022677", async() => {
                WriteLiteral("<i class=\"fa fa-eye\"></i><span class=\"tooltipp\">quick view</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""add-to-cart"">
                                    <button class=""add-to-cart-btn""><i class=""fa fa-shopping-cart""></i> add to cart</button>
                                </div>
                            </div>
                        </div>
                        <!-- /product -->
");
#nullable restore
#line 122 "D:\HOC_TAP\LTrinh_Web_NangCao\ASP.Net_Core_DuAnStoreDT\DuAnASPnetCore_storeDT\DuAnASPnetCore_storeDT\Views\Store\PhanLoai.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <!-- /store products -->\r\n                <!-- store bottom filter -->\r\n");
            WriteLiteral("                <!-- /store bottom filter -->\r\n            </div>\r\n            <!-- /STORE -->\r\n        </div>\r\n        <!-- /row -->\r\n    </div>\r\n    <!-- /container -->\r\n</div>\r\n<!-- /SECTION -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
