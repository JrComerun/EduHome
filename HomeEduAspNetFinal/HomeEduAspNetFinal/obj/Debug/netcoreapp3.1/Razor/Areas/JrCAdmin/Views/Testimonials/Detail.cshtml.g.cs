#pragma checksum "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\Testimonials\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa54608eec5e9298b7d389dcdd096e8d0229160b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_JrCAdmin_Views_Testimonials_Detail), @"mvc.1.0.view", @"/Areas/JrCAdmin/Views/Testimonials/Detail.cshtml")]
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
#line 1 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\_ViewImports.cshtml"
using HomeEduAspNetFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\_ViewImports.cshtml"
using HomeEduAspNetFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\_ViewImports.cshtml"
using HomeEduAspNetFinal.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa54608eec5e9298b7d389dcdd096e8d0229160b", @"/Areas/JrCAdmin/Views/Testimonials/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d10ff602bca1c000c1addc2bd2a8849dc3fbc2d1", @"/Areas/JrCAdmin/Views/_ViewImports.cshtml")]
    public class Areas_JrCAdmin_Views_Testimonials_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Testimonial>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 150px !important;width: 200px !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\Testimonials\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-6 grid-margin stretch-card bg-dark text-light\">\r\n    <div class=\"card d-flex flex-column bg-dark\">\r\n\r\n        <div class=\"card-body \">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fa54608eec5e9298b7d389dcdd096e8d0229160b5209", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 239, "~/assets/img/testimonial/", 239, 25, true);
#nullable restore
#line 9 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\Testimonials\Detail.cshtml"
AddHtmlAttributeValue("", 264, Model.Image, 264, 12, false);

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
            WriteLiteral("\r\n        </div>\r\n        <div class=\"card-body \">\r\n            <h4 style=\"font-weight:600 !important\">Person : <span style=\"font-weight:200 !important\"> ");
#nullable restore
#line 12 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\Testimonials\Detail.cshtml"
                                                                                                 Write(Model.Person);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h4>\r\n        </div>\r\n        <div class=\"card-body \">\r\n            <h5 style=\"font-weight:600 !important\">Profession : <span style=\"font-weight:200 !important\"> ");
#nullable restore
#line 15 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\Testimonials\Detail.cshtml"
                                                                                                     Write(Model.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h5>\r\n        </div>\r\n        <div class=\"card-body \">\r\n            <h5 style=\"font-weight:600 !important\">Say About Us : <span style=\"font-weight:200 !important\"> ");
#nullable restore
#line 18 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\Testimonials\Detail.cshtml"
                                                                                                       Write(Model.SayAboutUs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n        </div>\r\n    \r\n    </div>\r\n</div>\r\n<div class=\"a\" style=\"padding: 0 10px\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa54608eec5e9298b7d389dcdd096e8d0229160b8582", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Testimonial> Html { get; private set; }
    }
}
#pragma warning restore 1591
