#pragma checksum "D:\Webtt\Webtt\Webtt\Views\Home\VoYK.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc4736ae85a4f29cec8d4d51bf2cb2229ca7190d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VoYK), @"mvc.1.0.view", @"/Views/Home/VoYK.cshtml")]
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
#line 1 "D:\Webtt\Webtt\Webtt\Views\_ViewImports.cshtml"
using Webtt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Webtt\Webtt\Webtt\Views\_ViewImports.cshtml"
using Webtt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4736ae85a4f29cec8d4d51bf2cb2229ca7190d", @"/Views/Home/VoYK.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a28098a913a3b41a6cebd54d73102cc91eac6249", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_VoYK : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Webtt.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("220"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Webtt\Webtt\Webtt\Views\Home\VoYK.cshtml"
  
    ViewData["Title"] = "VoYK";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>VoYK</h1>

<div class=""w-clear"">
    <div class=""slick_5 slick-initialized slick-slider"">
        <div aria-live=""polite"" class=""slick-list draggable"">
            <div class=""slick-track"" role=""listbox"" style=""opacity: 1; display: flex; width: 4444px; transform: transform3d(-2020px, 0px, 0px) ; "">
");
#nullable restore
#line 14 "D:\Webtt\Webtt\Webtt\Views\Home\VoYK.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""w-clear slick-slide slick-cloned"" tabindex=""-1"" role=""option"" aria-describedby=""slick-slide67""
                         style=""width: 202px;"" data-slick-index=""-5"" aria-hidden=""true"">

                        <div class=""box-sp w-clear"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 812, "\"", 819, 0);
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\">\r\n                                <div class=\"images\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fc4736ae85a4f29cec8d4d51bf2cb2229ca7190d5385", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 937, "~/img/", 937, 6, true);
#nullable restore
#line 22 "D:\Webtt\Webtt\Webtt\Views\Home\VoYK.cshtml"
AddHtmlAttributeValue("", 943, item.ProductImage, 943, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""new"">
                                </div>
                            </a>
                            <div class=""info w-clear"">
                                <div class=""w-clear"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 1311, "\"", 1318, 0);
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\">\r\n                                        <h3>\r\n                                            ");
#nullable restore
#line 31 "D:\Webtt\Webtt\Webtt\Views\Home\VoYK.cshtml"
                                       Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </h3>
                                    </a>
                                    <div class=""info-gia flex"">
                                        <div class=""gia"">
                                            Giá:
                                            <span>");
#nullable restore
#line 37 "D:\Webtt\Webtt\Webtt\Views\Home\VoYK.cshtml"
                                             Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 44 "D:\Webtt\Webtt\Webtt\Views\Home\VoYK.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Webtt.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
