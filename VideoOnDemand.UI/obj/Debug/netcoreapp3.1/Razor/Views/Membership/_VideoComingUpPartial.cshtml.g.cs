#pragma checksum "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d42ac28d7989a843753ab4e3dc7e4a010e428b9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Membership__VideoComingUpPartial), @"mvc.1.0.view", @"/Views/Membership/_VideoComingUpPartial.cshtml")]
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
#line 1 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\_ViewImports.cshtml"
using VideoOnDemand.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\_ViewImports.cshtml"
using VideoOnDemand.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\_ViewImports.cshtml"
using VideoOnDemand.UI.Models.MembershipViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\_ViewImports.cshtml"
using VideoOnDemand.UI.Models.DTOModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d42ac28d7989a843753ab4e3dc7e4a010e428b9f", @"/Views/Membership/_VideoComingUpPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50ffd5a130624def8a69fa2d50ff178552dbddf5", @"/Views/_ViewImports.cshtml")]
    public class Views_Membership__VideoComingUpPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LessonInfoDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
 if (Model.PreviousVideoId > 0 || Model.NextVideoId > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"panel coming-up\">\r\n        <div class=\"img-container\">\r\n");
#nullable restore
#line 7 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
             if (Model.NextVideoId == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 234, "\"", 268, 1);
#nullable restore
#line 9 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
WriteAttributeValue("", 240, Model.CurrentVideoThumbnail, 240, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                     class=\"img-responsive\">\r\n");
#nullable restore
#line 11 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 385, "\"", 416, 1);
#nullable restore
#line 14 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
WriteAttributeValue("", 391, Model.NextVideoThumbnail, 391, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                     class=\"img-responsive\">\r\n");
#nullable restore
#line 16 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"panel-body\">\r\n");
#nullable restore
#line 19 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
             if (Model.NextVideoId == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>COURSE COMPLETED</p>\r\n                <h5>");
#nullable restore
#line 22 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
               Write(Model.CurrentVideoTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 23 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>COMING UP</p>\r\n                <h5>");
#nullable restore
#line 27 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
               Write(Model.NextVideoTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 28 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"btn-group\" role=\"group\">\r\n");
#nullable restore
#line 30 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
             if (Model.PreviousVideoId == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"btn btn-outline-primary\" disabled href=\"#\">\r\n                    <i class=\"fas fa-chevron-left\"></i> Previous\r\n                </a>\r\n");
#nullable restore
#line 35 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d42ac28d7989a843753ab4e3dc7e4a010e428b9f8201", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-chevron-left\"></i> Previous\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1220, "~/Membership/Video/", 1220, 19, true);
#nullable restore
#line 39 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
AddHtmlAttributeValue("", 1239, Model.PreviousVideoId, 1239, 22, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 42 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
            } 

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
             if (Model.NextVideoId == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"btn btn-outline-primary\" disabled href=\"#\">\r\n                Next <i class=\"fas fa-chevron-right\"></i>\r\n            </a>\r\n");
#nullable restore
#line 48 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d42ac28d7989a843753ab4e3dc7e4a010e428b9f10813", async() => {
                WriteLiteral("\r\n                Next <i class=\"fas fa-chevron-right\"></i>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1687, "~/Membership/Video/", 1687, 19, true);
#nullable restore
#line 52 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
AddHtmlAttributeValue("", 1706, Model.NextVideoId, 1706, 18, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 55 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    </div>\r\n");
#nullable restore
#line 59 "D:\Book\deploy\VideoOnDemandtest\VideoOnDemand.UI\Views\Membership\_VideoComingUpPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LessonInfoDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
