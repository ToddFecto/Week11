#pragma checksum "C:\Dev\Week11\GitHubLabTwoG\GitHubLabTwoG\AstrologyVersusAstronomy\Views\Astrology\Horoscope.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a7e77d32d67c545bf99a257d4562b2a5bde6669"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Astrology_Horoscope), @"mvc.1.0.view", @"/Views/Astrology/Horoscope.cshtml")]
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
#line 1 "C:\Dev\Week11\GitHubLabTwoG\GitHubLabTwoG\AstrologyVersusAstronomy\Views\_ViewImports.cshtml"
using AstrologyVersusAstronomy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Week11\GitHubLabTwoG\GitHubLabTwoG\AstrologyVersusAstronomy\Views\_ViewImports.cshtml"
using AstrologyVersusAstronomy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a7e77d32d67c545bf99a257d4562b2a5bde6669", @"/Views/Astrology/Horoscope.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfcd483897c6b142dd9d042fc675350dea408c37", @"/Views/_ViewImports.cshtml")]
    public class Views_Astrology_Horoscope : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AstrologyModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>Since you were born on ");
#nullable restore
#line 2 "C:\Dev\Week11\GitHubLabTwoG\GitHubLabTwoG\AstrologyVersusAstronomy\Views\Astrology\Horoscope.cshtml"
                     Write(Model.BirthMonth);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 2 "C:\Dev\Week11\GitHubLabTwoG\GitHubLabTwoG\AstrologyVersusAstronomy\Views\Astrology\Horoscope.cshtml"
                                        Write(Model.BirthDay);

#line default
#line hidden
#nullable disable
            WriteLiteral(" your astrological sign is: <span class=\"astrology-text\">");
#nullable restore
#line 2 "C:\Dev\Week11\GitHubLabTwoG\GitHubLabTwoG\AstrologyVersusAstronomy\Views\Astrology\Horoscope.cshtml"
                                                                                                                Write(Model.AstrologicalSign);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n<p>Your horoscope:</p>\r\n<p><span class=\"astrology-text\">");
#nullable restore
#line 4 "C:\Dev\Week11\GitHubLabTwoG\GitHubLabTwoG\AstrologyVersusAstronomy\Views\Astrology\Horoscope.cshtml"
                           Write(Model.Horoscope);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n");
            WriteLiteral("<img class=\"image-container\" src=\"https://live.staticflickr.com/7435/11865560284_ce4709848d_b.jpg\"/>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AstrologyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
