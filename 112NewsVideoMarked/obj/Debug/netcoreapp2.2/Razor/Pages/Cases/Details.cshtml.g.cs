#pragma checksum "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9937d91338c7f2cc5ada57accb281470cf793a42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_112NewsVideoMarked.Pages.Cases.Pages_Cases_Details), @"mvc.1.0.razor-page", @"/Pages/Cases/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Cases/Details.cshtml", typeof(_112NewsVideoMarked.Pages.Cases.Pages_Cases_Details), null)]
namespace _112NewsVideoMarked.Pages.Cases
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\_ViewImports.cshtml"
using _112NewsVideoMarked;

#line default
#line hidden
#line 3 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\_ViewImports.cshtml"
using _112NewsVideoMarked.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9937d91338c7f2cc5ada57accb281470cf793a42", @"/Pages/Cases/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e077bc8ca0d51e286bb1adba3fa09293e5478b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cases_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(105, 132, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>CaseContent</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(238, 60, false);
#line 15 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CaseContent.Photographer));

#line default
#line hidden
            EndContext();
            BeginContext(298, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(360, 56, false);
#line 18 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml"
       Write(Html.DisplayFor(model => model.CaseContent.Photographer));

#line default
#line hidden
            EndContext();
            BeginContext(416, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(477, 53, false);
#line 21 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CaseContent.Title));

#line default
#line hidden
            EndContext();
            BeginContext(530, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(592, 49, false);
#line 24 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml"
       Write(Html.DisplayFor(model => model.CaseContent.Title));

#line default
#line hidden
            EndContext();
            BeginContext(641, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(702, 59, false);
#line 27 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CaseContent.Description));

#line default
#line hidden
            EndContext();
            BeginContext(761, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(823, 55, false);
#line 30 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml"
       Write(Html.DisplayFor(model => model.CaseContent.Description));

#line default
#line hidden
            EndContext();
            BeginContext(878, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(939, 54, false);
#line 33 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CaseContent.Street));

#line default
#line hidden
            EndContext();
            BeginContext(993, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1055, 50, false);
#line 36 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml"
       Write(Html.DisplayFor(model => model.CaseContent.Street));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1166, 52, false);
#line 39 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CaseContent.Town));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1280, 48, false);
#line 42 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml"
       Write(Html.DisplayFor(model => model.CaseContent.Town));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1389, 58, false);
#line 45 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CaseContent.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1509, 54, false);
#line 48 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml"
       Write(Html.DisplayFor(model => model.CaseContent.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1624, 57, false);
#line 51 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CaseContent.Published));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1743, 53, false);
#line 54 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml"
       Write(Html.DisplayFor(model => model.CaseContent.Published));

#line default
#line hidden
            EndContext();
            BeginContext(1796, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1843, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9937d91338c7f2cc5ada57accb281470cf793a4211098", async() => {
                BeginContext(1912, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Details.cshtml"
                           WriteLiteral(Model.CaseContent.CaseContentID);

#line default
#line hidden
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
            EndContext();
            BeginContext(1920, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1928, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9937d91338c7f2cc5ada57accb281470cf793a4213472", async() => {
                BeginContext(1950, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1966, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_112NewsVideoMarked.Pages.Cases.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_112NewsVideoMarked.Pages.Cases.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_112NewsVideoMarked.Pages.Cases.DetailsModel>)PageContext?.ViewData;
        public _112NewsVideoMarked.Pages.Cases.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591