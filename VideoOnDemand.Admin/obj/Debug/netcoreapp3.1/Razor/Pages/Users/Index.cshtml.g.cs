#pragma checksum "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.Admin\Pages\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c302abd871559defce79615b9ce3b2cf12886fc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VideoOnDemand.Admin.Pages.Users.Pages_Users_Index), @"mvc.1.0.razor-page", @"/Pages/Users/Index.cshtml")]
namespace VideoOnDemand.Admin.Pages.Users
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
#line 2 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.Admin\Pages\_ViewImports.cshtml"
using VideoOnDemand.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.Admin\Pages\Users\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.Admin\Pages\Users\Index.cshtml"
using VideoOnDemand.Data.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c302abd871559defce79615b9ce3b2cf12886fc0", @"/Pages/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6f869f6d932abf38b6cfbf220a1d4b38b78992c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("message-type", "success", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("path", "Users/Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("Bootstrap-style", "primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("description", "Create New", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("path", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("Bootstrap-style", "warning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("description", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("path", "Users/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("Bootstrap-style", "success", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("font", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("path", "Users/Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("Bootstrap-style", "danger", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("font", "trash-alt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::VideoOnDemand.Admin.TagHelpers.StatusMessageTagHelper __VideoOnDemand_Admin_TagHelpers_StatusMessageTagHelper;
        private global::VideoOnDemand.Admin.TagHelpers.PageButtonTagHelper __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.Admin\Pages\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.Admin\Pages\Users\Index.cshtml"
 if (SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-8 col-md-offset-2\">\r\n            <h2>Users</h2>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("status-message", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c302abd871559defce79615b9ce3b2cf12886fc08007", async() => {
            }
            );
            __VideoOnDemand_Admin_TagHelpers_StatusMessageTagHelper = CreateTagHelper<global::VideoOnDemand.Admin.TagHelpers.StatusMessageTagHelper>();
            __tagHelperExecutionContext.Add(__VideoOnDemand_Admin_TagHelpers_StatusMessageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.Admin\Pages\Users\Index.cshtml"
                         WriteLiteral(Model.StatusMessage);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __VideoOnDemand_Admin_TagHelpers_StatusMessageTagHelper.Message = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("message", __VideoOnDemand_Admin_TagHelpers_StatusMessageTagHelper.Message, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __VideoOnDemand_Admin_TagHelpers_StatusMessageTagHelper.MessageType = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c302abd871559defce79615b9ce3b2cf12886fc09831", async() => {
            }
            );
            __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper = CreateTagHelper<global::VideoOnDemand.Admin.TagHelpers.PageButtonTagHelper>();
            __tagHelperExecutionContext.Add(__VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper);
            __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper.Path = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper.BootstrapStyle = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper.Description = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c302abd871559defce79615b9ce3b2cf12886fc011376", async() => {
            }
            );
            __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper = CreateTagHelper<global::VideoOnDemand.Admin.TagHelpers.PageButtonTagHelper>();
            __tagHelperExecutionContext.Add(__VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper);
            __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper.Path = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper.BootstrapStyle = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper.Description = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <table class=""table"">
                <thead>
                    <tr>
                        <th>Email</th>
                        <th>Admin</th>
                        <th>Id</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 29 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.Admin\Pages\Users\Index.cshtml"
                     foreach (var user in Model.Users)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 32 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.Admin\Pages\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => user.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.Admin\Pages\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => user.IsAdmin));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.Admin\Pages\Users\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => user.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"button-col-width\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c302abd871559defce79615b9ce3b2cf12886fc014546", async() => {
            }
            );
            __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper = CreateTagHelper<global::VideoOnDemand.Admin.TagHelpers.PageButtonTagHelper>();
            __tagHelperExecutionContext.Add(__VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper);
            __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper.Path = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper.BootstrapStyle = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper.font = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id-userId", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 36 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.Admin\Pages\Users\Index.cshtml"
AddHtmlAttributeValue("", 1589, user.Id, 1589, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c302abd871559defce79615b9ce3b2cf12886fc016563", async() => {
            }
            );
            __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper = CreateTagHelper<global::VideoOnDemand.Admin.TagHelpers.PageButtonTagHelper>();
            __tagHelperExecutionContext.Add(__VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper);
            __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper.Path = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper.BootstrapStyle = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __VideoOnDemand_Admin_TagHelpers_PageButtonTagHelper.font = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id-userId", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.Admin\Pages\Users\Index.cshtml"
AddHtmlAttributeValue("", 1734, user.Id, 1734, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 40 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.Admin\Pages\Users\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"col-md-2\">\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 47 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.Admin\Pages\Users\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VideoOnDemand.Admin.Pages.Users.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VideoOnDemand.Admin.Pages.Users.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VideoOnDemand.Admin.Pages.Users.IndexModel>)PageContext?.ViewData;
        public VideoOnDemand.Admin.Pages.Users.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591