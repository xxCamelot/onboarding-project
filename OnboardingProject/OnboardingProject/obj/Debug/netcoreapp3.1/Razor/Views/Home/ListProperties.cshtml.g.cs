#pragma checksum "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/ListProperties.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "664e97756b18d0f2f81e264bb64cd907db0d8229"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListProperties), @"mvc.1.0.view", @"/Views/Home/ListProperties.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"664e97756b18d0f2f81e264bb64cd907db0d8229", @"/Views/Home/ListProperties.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"665ec9434d84d8079b8bf68fe0a687f6b704b554", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ListProperties : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<PropertyModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/ListProperties.cshtml"
  
    ViewData["Title"] = "List all Properties";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 7 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/ListProperties.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<p>On this page you will see all current properties.</p>\n\n");
#nullable restore
#line 11 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/ListProperties.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        ");
#nullable restore
#line 14 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/ListProperties.cshtml"
   Write(Html.ActionLink(item.address, "PropertyDescription", "Home", new {propertyID = item.PropertyID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <hr />\n    </div>\n");
#nullable restore
#line 17 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/ListProperties.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<PropertyModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
