#pragma checksum "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "557afd8900178ecfb3efc3234bd1c0e4d5a87b84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reviser_GetPointsOfInterest), @"mvc.1.0.view", @"/Views/Reviser/GetPointsOfInterest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"557afd8900178ecfb3efc3234bd1c0e4d5a87b84", @"/Views/Reviser/GetPointsOfInterest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b60f060b55dd01c9192fcd525efde6d6e7ef0d11", @"/Views/_ViewImports.cshtml")]
    public class Views_Reviser_GetPointsOfInterest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Geres4U.Models.PointOfInterest>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
  
    ViewData["Title"] = "GetPointsOfInterest";
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
 if (ViewBag.result != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 10 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
  Write(ViewBag.result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 11 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""position: absolute; left: 600px; top: 100px; font-weight: bold;font-size:25px"">Locais a visitar</h1>


    <div class=""dropdown"" style=""position: absolute; background: black; left: 1300px; top: 100px; border-radius: 17.5px"">
        <button class=""btn"" style=""color: white"">
            Filtrar por
        </button>
        <div class=""dropdown-content"" style=""color:black; background: black;height: 2px"">
            <a");
            BeginWriteAttribute("href", " href=\"", 647, "\"", 746, 1);
#nullable restore
#line 21 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 654, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "Monumentos"}), 654, 92, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Monumentos</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 778, "\"", 884, 1);
#nullable restore
#line 22 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 785, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "EdificioReligioso"}), 785, 99, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edifício Religioso</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 924, "\"", 1020, 1);
#nullable restore
#line 23 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 931, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "Cascata"}), 931, 89, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cascata</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1049, "\"", 1143, 1);
#nullable restore
#line 24 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 1056, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "Lagoa"}), 1056, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Lagoa</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1170, "\"", 1271, 1);
#nullable restore
#line 25 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 1177, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "PraiaFluvial"}), 1177, 94, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Praia Fluvial</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1306, "\"", 1404, 1);
#nullable restore
#line 26 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 1313, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "Miradouro"}), 1313, 91, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Miradouro</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1435, "\"", 1535, 1);
#nullable restore
#line 27 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 1442, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "ParqueLazer"}), 1442, 93, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Parque de Lazer</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1572, "\"", 1674, 1);
#nullable restore
#line 28 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 1579, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "ParqueNatural"}), 1579, 95, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Parque Natural</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1710, "\"", 1809, 1);
#nullable restore
#line 29 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 1717, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "Passadicos"}), 1717, 92, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Passadiços</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1841, "\"", 1936, 1);
#nullable restore
#line 30 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 1848, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "Grutas"}), 1848, 88, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Grutas</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1964, "\"", 2058, 1);
#nullable restore
#line 31 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 1971, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "Ponte"}), 1971, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ponte</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2085, "\"", 2186, 1);
#nullable restore
#line 32 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 2092, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "ArteRupestre"}), 2092, 94, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Arte Rupestre</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2221, "\"", 2321, 1);
#nullable restore
#line 33 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 2228, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "Espigueiros"}), 2228, 93, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Espigueiros</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2354, "\"", 2450, 1);
#nullable restore
#line 34 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 2361, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "Trilhos"}), 2361, 89, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trilhos</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2479, "\"", 2574, 1);
#nullable restore
#line 35 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 2486, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "Ecovia"}), 2486, 88, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ecovia</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2602, "\"", 2710, 1);
#nullable restore
#line 36 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 2609, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "EdificioRestauracao"}), 2609, 101, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edificio de Restauração</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2755, "\"", 2850, 1);
#nullable restore
#line 37 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 2762, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "Termas"}), 2762, 88, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Termas</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2878, "\"", 2974, 1);
#nullable restore
#line 38 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 2885, Url.ActionLink("GetPointsOfInterestFromCategory", "Reviser", new {category = "Aldeias"}), 2885, 89, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aldeias</a>\r\n        </div>\r\n    </div>\r\n    \r\n");
#nullable restore
#line 42 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
 if (Model != null && Model.Count() != 0)
{



#line default
#line hidden
#nullable disable
            WriteLiteral("        <dl class=\"row\" style=\"position: absolute; left: 600px;top:200px\">\r\n            \r\n");
#nullable restore
#line 48 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
             foreach (var item in Model)
            {
                var categoryString = item.translateCategory(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dd class=\"col-sm-10\" style=\"font-weight: bold; color: green; font-size: 20px; padding: 30px; float: right\">\r\n                    ");
#nullable restore
#line 52 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dd class=\"col-sm-10\" style=\"float:left\">\r\n");
#nullable restore
#line 55 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
                     if (!String.IsNullOrEmpty(item.ImagePath))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 3671, "\"", 3720, 1);
#nullable restore
#line 57 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 3677, Url.Content("~/Images/" + @item.ImagePath), 3677, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Erro rendering\" width=\"256px\" height=\"256px\"/>\r\n");
#nullable restore
#line 58 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
                    } else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 3854, "\"", 3896, 1);
#nullable restore
#line 60 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
WriteAttributeValue("", 3860, Url.Content("~/Images/noImage.png"), 3860, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Erro rendering\" width=\"256px\" height=\"256px\"/>\r\n");
#nullable restore
#line 61 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </dd>\r\n                <dd class=\"col-sm-10\" style=\"font-weight: bold;padding:10px\">\r\n                    ");
#nullable restore
#line 64 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
               Write(Html.Raw(categoryString));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dd class=\"col-sm-5\" style=\"color: black; font-weight: bold;padding-bottom:30px\">\r\n                    ");
#nullable restore
#line 67 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
               Write(Html.ActionLink("Ler mais", "GetSpecificPointOfInterest", "Reviser", new {id = item.Id, ret = "GetPointsOfInterest"}, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n");
#nullable restore
#line 69 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
                
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dl>\r\n");
#nullable restore
#line 72 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"


} else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 style=\"position: absolute; left: 600px; top: 100px; font-weight: bold;font-size:25px\">Sem pontos disponíveis</h3>\r\n");
#nullable restore
#line 77 "C:\Users\ASUS\Documents\GitHub\LI4-Project\Geres4U\Geres4U\Views\Reviser\GetPointsOfInterest.cshtml"
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