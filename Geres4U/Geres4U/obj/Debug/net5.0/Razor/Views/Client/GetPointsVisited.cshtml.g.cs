#pragma checksum "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Client\GetPointsVisited.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83977824739d36520ee88a24a9534ae7f1d28cc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_GetPointsVisited), @"mvc.1.0.view", @"/Views/Client/GetPointsVisited.cshtml")]
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
#line 1 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\_ViewImports.cshtml"
using Geres4U;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\_ViewImports.cshtml"
using Geres4U.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83977824739d36520ee88a24a9534ae7f1d28cc5", @"/Views/Client/GetPointsVisited.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b60f060b55dd01c9192fcd525efde6d6e7ef0d11", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_GetPointsVisited : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Geres4U.Models.PointOfInterest>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Client\GetPointsVisited.cshtml"
  
    ViewData["Title"] = "GetPointsVisited";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetPointsVisited</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Client\GetPointsVisited.cshtml"
 if (Model != null && Model.Count() != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 16 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Client\GetPointsVisited.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 19 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Client\GetPointsVisited.cshtml"
               Write(Html.DisplayNameFor(model => model.ImagePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Client\GetPointsVisited.cshtml"
               Write(Html.DisplayNameFor(model => model.Lat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Client\GetPointsVisited.cshtml"
               Write(Html.DisplayNameFor(model => model.Long));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Client\GetPointsVisited.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Client\GetPointsVisited.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Client\GetPointsVisited.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ImagePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Client\GetPointsVisited.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Lat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Client\GetPointsVisited.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Long));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Client\GetPointsVisited.cshtml"
                   Write(Html.ActionLink("Details", "GetSpecificPointOfInterest", "Client", new { item.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Client\GetPointsVisited.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 53 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Client\GetPointsVisited.cshtml"
} else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>No points to show</h3>\r\n");
#nullable restore
#line 56 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Client\GetPointsVisited.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Geres4U.Models.PointOfInterest>> Html { get; private set; }
    }
}
#pragma warning restore 1591