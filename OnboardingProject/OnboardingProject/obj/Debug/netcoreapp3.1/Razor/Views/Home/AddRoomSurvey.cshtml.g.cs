#pragma checksum "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/AddRoomSurvey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9442d4018019025768d09b6592b95bd4a19efc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddRoomSurvey), @"mvc.1.0.view", @"/Views/Home/AddRoomSurvey.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9442d4018019025768d09b6592b95bd4a19efc2", @"/Views/Home/AddRoomSurvey.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"665ec9434d84d8079b8bf68fe0a687f6b704b554", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_AddRoomSurvey : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoomModel>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/AddRoomSurvey.cshtml"
  
    ViewData["Title"] = "Add new Room";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 8 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/AddRoomSurvey.cshtml"
 using (Html.BeginForm("AddRoomSurveyMethod", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9442d4018019025768d09b6592b95bd4a19efc23921", async() => {
                WriteLiteral("\n        <div>\n            <label for=\"address\">Description:</label>\n            ");
#nullable restore
#line 13 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/AddRoomSurvey.cshtml"
       Write(Html.TextBoxFor(room => room.description, new { @type = "text", @size = "40", @placeholder = "Master Bedroom", @required = "true" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n        <div>\n            <label for=\"description\">Number of beds:</label>\n            ");
#nullable restore
#line 17 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/AddRoomSurvey.cshtml"
       Write(Html.TextBoxFor(room => room.beds, new { @type = "text", @size = "40", @placeholder = "4", @required = "true" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n        <div>\n            <label for=\"surface\">Surface Area (m2):</label>\n            ");
#nullable restore
#line 21 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/AddRoomSurvey.cshtml"
       Write(Html.TextBoxFor(room => room.surface, new { @type = "text", @size = "40", @placeholder = "107.4", @required = "true" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n        ");
#nullable restore
#line 23 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/AddRoomSurvey.cshtml"
   Write(Html.HiddenFor(room => room.descriptions.englishDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 24 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/AddRoomSurvey.cshtml"
   Write(Html.HiddenFor(room => room.descriptions.italianDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 25 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/AddRoomSurvey.cshtml"
   Write(Html.HiddenFor(room => room.descriptions.polishDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 26 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/AddRoomSurvey.cshtml"
   Write(Html.HiddenFor(room => room.propertyID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <div>\n            <input type=\"submit\" value=\"Submit\" />\n        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 31 "/Users/camelot/Documents/GitHub/onboarding-project/OnboardingProject/OnboardingProject/Views/Home/AddRoomSurvey.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n");
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
