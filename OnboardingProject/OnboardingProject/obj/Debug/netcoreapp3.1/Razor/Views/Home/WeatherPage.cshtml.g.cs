#pragma checksum "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/WeatherPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b976efde68421a8079258a066d94df56377909c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WeatherPage), @"mvc.1.0.view", @"/Views/Home/WeatherPage.cshtml")]
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
#line 1 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/_ViewImports.cshtml"
using OnboardingProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/_ViewImports.cshtml"
using OnboardingProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b976efde68421a8079258a066d94df56377909c7", @"/Views/Home/WeatherPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"665ec9434d84d8079b8bf68fe0a687f6b704b554", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_WeatherPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OpenWeatherMap>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/WeatherPage.cshtml"
  
    ViewData["Title"] = "Weather in Palermo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 7 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/WeatherPage.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<p>On this page you will see all current properties.</p>\n\n<div>\n    <hr />\n    <b>Region: </b>");
#nullable restore
#line 13 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/WeatherPage.cshtml"
              Write(Model.apiResponse[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <hr />\n    <b>Country: </b>");
#nullable restore
#line 15 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/WeatherPage.cshtml"
               Write(Model.apiResponse[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <hr />\n    <b>Wind Speed: </b>");
#nullable restore
#line 17 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/WeatherPage.cshtml"
                  Write(Model.apiResponse[2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <hr />\n    <b>Temperature: </b>");
#nullable restore
#line 19 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/WeatherPage.cshtml"
                   Write(Model.apiResponse[3]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <hr />\n    <b>Humidity: </b>");
#nullable restore
#line 21 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/WeatherPage.cshtml"
                Write(Model.apiResponse[4]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <hr />\n    <b>Weather: </b>");
#nullable restore
#line 23 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/WeatherPage.cshtml"
               Write(Model.apiResponse[5]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <hr />\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OpenWeatherMap> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
