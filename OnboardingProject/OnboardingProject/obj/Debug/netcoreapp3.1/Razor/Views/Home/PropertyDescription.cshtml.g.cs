#pragma checksum "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyDescription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "776961be2fe56b99274a985bb2d9a6d7d1140ff1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PropertyDescription), @"mvc.1.0.view", @"/Views/Home/PropertyDescription.cshtml")]
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
#line 1 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\_ViewImports.cshtml"
using OnboardingProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\_ViewImports.cshtml"
using OnboardingProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"776961be2fe56b99274a985bb2d9a6d7d1140ff1", @"/Views/Home/PropertyDescription.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24c25fcd3c65bbbc09c5fc0fa90cfc6000d3e9e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_PropertyDescription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PropertyDescriptionModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyDescription.cshtml"
  
    ViewData["Title"] = "Property Description";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyDescription.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Here is all available info on the selected property.</p>\r\n\r\n<div>\r\n    <b>Address: </b>\r\n    ");
#nullable restore
#line 13 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyDescription.cshtml"
Write(Html.ActionLink(@Model.property.Address, "UpdateProperty", "Home", new { propertyID = Model.property.Id, index = 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <hr />\r\n</div>\r\n<div>\r\n    <b>Description: </b>\r\n    ");
#nullable restore
#line 18 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyDescription.cshtml"
Write(Html.ActionLink(@Model.property.Description, "UpdateProperty", "Home", new { propertyID = Model.property.Id, index = 2 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <hr />\r\n</div>\r\n<div>\r\n    <b>Surface Area (m2): </b>\r\n    ");
#nullable restore
#line 23 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyDescription.cshtml"
Write(Html.ActionLink(@Model.property.Surface.ToString(), "UpdateProperty", "Home", new { propertyID = Model.property.Id, index = 3 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <hr />\r\n</div>\r\n<div>\r\n    <b>Services: </b>\r\n    ");
#nullable restore
#line 28 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyDescription.cshtml"
Write(Html.ActionLink(@Model.property.Services, "UpdateProperty", "Home", new { propertyID = Model.property.Id, index = 4 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <hr />\r\n</div>\r\n\r\n<p>Rooms in the property: </p>\r\n\r\n");
#nullable restore
#line 34 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyDescription.cshtml"
 foreach(var item in Model.rooms)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 37 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyDescription.cshtml"
   Write(Html.ActionLink(item.description, "RoomDescription", "Home", new { roomID = item.roomID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <hr />\r\n    </div>\r\n");
#nullable restore
#line 40 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyDescription.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PropertyDescriptionModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
