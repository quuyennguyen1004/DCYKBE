#pragma checksum "D:\Webtt\Webtt\Webtt\Views\Detail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e32723843657b47a4424d7e61d5fd5aa45d37f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Detail_Index), @"mvc.1.0.view", @"/Views/Detail/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e32723843657b47a4424d7e61d5fd5aa45d37f7", @"/Views/Detail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a28098a913a3b41a6cebd54d73102cc91eac6249", @"/Views/_ViewImports.cshtml")]
    public class Views_Detail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Webtt.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Webtt\Webtt\Webtt\Views\Detail\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""card"">
        <div class=""container-fliud"">
            <div class=""wrapper row"">
                <div class=""preview col-md-6"">

                    <div class=""preview-pic tab-content"">
                        <div class=""tab-pane active"" id=""pic-1"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e32723843657b47a4424d7e61d5fd5aa45d37f73869", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 429, "~/img/", 429, 6, true);
#nullable restore
#line 14 "D:\Webtt\Webtt\Webtt\Views\Detail\Index.cshtml"
AddHtmlAttributeValue("", 435, Model.ProductImage, 435, 19, false);

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
            WriteLiteral("</div>\r\n                    </div>\r\n\r\n                </div>\r\n                <div class=\"details col-md-6\">\r\n                    <h2 class=\"product-title\">");
#nullable restore
#line 19 "D:\Webtt\Webtt\Webtt\Views\Detail\Index.cshtml"
                                         Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h3>Mô tả:</h3>\r\n                    <p class=\"product-description\" style=\"font-size: 16px;\">\r\n                        ");
#nullable restore
#line 22 "D:\Webtt\Webtt\Webtt\Views\Detail\Index.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <h3 class=\"price\">Giá: <span>");
#nullable restore
#line 24 "D:\Webtt\Webtt\Webtt\Views\Detail\Index.cshtml"
                                            Write(Model.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Webtt.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
