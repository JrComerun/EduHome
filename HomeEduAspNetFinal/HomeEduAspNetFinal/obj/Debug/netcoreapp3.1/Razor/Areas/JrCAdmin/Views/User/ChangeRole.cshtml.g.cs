#pragma checksum "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\User\ChangeRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff1459a280bbead59a62e4d48a91a6482f6c7ebd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_JrCAdmin_Views_User_ChangeRole), @"mvc.1.0.view", @"/Areas/JrCAdmin/Views/User/ChangeRole.cshtml")]
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
#line 1 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\_ViewImports.cshtml"
using HomeEduAspNetFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\_ViewImports.cshtml"
using HomeEduAspNetFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\_ViewImports.cshtml"
using HomeEduAspNetFinal.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff1459a280bbead59a62e4d48a91a6482f6c7ebd", @"/Areas/JrCAdmin/Views/User/ChangeRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5e42ebeee535deeb2aaaae97546a810c2be8a9a", @"/Areas/JrCAdmin/Views/_ViewImports.cshtml")]
    public class Areas_JrCAdmin_Views_User_ChangeRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\User\ChangeRole.cshtml"
  
    ViewData["Title"] = "ChangeRole";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"col-md-6 grid-margin stretch-card bg-dark text-light\" >\n    <div class=\"card bg-dark\">\n        <div class=\"card-body\">\n            <h4 class=\"card-title text-light\">Name: ");
#nullable restore
#line 9 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\User\ChangeRole.cshtml"
                                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            <h4 class=\"card-title text-light\">SurName: ");
#nullable restore
#line 10 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\User\ChangeRole.cshtml"
                                                  Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            <h5>Username: ");
#nullable restore
#line 11 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\User\ChangeRole.cshtml"
                     Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            <h5>Email: ");
#nullable restore
#line 12 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\User\ChangeRole.cshtml"
                  Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        </div>\n        <div class=\"card-body\">\n                       <h3 class=\"text-danger\">Are you sure</h3>\n                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff1459a280bbead59a62e4d48a91a6482f6c7ebd6625", async() => {
                WriteLiteral("\n");
#nullable restore
#line 17 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\User\ChangeRole.cshtml"
                                  foreach (string role in Model.Roles)
                                  {
                                       if (Model.Role == role)
                                       {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                           <div class=\"form-group\">\n                                               <input type=\"radio\" name=\"role\" checked");
                BeginWriteAttribute("value", " value=\"", 946, "\"", 959, 1);
#nullable restore
#line 22 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\User\ChangeRole.cshtml"
WriteAttributeValue("", 954, role, 954, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 22 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\User\ChangeRole.cshtml"
                                                                                                  Write(role);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                           </div>\n");
#nullable restore
#line 24 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\User\ChangeRole.cshtml"
                                       }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <div class=\"form-group\">\n                                                    <input type=\"radio\" name=\"role\"");
                BeginWriteAttribute("value", " value=\"", 1299, "\"", 1312, 1);
#nullable restore
#line 28 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\User\ChangeRole.cshtml"
WriteAttributeValue("", 1307, role, 1307, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 28 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\User\ChangeRole.cshtml"
                                                                                               Write(role);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                           </div>\n");
#nullable restore
#line 30 "C:\Users\Code Academy\Desktop\EduHome\HomeEduAspNetFinal\HomeEduAspNetFinal\Areas\JrCAdmin\Views\User\ChangeRole.cshtml"
                                         }

                                   }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                      <button type=\"submit\" class=\"btn btn-danger\">Change Role</button>\n                           ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff1459a280bbead59a62e4d48a91a6482f6c7ebd11284", async() => {
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
            WriteLiteral("\n         </div>\n      </div>\n   </div>\n \n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
