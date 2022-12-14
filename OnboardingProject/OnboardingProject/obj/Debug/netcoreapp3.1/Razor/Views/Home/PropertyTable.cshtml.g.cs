#pragma checksum "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5233260c91fe21fe50df075c910980a29fb6d876"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PropertyTable), @"mvc.1.0.view", @"/Views/Home/PropertyTable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5233260c91fe21fe50df075c910980a29fb6d876", @"/Views/Home/PropertyTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24c25fcd3c65bbbc09c5fc0fa90cfc6000d3e9e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_PropertyTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TableModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <table class=""arrowes-table table-striped"">
        <thead>
            <tr>
                <th>Property Address</th>
                <th>Property Description</th>
                <th>Surface Area (m2)</th>
                <th>Services</th>
                <th>Room Description</th>
                <th>Room Surface Area (m2)</th>
                <th>Beds in Room</th>
                <th>Delete Room</th>
                <th>Delete Property</th>
            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 20 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
             foreach (var property in Model.properties)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td width=\"21%\">\r\n                        ");
#nullable restore
#line 24 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                   Write(Html.ActionLink(property.Address, "UpdateProperty", "Home", new { propertyID = property.Id, index = 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td width=\"14%\">\r\n                        ");
#nullable restore
#line 27 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                   Write(Html.ActionLink(property.Description, "UpdateProperty", "Home", new { propertyID = property.Id, index = 2 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td width=\"5%\">\r\n                        ");
#nullable restore
#line 30 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                   Write(Html.ActionLink(property.Surface.ToString(), "UpdateProperty", "Home", new { propertyID = property.Id, index = 3 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td width=\"17%\">\r\n                        ");
#nullable restore
#line 33 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                   Write(Html.ActionLink(property.Services, "UpdateProperty", "Home", new { propertyID = property.Id, index = 4 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td width=\"18%\">\r\n                        <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 37 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                             foreach (var item in Model.rooms)
                            {
                                if (item.PropertyId == property.Id)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 41 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                                   Write(Html.ActionLink(@item.Description, "UpdateRoom", "Home", new { roomID = item.Id, index = 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 42 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </td>\r\n                    <td width=\"10%\">\r\n                        <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 48 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                             foreach (var item in Model.rooms)
                            {
                                if (item.PropertyId == property.Id)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 52 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                                   Write(Html.ActionLink(@item.Surface.ToString(), "UpdateRoom", "Home", new { roomID = item.Id, index = 3 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 53 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </td>\r\n                    <td width=\"5%\">\r\n                        <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 59 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                             foreach (var item in Model.rooms)
                            {
                                if (item.PropertyId == property.Id)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 63 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                                   Write(Html.ActionLink(@item.Beds.ToString(), "UpdateRoom", "Home", new { roomID = item.Id, index = 2 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 64 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </td>\r\n                    <td width=\"5%\">\r\n                        <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 70 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                             foreach (var item in Model.rooms)
                            {
                                if (item.PropertyId == property.Id)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 74 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                                   Write(Html.ActionLink("X", "DeleteConfirmation", "Home", new { ID = item.Id, index = 2 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 75 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </td>\r\n                    <td width=\"5%\">\r\n                        ");
#nullable restore
#line 80 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
                   Write(Html.ActionLink("X", "DeleteConfirmation", "Home", new { ID = property.Id, index = 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 83 "C:\Users\camillo.gregorio\Documents\GitHub\onboarding-project\OnboardingProject\OnboardingProject\Views\Home\PropertyTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TableModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
