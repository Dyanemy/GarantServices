#pragma checksum "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc47a4590cc95753d9ae2df6c095af04a17cd1f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Deals_GarantDealProcess), @"mvc.1.0.view", @"/Views/Deals/GarantDealProcess.cshtml")]
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
#line 1 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\_ViewImports.cshtml"
using Garant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\_ViewImports.cshtml"
using Garant.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc47a4590cc95753d9ae2df6c095af04a17cd1f2", @"/Views/Deals/GarantDealProcess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9845bc7e311186d9424a6f76a349412b22d09730", @"/Views/_ViewImports.cshtml")]
    public class Views_Deals_GarantDealProcess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-2 mb-3 button btn  btn-lg btn-block text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Deals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompleateDeal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptDealByExecutor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelDeal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GarantDealProcess", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
   Layout = "_Layout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container text-center text-gradient mt-5 mb-1\">\r\n    <h1>Активная сделка</h1>\r\n    <hr>\r\n</div>\r\n\r\n<span class=\"border border-primary\">\r\n    <div class=\"col-md-12 order-md-1\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc47a4590cc95753d9ae2df6c095af04a17cd1f26276", async() => {
                WriteLiteral("\r\n\r\n            <div class=\"mb-3\">\r\n                <label for=\"NameOfDeal\">Название сделки: ");
#nullable restore
#line 14 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
                                                    Write(ViewBag.DealInfo.NameDeal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n            <div class=\" mb-3\">\r\n                <label for=\"NumberOfDeal\">Номер заказа: ");
#nullable restore
#line 17 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
                                                   Write(ViewBag.DealInfo.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"mb-3\">\r\n                <label for=\"Status\">Статус: ");
#nullable restore
#line 20 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
                                       Write(ViewBag.DealInfo.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"mb-3\">\r\n                <label for=\"DateOfCreate\">Дата создания: ");
#nullable restore
#line 23 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
                                                    Write(ViewBag.DealInfo.DataCreated.ToString("d"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"mb-3\">\r\n                <label for=\"DateOfEnd\">Дата завершения: ");
#nullable restore
#line 26 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
                                                   Write(ViewBag.DealInfo.DataFinish.ToString("d"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"mb-3\">\r\n                <label for=\"NameOfCreator\">Имя заказчика: ");
#nullable restore
#line 29 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
                                                     Write(ViewBag.Author.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"mb-3\">\r\n                <label for=\"Summ\">Сумма: ");
#nullable restore
#line 32 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
                                    Write(ViewBag.DealInfo.QurencySumma);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n\r\n            <div class=\"mb-3\">\r\n                <label for=\"About\">Пояснение задачи</label>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"mb-3\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
               Write(ViewBag.DealInfo.Explanation);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <br />\r\n            </div>\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 45 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
                 if (ViewBag.QDeal.Status != "Завершена" && ViewBag.QDeal.Status != "Отменена")
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
                     if (ViewBag.Author.UserName == User.Identity.Name && ViewBag.QDeal.IdAuthor == ViewBag.Author.Id && ViewBag.QDeal.Status == "В выполнении")
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"col-md-3\"> </div>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc47a4590cc95753d9ae2df6c095af04a17cd1f210763", async() => {
                    WriteLiteral("Завершить заказ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 50 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
                                                                                                                                                                                 }
                            else if (ViewBag.Executor.UserName == User.Identity.Name && ViewBag.QDeal.IdExecutor == ViewBag.Executor.Id && ViewBag.QDeal.Status == "В ожидании подтверждения")
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"col-md-3\"> </div>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc47a4590cc95753d9ae2df6c095af04a17cd1f212960", async() => {
                    WriteLiteral("Подтвердить заказ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("                ");
#nullable restore
#line 54 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
                                                                                                                                                                                                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
                                     if (ViewBag.QDeal.IdAuthor == ViewBag.Author.Id && ViewBag.Author.UserName == User.Identity.Name)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-md-1\"> </div>\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc47a4590cc95753d9ae2df6c095af04a17cd1f215367", async() => {
                    WriteLiteral("Отменить заказ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("                ");
#nullable restore
#line 58 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
                                                                                                                                                                                                     }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <div class=\"col-md-1\"> </div>\r\n                                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc47a4590cc95753d9ae2df6c095af04a17cd1f217487", async() => {
                    WriteLiteral("Перейти в ЛС");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3255, "~/chat/", 3255, 7, true);
#nullable restore
#line 61 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
AddHtmlAttributeValue("", 3262, ViewBag.DialogID, 3262, 17, false);

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
                WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\dmitry\Desktop\GarantServices\Garant\Views\Deals\GarantDealProcess.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</span>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
