#pragma checksum "D:\Book\deploy\VideoOnDemand\VideoOnDemand.Admin\Pages\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad1f623b97312f5f0614ea53fca078937d103f76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VideoOnDemand.Admin.Pages.Courses.Pages_Courses_Index), @"mvc.1.0.razor-page", @"/Pages/Courses/Index.cshtml")]
namespace VideoOnDemand.Admin.Pages.Courses
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
#line 2 "D:\Book\deploy\VideoOnDemand\VideoOnDemand.Admin\Pages\_ViewImports.cshtml"
using VideoOnDemand.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Book\deploy\VideoOnDemand\VideoOnDemand.Admin\Pages\Courses\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Book\deploy\VideoOnDemand\VideoOnDemand.Admin\Pages\Courses\Index.cshtml"
using VideoOnDemand.Data.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1f623b97312f5f0614ea53fca078937d103f76", @"/Pages/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6f869f6d932abf38b6cfbf220a1d4b38b78992c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Courses_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("message-type", "success", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("path", "Courses/Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("bootstrap-style", "primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("description", "Create New", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("path", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("bootstrap-style", "warning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("description", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("path", "Courses/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("bootstrap-style", "success", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("font", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("path", "Courses/Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("bootstrap-style", "danger", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "D:\Book\deploy\VideoOnDemand\VideoOnDemand.Admin\Pages\Courses\Index.cshtml"
  
    ViewData["Title"] = "Course";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 10 "D:\Book\deploy\VideoOnDemand\VideoOnDemand.Admin\Pages\Courses\Index.cshtml"
 if (SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\n        <div class=\"col-md-12\">\n            <h2>");
#nullable restore
#line 14 "D:\Book\deploy\VideoOnDemand\VideoOnDemand.Admin\Pages\Courses\Index.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("status-message", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad1f623b97312f5f0614ea53fca078937d103f768159", async() => {
            }
            );
            __VideoOnDemand_Admin_TagHelpers_StatusMessageTagHelper = CreateTagHelper<global::VideoOnDemand.Admin.TagHelpers.StatusMessageTagHelper>();
            __tagHelperExecutionContext.Add(__VideoOnDemand_Admin_TagHelpers_StatusMessageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "D:\Book\deploy\VideoOnDemand\VideoOnDemand.Admin\Pages\Courses\Index.cshtml"
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
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad1f623b97312f5f0614ea53fca078937d103f769979", async() => {
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
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad1f623b97312f5f0614ea53fca078937d103f7611522", async() => {
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
                        <th>Name</th>
                        <th>Description</th>
                        <th>Instructor</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 28 "D:\Book\deploy\VideoOnDemand\VideoOnDemand.Admin\Pages\Courses\Index.cshtml"
                     foreach (var item in Model.Items)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 31 "D:\Book\deploy\VideoOnDemand\VideoOnDemand.Admin\Pages\Courses\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 32 "D:\Book\deploy\VideoOnDemand\VideoOnDemand.Admin\Pages\Courses\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 33 "D:\Book\deploy\VideoOnDemand\VideoOnDemand.Admin\Pages\Courses\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Instructor.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td class=\"button-col-width\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad1f623b97312f5f0614ea53fca078937d103f7614691", async() => {
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
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 35 "D:\Book\deploy\VideoOnDemand\VideoOnDemand.Admin\Pages\Courses\Index.cshtml"
AddHtmlAttributeValue("", 1501, item.Id, 1501, 8, false);

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
            WriteLiteral("\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad1f623b97312f5f0614ea53fca078937d103f7616697", async() => {
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
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 36 "D:\Book\deploy\VideoOnDemand\VideoOnDemand.Admin\Pages\Courses\Index.cshtml"
AddHtmlAttributeValue("", 1639, item.Id, 1639, 8, false);

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
            WriteLiteral("\n                            </td>\n                        </tr>\n");
#nullable restore
#line 39 "D:\Book\deploy\VideoOnDemand\VideoOnDemand.Admin\Pages\Courses\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n");
#nullable restore
#line 44 "D:\Book\deploy\VideoOnDemand\VideoOnDemand.Admin\Pages\Courses\Index.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
