#pragma checksum "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf543bd09c952f90dbdbd3f625f475a4a493cd8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GlobalSearchPartial), @"mvc.1.0.view", @"/Views/Shared/_GlobalSearchPartial.cshtml")]
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
#line 1 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\_ViewImports.cshtml"
using HomeEduAspNetFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\_ViewImports.cshtml"
using HomeEduAspNetFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\_ViewImports.cshtml"
using HomeEduAspNetFinal.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf543bd09c952f90dbdbd3f625f475a4a493cd8b", @"/Views/Shared/_GlobalSearchPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d455e6302f4b45ccd010cfe57ed64396a204bb8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GlobalSearchPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px!important;height:38px!important;margin-right:10px!important "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px!important;height:38px!important;margin-right:10px!important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul id=\"global-list\">\r\n");
#nullable restore
#line 3 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
     if (Model.Courses != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><h3>Result of Search for Course</h3></li>\r\n");
#nullable restore
#line 6 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
         foreach (Course c in Model.Courses)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf543bd09c952f90dbdbd3f625f475a4a493cd8b6566", async() => {
                WriteLiteral("\r\n                    <div style=\"display:flex!important;align-items:center!important;\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bf543bd09c952f90dbdbd3f625f475a4a493cd8b6937", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 418, "~/assets/img/course/", 418, 20, true);
#nullable restore
#line 11 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
AddHtmlAttributeValue("", 438, c.Image, 438, 8, false);

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
                WriteLiteral("\r\n                        <span>\r\n                            ");
#nullable restore
#line 13 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
                       Write(c.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
                                                                 WriteLiteral(c.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 18 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>...........................</li>\r\n");
#nullable restore
#line 20 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
     if (Model.Events != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><h3>Result of Search for Events</h3></li>\r\n");
#nullable restore
#line 24 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
         foreach (Event e in Model.Events)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf543bd09c952f90dbdbd3f625f475a4a493cd8b12385", async() => {
                WriteLiteral("\r\n                    <div style=\"display:flex!important;align-items:center!important;\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bf543bd09c952f90dbdbd3f625f475a4a493cd8b12757", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1141, "~/assets/img/event/", 1141, 19, true);
#nullable restore
#line 29 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
AddHtmlAttributeValue("", 1160, e.Image, 1160, 8, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <span>\r\n                            ");
#nullable restore
#line 31 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
                       Write(e.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
                                                                WriteLiteral(e.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 36 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>...........................</li>\r\n");
#nullable restore
#line 38 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
     if (Model.Teachers != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><h3>Result of Search for Teachers</h3></li>\r\n");
#nullable restore
#line 42 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
         foreach (Teacher t in Model.Teachers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf543bd09c952f90dbdbd3f625f475a4a493cd8b18217", async() => {
                WriteLiteral("\r\n                    <div style=\"display:flex!important;align-items:center!important;\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bf543bd09c952f90dbdbd3f625f475a4a493cd8b18589", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1872, "~/assets/img/teacher/", 1872, 21, true);
#nullable restore
#line 47 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
AddHtmlAttributeValue("", 1893, t.Image, 1893, 8, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <span>\r\n                            ");
#nullable restore
#line 49 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
                       Write(t.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
                                                                  WriteLiteral(t.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 54 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Code Academy\Desktop\elgun\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Shared\_GlobalSearchPartial.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
