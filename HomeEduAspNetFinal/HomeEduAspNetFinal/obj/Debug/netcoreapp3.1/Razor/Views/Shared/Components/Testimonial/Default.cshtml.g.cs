#pragma checksum "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\Components\Testimonial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "376924ca266692ba3fd1604fde1d22ae1da235d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Testimonial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Testimonial/Default.cshtml")]
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
#line 1 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\_ViewImports.cshtml"
using HomeEduAspNetFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\_ViewImports.cshtml"
using HomeEduAspNetFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\_ViewImports.cshtml"
using HomeEduAspNetFinal.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"376924ca266692ba3fd1604fde1d22ae1da235d0", @"/Views/Shared/Components/Testimonial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5bb97a3efb41aa2b516d8cd4bbf3e8e71f9ee7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Testimonial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("testimonial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"testimonial-area pt-110 pb-105 text-center\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"testimonial-owl owl-theme owl-carousel\">\n");
#nullable restore
#line 6 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\Components\Testimonial\Default.cshtml"
                 foreach (Testimonial test in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-8 col-md-offset-2 col-sm-12"">

                        <div class=""single-testimonial"">
                            <div class=""testimonial-info"">
                                <div class=""testimonial-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "376924ca266692ba3fd1604fde1d22ae1da235d04880", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 566, "~/assets/img/testimonial/", 566, 25, true);
#nullable restore
#line 13 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\Components\Testimonial\Default.cshtml"
AddHtmlAttributeValue("", 591, test.Image, 591, 11, false);

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
            WriteLiteral("\n                                </div>\n                                <div class=\"testimonial-content\">\n                                    <p>");
#nullable restore
#line 16 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\Components\Testimonial\Default.cshtml"
                                  Write(test.SayAboutUs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                    <h4>");
#nullable restore
#line 17 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\Components\Testimonial\Default.cshtml"
                                   Write(test.Person);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                                    <h5>");
#nullable restore
#line 18 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\Components\Testimonial\Default.cshtml"
                                   Write(test.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                </div>\n                            </div>\n                        </div>\n\n\n                    </div>\n");
#nullable restore
#line 25 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\Components\Testimonial\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; }
    }
}
#pragma warning restore 1591
