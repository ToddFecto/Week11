#pragma checksum "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListAllDishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac5f705b52428a819bbc9965dcc14f594a6f2712"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FocPotluck_ListAllDishes), @"mvc.1.0.view", @"/Views/FocPotluck/ListAllDishes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5f705b52428a819bbc9965dcc14f594a6f2712", @"/Views/FocPotluck/ListAllDishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09965deb0c4136e3acec74d6906b75336f209d43", @"/Views/_ViewImports.cshtml")]
    public class Views_FocPotluck_ListAllDishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
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
#line 2 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListAllDishes.cshtml"
  
    ViewData["Title"] = "ListAllDishes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""/css/styles.css"" rel=""stylesheet"" />

<h1>All Team Members Dishes For FoCPotluck</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>id</th>
            <th>TM Name</th>
            <th>TM Phone Number</th>
            <th>Dish Name</th>
            <th>Dish Description</th>
            <th>Category</th>
            <th>Delete</th>
            <th>Edit</th>
            <th></th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 26 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListAllDishes.cshtml"
         foreach (Dish dishes in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 633, "\"", 676, 2);
            WriteAttributeValue("", 640, "/FoCPotluck/teammember?tm=", 640, 26, true);
#nullable restore
#line 29 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListAllDishes.cshtml"
WriteAttributeValue("", 666, dishes.id, 666, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListAllDishes.cshtml"
                                                              Write(dishes.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                <td>");
#nullable restore
#line 30 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListAllDishes.cshtml"
               Write(dishes.TMName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListAllDishes.cshtml"
               Write(dishes.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListAllDishes.cshtml"
               Write(dishes.DishName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListAllDishes.cshtml"
               Write(dishes.DishDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListAllDishes.cshtml"
               Write(dishes.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 966, "\"", 1009, 2);
            WriteAttributeValue("", 973, "/FocPotluck/deletedish?id=", 973, 26, true);
#nullable restore
#line 36 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListAllDishes.cshtml"
WriteAttributeValue("", 999, dishes.id, 999, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac5f705b52428a819bbc9965dcc14f594a6f27127986", async() => {
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
#line 39 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListAllDishes.cshtml"
                                                       WriteLiteral(dishes.id);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Dev\Week11\Assessment8\Assessment8_FOC_Potluck_MySql\Assessment8_FOC_Potluck_MySql\Views\FocPotluck\ListAllDishes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<a href=\"/FocPotluck/Index\" class=\"btn btn-primary\">All TM\'s Attending</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
