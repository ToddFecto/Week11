#pragma checksum "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\teammember.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89f4bbbc6c98a899f7eedd62c2b4dd279b7a67da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FocPotluck_teammember), @"mvc.1.0.view", @"/Views/FocPotluck/teammember.cshtml")]
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
#line 1 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\_ViewImports.cshtml"
using Assessment8_FOC_Potluck_MySql;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\_ViewImports.cshtml"
using Assessment8_FOC_Potluck_MySql.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89f4bbbc6c98a899f7eedd62c2b4dd279b7a67da", @"/Views/FocPotluck/teammember.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09965deb0c4136e3acec74d6906b75336f209d43", @"/Views/_ViewImports.cshtml")]
    public class Views_FocPotluck_teammember : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamMember>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\teammember.cshtml"
  
    ViewData["Title"] = "teammember";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Team Member Details</h1>\r\n\r\n<div>Name: ");
#nullable restore
#line 8 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\teammember.cshtml"
      Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\teammember.cshtml"
                       Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Email: ");
#nullable restore
#line 9 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\teammember.cshtml"
       Write(Model.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Attendance Date: ");
#nullable restore
#line 10 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\teammember.cshtml"
                 Write(Model.AttendanceDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Guest: ");
#nullable restore
#line 11 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\teammember.cshtml"
       Write(Model.GuestName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 280, "\"", 324, 2);
            WriteAttributeValue("", 287, "/FoCPotluck/editTMform?tmid=", 287, 28, true);
#nullable restore
#line 13 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\teammember.cshtml"
WriteAttributeValue("", 315, Model.id, 315, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">Edit</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamMember> Html { get; private set; }
    }
}
#pragma warning restore 1591