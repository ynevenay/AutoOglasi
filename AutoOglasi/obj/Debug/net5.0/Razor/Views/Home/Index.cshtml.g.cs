#pragma checksum "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f14c6b1d11593ef3e9c074f9dcc1d0772c8b219b43ec5f95f3b51f19393cbe8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f14c6b1d11593ef3e9c074f9dcc1d0772c8b219b43ec5f95f3b51f19393cbe8d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3ea9ba546c0769b6a5f2ea7ea3bf20da2a7b349755cd497b585cc45f88128e89", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f14c6b1d11593ef3e9c074f9dcc1d0772c8b219b43ec5f95f3b51f19393cbe8d3615", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 11 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Home\Index.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - Auto Oglasi</title>
    <link href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"" rel=""stylesheet"" />
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css"" rel=""stylesheet"" />
    <style>
        .carousel-item img {
            width: 100%;
            height: 500px;
            object-fit: cover;
        }

        .feature-icon {
            font-size: 3rem;
        }

        .card-body {
            text-align: center;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f14c6b1d11593ef3e9c074f9dcc1d0772c8b219b43ec5f95f3b51f19393cbe8d5493", async() => {
                WriteLiteral(@"
    <div class=""container mt-5"">
        <!-- Carousel for Featured Cars -->
        <div id=""featuredCarsCarousel"" class=""carousel slide"" data-ride=""carousel"">
            <ol class=""carousel-indicators"">
                <li data-target=""#featuredCarsCarousel"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#featuredCarsCarousel"" data-slide-to=""1""></li>
                <li data-target=""#featuredCarsCarousel"" data-slide-to=""2""></li>
                <li data-target=""#featuredCarsCarousel"" data-slide-to=""3""></li>
                <li data-target=""#featuredCarsCarousel"" data-slide-to=""4""></li>
            </ol>
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <img src=""https://www.topgear.com/sites/default/files/2023/12/1%20Tesla%20Model%20S.jpg"" class=""d-block w-100"" alt=""Featured Car 1"" width=""1200"" height=""500"">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5 c");
                WriteLiteral(@"lass=""text-white"">Tesla</h5>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img src=""https://www.carscoops.com/wp-content/uploads/2019/02/9e7b95fd-2019-audi-a6-avant-tuning-0.jpg"" class=""d-block w-100"" alt=""Featured Car 2"" width=""1200"" height=""500"">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5 class=""text-white"">Audi</h5>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img src=""https://media.drive.com.au/obj/tx_rs:fit:1920:1080,q:50,w:1920/driveau/upload/cms/uploads/smlszj828caqwm4yad86"" class=""d-block w-100"" alt=""Featured Car 3"" width=""1200"" height=""500"">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5 class=""text-white"">Škoda</h5>
                    </div>
                </div>

                <div class=""carousel-item"">
                    <img src=""https");
                WriteLiteral(@"://car-images.bauersecure.com/wp-images/3495/yugo_adventure_01.jpg"" class=""d-block w-100"" alt=""Featured Car 4"" width=""1200"" height=""500"">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5 class=""text-white"">Yugo</h5>
                    </div>
                </div>

                <div class=""carousel-item"">
                    <img src=""https://vrelegume.rs/wp-content/uploads/2019/08/4f2fc7e4-suzuki-jimny-five-door-1.jpg"" class=""d-block w-100"" alt=""Featured Car 5"" width=""1200"" height=""500"">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5 class=""text-white"">Suzuki</h5>
                    </div>
                </div>
            </div>
            <a class=""carousel-control-prev"" href=""#featuredCarsCarousel"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
  ");
                WriteLiteral(@"          <a class=""carousel-control-next"" href=""#featuredCarsCarousel"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>

        <h2 class=""text-center mt-5"">Dobrodošli na sajt Auto Oglasi</h2>
        <p class=""lead text-center"">Otkrijte najbolje ponude automobila. Saznajte više o nama i našim uslugama u nastavku.</p>

        <div class=""row mt-4"">
            <div class=""col-md-4"">
                <div class=""card mb-4"">
                    <div class=""card-body"">
                        <i class=""fas fa-car feature-icon mb-3""></i>
                        <h5 class=""card-title"">Ponuda</h5>
                        <p class=""card-text"">Pregledajte aktuelnu ponudu vozila.</p>
                        <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#adsModal"">Oglasi</button>
                    </div>
             ");
                WriteLiteral(@"   </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mb-4"">
                    <div class=""card-body"">
                        <i class=""fas fa-info-circle feature-icon mb-3""></i>
                        <h5 class=""card-title"">O nama</h5>
                        <p class=""card-text"">Saznajte više o kompaniji i timu.</p>
                        <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#infoModal"">Info</button>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mb-4"">
                    <div class=""card-body"">
                        <i class=""fas fa-envelope feature-icon mb-3""></i>
                        <h5 class=""card-title"">Kontakt</h5>
                        <p class=""card-text"">Kontaktirajte nas za sva pitanja.</p>
                        <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#c");
                WriteLiteral(@"ontactModal"">Kontakt</button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Oglasi popup -->
    <div class=""modal fade"" id=""adsModal"" tabindex=""-1"" aria-labelledby=""adsModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""adsModalLabel"">Upozorenje</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    Morate se prijaviti da biste videli oglase. Da li želite da se prijavite?
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Odustani</button>
                    <a");
                BeginWriteAttribute("href", " href=\"", 6970, "\"", 7008, 1);
#nullable restore
#line 137 "D:\Projekat RVAS\AutoOglasi\AutoOglasi\Views\Home\Index.cshtml"
WriteAttributeValue("", 6977, Url.Action("Index", "Secured"), 6977, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-primary"">Prijavi se</a>
                </div>
            </div>
        </div>
    </div>

    <!-- infoo popup -->
    <div class=""modal fade"" id=""infoModal"" tabindex=""-1"" aria-labelledby=""infoModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""infoModalLabel"">O nama</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    Autor: Nevena Milenkovic, 2024
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Zatvori</button>
                </div>
            </div>
        </div>
    </div>

    <!-- Kont");
                WriteLiteral(@"aktt popup -->
    <div class=""modal fade"" id=""contactModal"" tabindex=""-1"" aria-labelledby=""contactModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""contactModalLabel"">Kontakt</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    Kontaktirajte nas za sva pitanja xD
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Zatvori</button>
                </div>
            </div>
        </div>
    </div>

    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js""></script>
    <script src=""https://stackpath.bootstrapc");
                WriteLiteral("dn.com/bootstrap/4.5.2/js/bootstrap.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591