#pragma checksum "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\Leagues\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fc1fa1172c6dd5d97a39bfd0842976cf8c1d6049cbfded4d348a59c36b852fac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leagues_Index), @"mvc.1.0.view", @"/Views/Leagues/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\_ViewImports.cshtml"
using coremvcproject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\_ViewImports.cshtml"
using coremvcproject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fc1fa1172c6dd5d97a39bfd0842976cf8c1d6049cbfded4d348a59c36b852fac", @"/Views/Leagues/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2eed0d311c4db1e366ba018e3baa916c82ea25d1cb856c9bc927ab06596ac5fe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Leagues_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<coremvcproject.Model.Leagues>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\Leagues\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc1fa1172c6dd5d97a39bfd0842976cf8c1d6049cbfded4d348a59c36b852fac4357", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\Leagues\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LeaguesId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\Leagues\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LeagueName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\Leagues\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LeagueCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\Leagues\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MostChampTeam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\Leagues\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumbofTeams));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\Leagues\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\Leagues\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LeaguesId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\Leagues\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LeagueName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\Leagues\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LeagueCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\Leagues\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MostChampTeam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\Leagues\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumbofTeams));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\Leagues\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.LeaguesId },new{@class="btn btn-primary"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 53 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\Leagues\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id=item.LeaguesId },new{@class="btn btn-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\pc\Desktop\Katmanlı .Net Core API Code First Project\coremvcproject\coremvcproject\Views\Leagues\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<coremvcproject.Model.Leagues>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
