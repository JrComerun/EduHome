#pragma checksum "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7aad15cc954d3d01fabe1d28c4135f52fe51a70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Detail), @"mvc.1.0.view", @"/Views/Event/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7aad15cc954d3d01fabe1d28c4135f52fe51a70", @"/Views/Event/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d455e6302f4b45ccd010cfe57ed64396a204bb8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommentVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("event-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("speaker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
  
    ViewData["Title"] = "Detail Of Event";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Banner Area Start -->\r\n");
#nullable restore
#line 6 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
Write(await Component.InvokeAsync("SectionTitle", new { title = "Events Details", source = "../.." }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Banner Area End -->
<!-- Event Details Start -->
<div class=""event-details-area blog-area pt-150 pb-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""event-details"">
                    <div class=""event-details-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d7aad15cc954d3d01fabe1d28c4135f52fe51a705225", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 533, "~/assets/img/event/", 533, 19, true);
#nullable restore
#line 15 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 552, Model.DetailOfEvent.Event.Image, 552, 32, false);

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
            WriteLiteral("\r\n                        <div class=\"event-date\">\r\n                            <h3>");
#nullable restore
#line 17 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
                           Write(Model.DetailOfEvent.Event.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>jun</span></h3>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"event-details-content\">\r\n                        <h2>");
#nullable restore
#line 21 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
                       Write(Model.DetailOfEvent.Event.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <ul>\r\n                            <li><span>time : </span>");
#nullable restore
#line 23 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
                                               Write(Model.DetailOfEvent.Event.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><span>venue : </span>");
#nullable restore
#line 24 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
                                                Write(Model.DetailOfEvent.Event.Venue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ul>\r\n                        <p>");
#nullable restore
#line 26 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
                      Write(Html.Raw(Model.DetailOfEvent.Decscription));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n                        <div class=\"speakers-area fix\">\r\n                            <h4>speakers</h4>\r\n");
#nullable restore
#line 30 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
                             if (Model.DetailOfEvent.Event.Id == Model.DetailOfEvent.EventId)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
                                 foreach (SpikersOfEvent sp in Model.DetailOfEvent.SpikersOfEvents)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"single-speaker\">\r\n                                        <div class=\"speaker-img\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d7aad15cc954d3d01fabe1d28c4135f52fe51a709778", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1803, "~/assets/img/event/", 1803, 19, true);
#nullable restore
#line 36 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 1822, sp.Image, 1822, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"speaker-name\">\r\n                                            <h5>");
#nullable restore
#line 39 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
                                           Write(sp.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <p>");
#nullable restore
#line 40 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
                                          Write(sp.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 43 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                    ");
#nullable restore
#line 49 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
               Write(await Component.InvokeAsync("Comment", new { product = "event" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 53 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Views\Event\Detail.cshtml"
           Write(await Component.InvokeAsync("LastsBlog", new { path = "event" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Event Details End -->\r\n");
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
