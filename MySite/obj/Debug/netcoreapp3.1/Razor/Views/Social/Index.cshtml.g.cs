#pragma checksum "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Social\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bef4277d913423a3f0337c225e0684b7c08f1032"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Social_Index), @"mvc.1.0.view", @"/Views/Social/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef4277d913423a3f0337c225e0684b7c08f1032", @"/Views/Social/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Social_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Social/game"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("MetroButton MetroButtonA"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Social\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"content\">\r\n    <br />\r\n    <h1 style=\"text-align: center;\">Обо мне</h1>\r\n    <p>\r\n        Я Гавриленко Сергей Константинович, друзья зовут меня Се́рга. <br />\r\n        Мне ");
#nullable restore
#line 10 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Social\Index.cshtml"
        Write(((DateTime.Now - (new DateTime(2002, 11, 15, 13, 30, 00, 00))).TotalDays / 365.25d).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" лет. <br />\r\n        В свободное время я либо <a href=\"../Qualification/\" class=\"MetroButton MetroButtonA\">программирую</a>, либо ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bef4277d913423a3f0337c225e0684b7c08f10324265", async() => {
                WriteLiteral("играю");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(".<br />\r\n        <br />\r\n    </p>\r\n    <h1 style=\"width: 100%; text-align:center;\">Мои награды</h1>\r\n    <ul>\r\n");
#nullable restore
#line 16 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Social\Index.cshtml"
         foreach (string im in new string[]{
             "yali.jpg",
             "strl.jpeg",
             "smr.jpg",
             "gag.jpg",
             "krid.jpg",
             "man.jpg",
             "man1.jpg",
             "rabt.jpg",
             "TaGOl.jpeg",
             "wels.jpg",
         })
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"dplli\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1016, "\"", 1048, 2);
            WriteAttributeValue("", 1023, "../images/certificate/", 1023, 22, true);
#nullable restore
#line 30 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Social\Index.cshtml"
WriteAttributeValue("", 1045, im, 1045, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img height=\"300\"");
            BeginWriteAttribute("src", " src=\"", 1089, "\"", 1120, 2);
            WriteAttributeValue("", 1095, "../images/certificate/", 1095, 22, true);
#nullable restore
#line 31 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Social\Index.cshtml"
WriteAttributeValue("", 1117, im, 1117, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 34 "C:\Users\00jes\source\repos\MySiteRepo\MySite\Views\Social\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
