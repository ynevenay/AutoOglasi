#pragma checksum "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\MojiOglasi.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "06ad21d4b7003e87543da3a83ebbcd51cd98eee6f6ffa77b8469126477c72ca4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_MojiOglasi), @"mvc.1.0.view", @"/Views/Car/MojiOglasi.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"06ad21d4b7003e87543da3a83ebbcd51cd98eee6f6ffa77b8469126477c72ca4", @"/Views/Car/MojiOglasi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3ea9ba546c0769b6a5f2ea7ea3bf20da2a7b349755cd497b585cc45f88128e89", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Car_MojiOglasi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AutoOglasi.Models.Car>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br />\r\n<h2>Moji oglasi</h2>\r\n<br />\r\n<div class=\"row\">\r\n");
#nullable restore
#line 7 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\MojiOglasi.cshtml"
     foreach (var ad in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4 mb-4\">\r\n            <div class=\"card\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 230, "\"", 254, 1);
#nullable restore
#line 11 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\MojiOglasi.cshtml"
WriteAttributeValue("", 236, GetFirstImage(ad), 236, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"Car Image\" width=\"300\" height=\"350\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\" font-size: 20px;>");
#nullable restore
#line 13 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\MojiOglasi.cshtml"
                                                       Write(ad.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 13 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\MojiOglasi.cshtml"
                                                                  Write(ad.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <hr />\r\n                    <p class=\"card-text text-center\">\r\n                        <span class=\"badge rounded-pill bg-warning\" style=\"font-size: 16px;\">Godiste: ");
#nullable restore
#line 16 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\MojiOglasi.cshtml"
                                                                                                 Write(ad.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span></span>\r\n                        <span class=\"badge rounded-pill bg-danger\" style=\"font-size: 16px;\">Cena: ");
#nullable restore
#line 18 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\MojiOglasi.cshtml"
                                                                                             Write(ad.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</span>\r\n                    </p>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 855, "\"", 912, 1);
#nullable restore
#line 20 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\MojiOglasi.cshtml"
WriteAttributeValue("", 862, Url.Action("Detaljno", "Car", new { id = ad.Id }), 862, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Detaljno</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 974, "\"", 1027, 1);
#nullable restore
#line 21 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\MojiOglasi.cshtml"
WriteAttributeValue("", 981, Url.Action("Edit", "Car", new { id = ad.Id }), 981, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Izmeni</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1087, "\"", 1142, 1);
#nullable restore
#line 22 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\MojiOglasi.cshtml"
WriteAttributeValue("", 1094, Url.Action("Delete", "Car", new { id = ad.Id }), 1094, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Obrisi</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 26 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\MojiOglasi.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Car\MojiOglasi.cshtml"
            
    string GetFirstImage(AutoOglasi.Models.Car car)
    {
        if (car.Images != null && car.Images.Any())
        {
            var base64Image = Convert.ToBase64String(car.Images[0].AsByteArray);
            return $"data:image/jpeg;base64,{base64Image}";
        }
        return "";
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AutoOglasi.Models.Car>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
