#pragma checksum "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/RoomDescription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82f6c9f176262eac0cb98fd1207a59f2d35cc558"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RoomDescription), @"mvc.1.0.view", @"/Views/Home/RoomDescription.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82f6c9f176262eac0cb98fd1207a59f2d35cc558", @"/Views/Home/RoomDescription.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"665ec9434d84d8079b8bf68fe0a687f6b704b554", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_RoomDescription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoomModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/RoomDescription.cshtml"
  
    ViewData["Title"] = "Room Description";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 7 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/RoomDescription.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<p>Here is all available info on the selected room. Select one to edit it.</p>\n\n<div>\n    <b>Description: </b>\n    ");
#nullable restore
#line 13 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/RoomDescription.cshtml"
Write(Html.ActionLink(@Model.description, "Index", "Home", new { roomID = Model.roomID, index = 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <hr />\n</div>\n<div>\n    <b>Beds: </b>\n    ");
#nullable restore
#line 18 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/RoomDescription.cshtml"
Write(Html.ActionLink(@Model.beds.ToString(), "Index", "Home", new { roomID = Model.roomID, index = 2 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <hr />\n</div>\n<div>\n    <b>Surface (m2): </b>\n    ");
#nullable restore
#line 23 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/RoomDescription.cshtml"
Write(Html.ActionLink(@Model.surface.ToString(), "Index", "Home", new { roomID = Model.roomID, index = 3 }));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoomModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
