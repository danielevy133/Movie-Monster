#pragma checksum "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieStockOrders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5a69bd7c9b5704b10c20c5bb0f04f9f5ed6ecc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieStockOrders_Index), @"mvc.1.0.view", @"/Views/MovieStockOrders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MovieStockOrders/Index.cshtml", typeof(AspNetCore.Views_MovieStockOrders_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5a69bd7c9b5704b10c20c5bb0f04f9f5ed6ecc1", @"/Views/MovieStockOrders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78338f5f3a8cf37a20e316c1ab34cd69d67d63f4", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieStockOrders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieMonste.Models.MovieStockOrder>>
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieStockOrders\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(99, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(128, 37, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db1fda75823f4330a2cf96ba013b3266", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "074bc95235ea47dabcad2eea77a91d17", async() => {
>>>>>>> d7dd3a0c0866b00e051d60bf2ec16ceab38f726b
                BeginContext(151, 10, true);
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
            BeginContext(165, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(258, 41, false);
#line 16 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieStockOrders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie));

#line default
#line hidden
            EndContext();
            BeginContext(299, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(355, 46, false);
#line 19 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieStockOrders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StockOrder));

#line default
#line hidden
            EndContext();
            BeginContext(401, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(457, 44, false);
#line 22 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieStockOrders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(501, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieStockOrders\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(619, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(668, 46, false);
#line 31 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieStockOrders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Movie.Title));

#line default
#line hidden
            EndContext();
            BeginContext(714, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(770, 58, false);
#line 34 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieStockOrders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StockOrder.StockOrderID));

#line default
#line hidden
            EndContext();
            BeginContext(828, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(884, 43, false);
#line 37 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieStockOrders\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(927, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
            BeginContext(1060, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1077, 97, false);
#line 41 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieStockOrders\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { MovieID = item.MovieID, StockOrderID = item.StockOrderID }));

#line default
#line hidden
            EndContext();
            BeginContext(1174, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1195, 103, false);
#line 42 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieStockOrders\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { MovieID = item.MovieID, StockOrderID = item.StockOrderID }));

#line default
#line hidden
            EndContext();
            BeginContext(1298, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1319, 101, false);
#line 43 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieStockOrders\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { MovieID = item.MovieID, StockOrderID = item.StockOrderID }));

#line default
#line hidden
            EndContext();
            BeginContext(1420, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 46 "C:\Users\mulik\Documents\GitHub\Movie-monster\MovieMonste\Views\MovieStockOrders\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1459, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieMonste.Models.MovieStockOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
