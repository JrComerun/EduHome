#pragma checksum "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4b9676730df949ad08b33a14e63694974dae9e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Detail), @"mvc.1.0.view", @"/Views/Course/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4b9676730df949ad08b33a14e63694974dae9e8", @"/Views/Course/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5bb97a3efb41aa2b516d8cd4bbf3e8e71f9ee7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommentVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("courses-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
  
    ViewData["Title"] = "DetailOfCourse";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Banner Area Start -->\n");
#nullable restore
#line 6 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
Write(await Component.InvokeAsync("SectionTitle", new { title = "Courses Details", source = "../.." }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Banner Area End -->
<!-- Blog Start -->
<div class=""courses-details-area blog-area pt-150 pb-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""courses-details"">
                    <div class=""courses-details-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4b9676730df949ad08b33a14e63694974dae9e84873", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 516, "~/assets/img/course/", 516, 20, true);
#nullable restore
#line 15 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
AddHtmlAttributeValue("", 536, Model.DetailOfCourse.Course.Image, 536, 34, false);

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
            WriteLiteral("\n                    </div>\n                    <div class=\"course-details-content\">\n                        <h2>");
#nullable restore
#line 18 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                       Write(Model.DetailOfCourse.Course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                        <p>");
#nullable restore
#line 19 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                      Write(Html.Raw(Model.DetailOfCourse.Course.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <div class=\"course-details-left\">\n                            <div class=\"single-course-left\">\n                                <h3>about course</h3>\n                                <p>");
#nullable restore
#line 23 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                              Write(Html.Raw(Model.DetailOfCourse.AboutCourse));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                            <div class=\"single-course-left\">\n                                <h3>how to apply</h3>\n                                <p>");
#nullable restore
#line 27 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                              Write(Html.Raw(Model.DetailOfCourse.HowToApply));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                            <div class=\"single-course-left\">\n                                <h3>certification</h3>\n                                <p>");
#nullable restore
#line 31 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                              Write(Html.Raw(Model.DetailOfCourse.Certification));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                            </div>
                        </div>
                        <div class=""course-details-right"">
                            <h3>COURSE FEATURES</h3>
                            <ul>
                                <li>starts <span>");
#nullable restore
#line 38 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                                            Write(Model.DetailOfCourse.StartDate.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                                <li>duration <span>");
#nullable restore
#line 39 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                                              Write(Model.DetailOfCourse.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Month</span></li>\n                                <li>class duration <span>");
#nullable restore
#line 40 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                                                    Write(Model.DetailOfCourse.ClassDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Hours</span></li>\n                                <li>skill level <span>all level</span></li>\n                                <li>language <span>");
#nullable restore
#line 42 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                                              Write(Model.DetailOfCourse.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                                <li>students <span>");
#nullable restore
#line 43 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                                              Write(Model.DetailOfCourse.Students);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                                <li>assesments <span>");
#nullable restore
#line 44 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                                                Write(Model.DetailOfCourse.Assesments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\n                            </ul>\n                            <h3 class=\"red\">course fee $");
#nullable restore
#line 46 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                                                   Write(Model.DetailOfCourse.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                        </div>\n                    </div>\n                    ");
#nullable restore
#line 49 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
               Write(await Component.InvokeAsync("Comment", new { product = "course" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <div class=\"row\" id=\"comment-list-course\" style=\"margin-top:20px;\">\n");
#nullable restore
#line 51 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                         foreach (Comment com in Model.Comments)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row"">
                                <div class=""col-sm-1"">
                                    <div class=""thumbnail"">
                                        <img class=""img-responsive user-photo"" src=""https://ssl.gstatic.com/accounts/ui/avatar_2x.png"">
                                    </div><!-- /thumbnail -->
                                </div><!-- /col-sm-1 -->

                                <div class=""col-sm-5"">
                                    <div class=""panel panel-default"">
                                        <div class=""panel-heading"">
                                            <strong>");
#nullable restore
#line 63 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                                               Write(com.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> <span class=\"text-muted\">commented ");
#nullable restore
#line 63 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                                                                                                         Write(com.CreateTime.ToString("f"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                        </div>\n                                        <div class=\"panel-body\">\n                                            ");
#nullable restore
#line 66 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                                       Write(com.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </div><!-- /panel-body -->\n                                    </div><!-- /panel panel-default -->\n                                </div><!-- /col-sm-5 -->\n                            </div><!-- /row -->\n");
#nullable restore
#line 71 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n            <div class=\"col-md-4\">\n                ");
#nullable restore
#line 76 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Course\Detail.cshtml"
           Write(await Component.InvokeAsync("LastsBlog", new { path = "course" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n              \n            </div>\n        </div>\n    </div>\n</div>\n<!-- Blog End -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommentVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
