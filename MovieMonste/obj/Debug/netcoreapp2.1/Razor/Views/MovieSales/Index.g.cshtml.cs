#pragma checksum "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieSales\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5b6af2b0f71fe18ca53e1ea6a9f120b4978d7a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieSales_Index), @"mvc.1.0.view", @"/Views/MovieSales/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MovieSales/Index.cshtml", typeof(AspNetCore.Views_MovieSales_Index))]
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
#line 1 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\_ViewImports.cshtml"
using MovieMonste;

#line default
#line hidden
#line 2 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\_ViewImports.cshtml"
using MovieMonste.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5b6af2b0f71fe18ca53e1ea6a9f120b4978d7a6", @"/Views/MovieSales/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78338f5f3a8cf37a20e316c1ab34cd69d67d63f4", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieSales_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieMonste.Models.MovieSale>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieSales\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(122, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab44491a2845421ba54e770722208534", async() => {
                BeginContext(145, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(159, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(252, 40, false);
#line 16 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieSales\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sale));

#line default
#line hidden
            EndContext();
            BeginContext(292, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(348, 41, false);
#line 19 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieSales\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie));

#line default
#line hidden
            EndContext();
            BeginContext(389, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(445, 44, false);
#line 22 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieSales\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(489, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieSales\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(607, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(656, 46, false);
#line 31 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieSales\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sale.SaleID));

#line default
#line hidden
            EndContext();
            BeginContext(702, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(758, 46, false);
#line 34 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieSales\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Movie.Title));

#line default
#line hidden
            EndContext();
            BeginContext(804, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(860, 43, false);
#line 37 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieSales\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(903, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
            BeginContext(1036, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1053, 85, false);
#line 41 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieSales\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { SaleID = item.SaleID, MovieID = item.MovieID }));

#line default
#line hidden
            EndContext();
            BeginContext(1138, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1159, 91, false);
#line 42 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieSales\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { SaleID = item.SaleID, MovieID = item.MovieID }));

#line default
#line hidden
            EndContext();
            BeginContext(1250, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1271, 89, false);
#line 43 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieSales\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { SaleID = item.SaleID, MovieID = item.MovieID }));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 46 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieSales\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1399, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieMonste.Models.MovieSale>> Html { get; private set; }
    }
}
#pragma warning restore 1591
