#pragma checksum "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\SpecialCourse\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6476facd2c44274a94269770d2a05ec474cd929"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_JrCAdmin_Views_SpecialCourse_Detail), @"mvc.1.0.view", @"/Areas/JrCAdmin/Views/SpecialCourse/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6476facd2c44274a94269770d2a05ec474cd929", @"/Areas/JrCAdmin/Views/SpecialCourse/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d10ff602bca1c000c1addc2bd2a8849dc3fbc2d1", @"/Areas/JrCAdmin/Views/_ViewImports.cshtml")]
    public class Areas_JrCAdmin_Views_SpecialCourse_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Course>
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
#line 2 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\SpecialCourse\Detail.cshtml"
   ViewData["Title"] = "Detail"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-6 grid-margin stretch-card bg-dark text-light\">\r\n    <div class=\"card d-flex flex-column bg-dark\">\r\n\r\n        <div class=\"card-body \">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f6476facd2c44274a94269770d2a05ec474cd9295206", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 228, "~/assets/img/course/", 228, 20, true);
#nullable restore
#line 7 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\SpecialCourse\Detail.cshtml"
AddHtmlAttributeValue("", 248, Model.Image, 248, 12, false);

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
            WriteLiteral("\r\n        </div>\r\n        <div class=\"card-body \">\r\n            <h4 style=\"font-weight:600 !important\">Course Name : <span style=\"font-weight:200 !important\"> ");
#nullable restore
#line 10 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\SpecialCourse\Detail.cshtml"
                                                                                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h4>\r\n        </div>\r\n        <div class=\"card-body \">\r\n            <h5 style=\"font-weight:600 !important\">Description : <span style=\"font-weight:200 !important\"> ");
#nullable restore
#line 13 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\SpecialCourse\Detail.cshtml"
                                                                                                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h5>\r\n        </div>\r\n        <div class=\"card-body \">\r\n            <h5 style=\"font-weight:600 !important\">About Course : <span style=\"font-weight:200 !important\"> ");
#nullable restore
#line 16 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\SpecialCourse\Detail.cshtml"
                                                                                                       Write(Model.DetailOfCourse.AboutCourse);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h5>\r\n        </div>\r\n        <div class=\"card-body \">\r\n            <h5 style=\"font-weight:600 !important\">How to Apply : <span style=\"font-weight:200 !important\"> ");
#nullable restore
#line 19 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\SpecialCourse\Detail.cshtml"
                                                                                                       Write(Model.DetailOfCourse.HowToApply);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h5>\r\n        </div>\r\n        <div class=\"card-body \">\r\n            <h5 style=\"font-weight:600 !important\">Cerfication : <span style=\"font-weight:200 !important\"> ");
#nullable restore
#line 22 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\SpecialCourse\Detail.cshtml"
                                                                                                      Write(Model.DetailOfCourse.Certification);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h5>\r\n        </div>\r\n        <div class=\"card-body \">\r\n            <h5 style=\"font-weight:600 !important\">Start Date : <span style=\"font-weight:200 !important\"> ");
#nullable restore
#line 25 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\SpecialCourse\Detail.cshtml"
                                                                                                     Write(Model.DetailOfCourse.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h5>\r\n        </div>\r\n        <div class=\"card-body \">\r\n            <h5 style=\"font-weight:600 !important\">Students Count : <span style=\"font-weight:200 !important\"> ");
#nullable restore
#line 28 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\SpecialCourse\Detail.cshtml"
                                                                                                         Write(Model.DetailOfCourse.Students);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h5>\r\n        </div>\r\n        <div class=\"card-body \">\r\n            <h5 style=\"font-weight:600 !important\">Duration  : <span style=\"font-weight:200 !important\"> ");
#nullable restore
#line 31 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\SpecialCourse\Detail.cshtml"
                                                                                                    Write(Model.DetailOfCourse.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Month</span></h5>\r\n        </div>\r\n        <div class=\"card-body \">\r\n            <h5 style=\"font-weight:600 !important\">Class Duration : <span style=\"font-weight:200 !important\"> ");
#nullable restore
#line 34 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\SpecialCourse\Detail.cshtml"
                                                                                                         Write(Model.DetailOfCourse.ClassDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Hours</span></h5>\r\n        </div>\r\n        <div class=\"card-body \">\r\n            <h5 style=\"font-weight:600 !important\">Assesment : <span style=\"font-weight:200 !important\"> ");
#nullable restore
#line 37 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\SpecialCourse\Detail.cshtml"
                                                                                                    Write(Model.DetailOfCourse.Assesments);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h5>\r\n        </div>\r\n        <div class=\"card-body \">\r\n            <h5 style=\"font-weight:600 !important\">Language : <span style=\"font-weight:200 !important\"> ");
#nullable restore
#line 40 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\SpecialCourse\Detail.cshtml"
                                                                                                   Write(Model.DetailOfCourse.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></h5>\r\n        </div>\r\n        <div class=\"card-body \">\r\n            <h5 style=\"font-weight:600 !important\">Price : <span style=\"font-weight:200 !important\"> ");
#nullable restore
#line 43 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\SpecialCourse\Detail.cshtml"
                                                                                                Write(Model.DetailOfCourse.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</span></h5>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<div class=\"a\" style=\"padding: 0 10px\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6476facd2c44274a94269770d2a05ec474cd92913723", async() => {
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
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
