#pragma checksum "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ed717349741be648a082a2cccde7af8aef17583"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_112NewsVideoMarked.Pages.Cases.Pages_Cases_Delete), @"mvc.1.0.razor-page", @"/Pages/Cases/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Cases/Delete.cshtml", typeof(_112NewsVideoMarked.Pages.Cases.Pages_Cases_Delete), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ed717349741be648a082a2cccde7af8aef17583", @"/Pages/Cases/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e077bc8ca0d51e286bb1adba3fa09293e5478b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cases_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(103, 179, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>CaseContent</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(283, 60, false);
#line 16 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CaseContent.Photographer));

#line default
#line hidden
            EndContext();
            BeginContext(343, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(405, 56, false);
#line 19 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CaseContent.Photographer));

#line default
#line hidden
            EndContext();
            BeginContext(461, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(522, 53, false);
#line 22 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CaseContent.Title));

#line default
#line hidden
            EndContext();
            BeginContext(575, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(637, 49, false);
#line 25 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CaseContent.Title));

#line default
#line hidden
            EndContext();
            BeginContext(686, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(747, 59, false);
#line 28 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CaseContent.Description));

#line default
#line hidden
            EndContext();
            BeginContext(806, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(868, 55, false);
#line 31 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CaseContent.Description));

#line default
#line hidden
            EndContext();
            BeginContext(923, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(984, 54, false);
#line 34 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CaseContent.Street));

#line default
#line hidden
            EndContext();
            BeginContext(1038, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1100, 50, false);
#line 37 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CaseContent.Street));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1211, 52, false);
#line 40 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CaseContent.Town));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1325, 48, false);
#line 43 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CaseContent.Town));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1434, 58, false);
#line 46 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CaseContent.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1492, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1554, 54, false);
#line 49 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CaseContent.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1608, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1669, 57, false);
#line 52 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CaseContent.Published));

#line default
#line hidden
            EndContext();
            BeginContext(1726, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1788, 53, false);
#line 55 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CaseContent.Published));

#line default
#line hidden
            EndContext();
            BeginContext(1841, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1879, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ed717349741be648a082a2cccde7af8aef1758311818", async() => {
                BeginContext(1899, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1909, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ed717349741be648a082a2cccde7af8aef1758312211", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 60 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Pages\Cases\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CaseContent.CaseContentID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1968, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2051, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ed717349741be648a082a2cccde7af8aef1758314170", async() => {
                    BeginContext(2073, 12, true);
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
                BeginContext(2089, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2102, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_112NewsVideoMarked.Pages.Cases.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_112NewsVideoMarked.Pages.Cases.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_112NewsVideoMarked.Pages.Cases.DeleteModel>)PageContext?.ViewData;
        public _112NewsVideoMarked.Pages.Cases.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591