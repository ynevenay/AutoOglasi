#pragma checksum "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\Delete.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "705ad801f0d15014e7da0898aa392825d1dbe6637560854a57582d42be7caea6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Delete), @"mvc.1.0.view", @"/Views/Car/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\_ViewImports.cshtml"
using AutoOglasi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\_ViewImports.cshtml"
using AutoOglasi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"705ad801f0d15014e7da0898aa392825d1dbe6637560854a57582d42be7caea6", @"/Views/Car/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3ea9ba546c0769b6a5f2ea7ea3bf20da2a7b349755cd497b585cc45f88128e89", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Car_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AutoOglasi.Models.Car>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MojiOglasi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">

            <h3 class=""fw-bold mb-3"">Da li ste sigurni da želite da obrišete oglas?</h3>
            <br />

            <div class=""row"">
                <div class=""col-md-6 justify-content-center"">
                    <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                        <ol class=""carousel-indicators"">
");
#nullable restore
#line 19 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\Delete.cshtml"
                             for (int i = 0; i < Model.Images.Count; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 21 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\Delete.cshtml"
                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 779, "\"", 814, 1);
#nullable restore
#line 21 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\Delete.cshtml"
WriteAttributeValue("", 787, (i == 0) ? "active" : "", 787, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></li>\r\n");
#nullable restore
#line 22 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\Delete.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ol>\r\n                        <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 25 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\Delete.cshtml"
                             foreach (var image in Model.Images)
                            {
                                var base64Image = Convert.ToBase64String(image.AsByteArray);
                                var imgSrc = $"data:image/jpeg;base64,{base64Image}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("class", " class=\"", 1253, "\"", 1325, 2);
            WriteAttributeValue("", 1261, "carousel-item", 1261, 13, true);
#nullable restore
#line 29 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\Delete.cshtml"
WriteAttributeValue(" ", 1274, (image == Model.Images.First()) ? "active" : "", 1275, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1369, "\"", 1382, 1);
#nullable restore
#line 30 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\Delete.cshtml"
WriteAttributeValue("", 1375, imgSrc, 1375, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\" alt=\"Slika auta\" width=\"400\" height=\"500\">\r\n                                </div>\r\n");
#nullable restore
#line 32 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\Delete.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                            <span class=""sr-only"">Previous</span>
                        </a>
                        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                            <span class=""sr-only"">Next</span>
                        </a>
                    </div>
                </div>
            </div>

            <br />

            <div class=""card border-dark mb-3"" style=""width: 50%; padding:2em;"">
                <div class=""card-header"">Informacije o vozilu</div>
                <hr>
                <div class=""col-md-6"">
                    <h5>");
#nullable restore
#line 52 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 52 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\Delete.cshtml"
                                                          Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p>Godište: ");
#nullable restore
#line 53 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Cena: ");
#nullable restore
#line 54 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\Delete.cshtml"
                        Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("€</p>\r\n                </div>\r\n                <br />\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "705ad801f0d15014e7da0898aa392825d1dbe6637560854a57582d42be7caea610716", async() => {
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-danger me-2\">Obriši</button>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "705ad801f0d15014e7da0898aa392825d1dbe6637560854a57582d42be7caea611112", async() => {
                    WriteLiteral("Nazad na moje oglase");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'.carousel\').carousel();\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AutoOglasi.Models.Car> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
