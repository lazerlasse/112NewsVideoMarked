#pragma checksum "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\Account\Manage\TwoFactorAuthentication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a81af67c62d3a018ad28adf9866103cbf586dec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_112NewsVideoMarked.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_TwoFactorAuthentication), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/TwoFactorAuthentication.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Manage/TwoFactorAuthentication.cshtml", typeof(_112NewsVideoMarked.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_TwoFactorAuthentication), null)]
namespace _112NewsVideoMarked.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\_ViewImports.cshtml"
using _112NewsVideoMarked.Areas.Identity;

#line default
#line hidden
#line 1 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using _112NewsVideoMarked.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using _112NewsVideoMarked.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a81af67c62d3a018ad28adf9866103cbf586dec", @"/Areas/Identity/Pages/Account/Manage/TwoFactorAuthentication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9e268507b3a74f33281836ad8bae08a7668b23f", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425b006bb9aed4437a319f312c67cc45e99feab2", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b36d110a9cba88bba140d864912eb7941cd828aa", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_TwoFactorAuthentication : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./GenerateRecoveryCodes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Disable2fa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("enable-authenticator"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EnableAuthenticator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("reset-authenticator"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ResetAuthenticator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\Account\Manage\TwoFactorAuthentication.cshtml"
  
    ViewData["Title"] = "To-Faktor Godkendelse (2FA)";
    ViewData["ActivePage"] = ManageNavPages.TwoFactorAuthentication;

#line default
#line hidden
            BeginContext(177, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(179, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7a81af67c62d3a018ad28adf9866103cbf586dec8974", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 8 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\Account\Manage\TwoFactorAuthentication.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StatusMessage);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(232, 6, true);
            WriteLiteral("\r\n<h4>");
            EndContext();
            BeginContext(239, 17, false);
#line 9 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\Account\Manage\TwoFactorAuthentication.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(256, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 10 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\Account\Manage\TwoFactorAuthentication.cshtml"
 if (Model.Is2faEnabled)
{
    if (Model.RecoveryCodesLeft == 0)
    {

#line default
#line hidden
            BeginContext(338, 129, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>You have no recovery codes left.</strong>\r\n            <p>You must ");
            EndContext();
            BeginContext(467, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a81af67c62d3a018ad28adf9866103cbf586dec11696", async() => {
                BeginContext(505, 36, true);
                WriteLiteral("generate a new set of recovery codes");
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
            BeginContext(545, 66, true);
            WriteLiteral(" before you can log in with a recovery code.</p>\r\n        </div>\r\n");
            EndContext();
#line 18 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\Account\Manage\TwoFactorAuthentication.cshtml"
    }
    else if (Model.RecoveryCodesLeft == 1)
    {

#line default
#line hidden
            BeginContext(669, 126, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>You have 1 recovery code left.</strong>\r\n            <p>You can ");
            EndContext();
            BeginContext(795, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a81af67c62d3a018ad28adf9866103cbf586dec13647", async() => {
                BeginContext(833, 36, true);
                WriteLiteral("generate a new set of recovery codes");
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
            BeginContext(873, 23, true);
            WriteLiteral(".</p>\r\n        </div>\r\n");
            EndContext();
#line 25 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\Account\Manage\TwoFactorAuthentication.cshtml"
    }
    else if (Model.RecoveryCodesLeft <= 3)
    {

#line default
#line hidden
            BeginContext(954, 72, true);
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            <strong>You have ");
            EndContext();
            BeginContext(1027, 23, false);
#line 29 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\Account\Manage\TwoFactorAuthentication.cshtml"
                        Write(Model.RecoveryCodesLeft);

#line default
#line hidden
            EndContext();
            BeginContext(1050, 58, true);
            WriteLiteral(" recovery codes left.</strong>\r\n            <p>You should ");
            EndContext();
            BeginContext(1108, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a81af67c62d3a018ad28adf9866103cbf586dec15982", async() => {
                BeginContext(1146, 36, true);
                WriteLiteral("generate a new set of recovery codes");
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
            BeginContext(1186, 23, true);
            WriteLiteral(".</p>\r\n        </div>\r\n");
            EndContext();
#line 32 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\Account\Manage\TwoFactorAuthentication.cshtml"
    }

    if (Model.IsMachineRemembered)
    {

#line default
#line hidden
            BeginContext(1261, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1269, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a81af67c62d3a018ad28adf9866103cbf586dec17763", async() => {
                BeginContext(1319, 98, true);
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-primary\">Forget this browser</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1424, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\Account\Manage\TwoFactorAuthentication.cshtml"
    }

#line default
#line hidden
            BeginContext(1433, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1437, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a81af67c62d3a018ad28adf9866103cbf586dec19903", async() => {
                BeginContext(1488, 11, true);
                WriteLiteral("Disable 2FA");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1503, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1509, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a81af67c62d3a018ad28adf9866103cbf586dec21367", async() => {
                BeginContext(1571, 20, true);
                WriteLiteral("Reset recovery codes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1595, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 42 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\Account\Manage\TwoFactorAuthentication.cshtml"
}

#line default
#line hidden
            BeginContext(1600, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\Account\Manage\TwoFactorAuthentication.cshtml"
 if (!Model.HasAuthenticator)
{

#line default
#line hidden
            BeginContext(1636, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1640, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a81af67c62d3a018ad28adf9866103cbf586dec23470", async() => {
                BeginContext(1726, 28, true);
                WriteLiteral("Tilføj To-Faktor Godkendelse");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1758, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 47 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\Account\Manage\TwoFactorAuthentication.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1772, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1776, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a81af67c62d3a018ad28adf9866103cbf586dec25341", async() => {
                BeginContext(1862, 29, true);
                WriteLiteral("Aktiver To-Faktor Godkendelse");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1895, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1901, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a81af67c62d3a018ad28adf9866103cbf586dec26907", async() => {
                BeginContext(1985, 27, true);
                WriteLiteral("Reset To-Faktor Godkendelse");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2016, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 52 "C:\Users\Administrator\OneDrive\Programmering\112NewsVideoMarked\112NewsVideoMarked\Areas\Identity\Pages\Account\Manage\TwoFactorAuthentication.cshtml"
}

#line default
#line hidden
            BeginContext(2021, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2041, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2047, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7a81af67c62d3a018ad28adf9866103cbf586dec28946", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2091, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TwoFactorAuthenticationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TwoFactorAuthenticationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TwoFactorAuthenticationModel>)PageContext?.ViewData;
        public TwoFactorAuthenticationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
