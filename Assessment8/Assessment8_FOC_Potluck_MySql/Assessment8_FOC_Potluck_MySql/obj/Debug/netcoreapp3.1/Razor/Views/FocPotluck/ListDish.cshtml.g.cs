#pragma checksum "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cc09ee8641c2d5485cd4129f74b134c655381f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FocPotluck_ListDish), @"mvc.1.0.view", @"/Views/FocPotluck/ListDish.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cc09ee8641c2d5485cd4129f74b134c655381f4", @"/Views/FocPotluck/ListDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09965deb0c4136e3acec74d6906b75336f209d43", @"/Views/_ViewImports.cshtml")]
    public class Views_FocPotluck_ListDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamMemberDishes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditDishform", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListDish.cshtml"
  
    ViewData["Title"] = "ListDish";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Dish Details For TM ");
#nullable restore
#line 6 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListDish.cshtml"
                   Write(Model.tm.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListDish.cshtml"
 foreach (Dish dish in Model.dishes)
 {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    Name: ");
#nullable restore
#line 12 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListDish.cshtml"
     Write(dish.TMName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    Phone Number: ");
#nullable restore
#line 13 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListDish.cshtml"
             Write(dish.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    Dish Name: ");
#nullable restore
#line 14 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListDish.cshtml"
          Write(dish.DishName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    Dish Description: ");
#nullable restore
#line 15 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListDish.cshtml"
                 Write(dish.DishDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    Dish Category: ");
#nullable restore
#line 16 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListDish.cshtml"
              Write(dish.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 375, "\"", 422, 2);
            WriteAttributeValue("", 382, "/FoCPotluck/editDishform?dishid=", 382, 32, true);
#nullable restore
#line 17 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListDish.cshtml"
WriteAttributeValue("", 414, dish.id, 414, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">Edit</a>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cc09ee8641c2d5485cd4129f74b134c655381f46754", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-dishid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListDish.cshtml"
                                       WriteLiteral(dish.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dishid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dishid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dishid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<br />\r\n");
#nullable restore
#line 21 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListDish.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<a href=\"/FoCPotluck/BringADish\" class=\"btn btn-primary\">Add Dish</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamMemberDishes> Html { get; private set; }
    }
}
#pragma warning restore 1591
