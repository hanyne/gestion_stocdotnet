#pragma checksum "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1865cc2bd0f93b087f1635278952fb14cf55947fe0206c317768fd7badc2f490"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Admin_Views_Utilisateur_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Utilisateur/Index.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\_ViewImports.cshtml"
using Gestion_Stock

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\_ViewImports.cshtml"
using Gestion_Stock.Models

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1865cc2bd0f93b087f1635278952fb14cf55947fe0206c317768fd7badc2f490", @"/Areas/Admin/Views/Utilisateur/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cfbb721ece7af6c913b505069f6c648989b0ebaefcfc23948263ca121fee0dbe", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Areas_Admin_Views_Utilisateur_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
       IEnumerable<Utilisateur>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/infos.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/trash.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<br />\n<br />\n<div class=\"border backgroundWhite shadow p-3 mb-5 bg-white rounded\">\n    <div class=\"row\">\n        <div class=\"col-6\">\n            <h2 class=\"text-info\"> Users List</h2>\n        </div>\n        <div class=\"col-6 text-right\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1865cc2bd0f93b087f1635278952fb14cf55947fe0206c317768fd7badc2f4907414", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i> &nbsp; New Employee Registeration");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n    <br />\n    <div>\n");
#nullable restore
#line 21 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <table class=\"table table-striped border\">\n                <tr class=\"table-secondary\">\n                    <th>\n                        ");
            Write(
#nullable restore
#line 26 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
                         Html.DisplayNameFor(m => m.nom)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            Write(
#nullable restore
#line 29 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
                         Html.DisplayNameFor(m => m.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            Write(
#nullable restore
#line 32 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
                         Html.DisplayNameFor(m => m.PhoneNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            Write(
#nullable restore
#line 35 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
                         Html.DisplayNameFor(m => m.codePostal)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            Write(
#nullable restore
#line 38 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
                         Html.DisplayNameFor(m => m.address)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                    </th>\n                    <th>\n                        Operations\n                    </th>\n                </tr>\n");
#nullable restore
#line 44 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <tr>\n                <td>\n                    ");
            Write(
#nullable restore
#line 48 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
                     Html.DisplayFor(m => item.nom)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            Write(
#nullable restore
#line 51 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
                     Html.DisplayFor(m => item.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            Write(
#nullable restore
#line 54 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
                     Html.DisplayFor(m => item.PhoneNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            Write(
#nullable restore
#line 57 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
                     Html.DisplayFor(m => item.codePostal)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            Write(
#nullable restore
#line 60 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
                     Html.DisplayFor(m => item.address)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                </td>\n\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1865cc2bd0f93b087f1635278952fb14cf55947fe0206c317768fd7badc2f49013864", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1865cc2bd0f93b087f1635278952fb14cf55947fe0206c317768fd7badc2f49014105", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 64 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
                                                        item.Id

#line default
#line hidden
#nullable disable
            );
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
            WriteLiteral(" |\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1865cc2bd0f93b087f1635278952fb14cf55947fe0206c317768fd7badc2f49017212", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1865cc2bd0f93b087f1635278952fb14cf55947fe0206c317768fd7badc2f49017453", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 65 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
                                                           item.Id

#line default
#line hidden
#nullable disable
            );
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
            WriteLiteral(" |\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1865cc2bd0f93b087f1635278952fb14cf55947fe0206c317768fd7badc2f49020563", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1865cc2bd0f93b087f1635278952fb14cf55947fe0206c317768fd7badc2f49020804", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 66 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
                                                          item.Id

#line default
#line hidden
#nullable disable
            );
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
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 69 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </table>\n");
#nullable restore
#line 71 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <p>No category exists...</p>\n");
#nullable restore
#line 75 "C:\Users\eki\Downloads\Gestion_Stock-master\Gestion_Stock-master\Gestion_Stock\Areas\Admin\Views\Utilisateur\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </div>\n</div>\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Utilisateur>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
