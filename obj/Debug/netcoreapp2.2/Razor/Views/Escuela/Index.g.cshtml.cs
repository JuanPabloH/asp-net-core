#pragma checksum "d:\platzi\asp-net-core\asp-net-core\Views\Escuela\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0be1a699d5ceebbb80ceda7881a2b92abb8f491"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Escuela/Index.cshtml", typeof(AspNetCore.Views_Escuela_Index))]
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
#line 1 "d:\platzi\asp-net-core\asp-net-core\Views\_ViewImports.cshtml"
using asp_net_core;

#line default
#line hidden
#line 2 "d:\platzi\asp-net-core\asp-net-core\Views\_ViewImports.cshtml"
using asp_net_core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0be1a699d5ceebbb80ceda7881a2b92abb8f491", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"767e1d73e21edf8f8b2005de957439111a61a136", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "d:\platzi\asp-net-core\asp-net-core\Views\Escuela\Index.cshtml"
  
    ViewData["Title"] = "Información escuela";
    Layout="Simple";

#line default
#line hidden
            BeginContext(93, 31, true);
            WriteLiteral("<h1>Escuela </h1>\r\n<h2>Nombre: ");
            EndContext();
            BeginContext(125, 12, false);
#line 7 "d:\platzi\asp-net-core\asp-net-core\Views\Escuela\Index.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(137, 28, true);
            WriteLiteral("</h2>\r\n<h3>Tipo de escuela: ");
            EndContext();
            BeginContext(166, 17, false);
#line 8 "d:\platzi\asp-net-core\asp-net-core\Views\Escuela\Index.cshtml"
                Write(Model.TipoEscuela);

#line default
#line hidden
            EndContext();
            BeginContext(183, 36, true);
            WriteLiteral("</h3>\r\n<address>\r\n    <p>Dirección: ");
            EndContext();
            BeginContext(220, 15, false);
#line 10 "d:\platzi\asp-net-core\asp-net-core\Views\Escuela\Index.cshtml"
             Write(Model.Dirección);

#line default
#line hidden
            EndContext();
            BeginContext(235, 19, true);
            WriteLiteral("</p>\r\n    <p>País: ");
            EndContext();
            BeginContext(255, 10, false);
#line 11 "d:\platzi\asp-net-core\asp-net-core\Views\Escuela\Index.cshtml"
        Write(Model.Pais);

#line default
#line hidden
            EndContext();
            BeginContext(265, 20, true);
            WriteLiteral("</p>\r\n    <p>Ciudad ");
            EndContext();
            BeginContext(286, 12, false);
#line 12 "d:\platzi\asp-net-core\asp-net-core\Views\Escuela\Index.cshtml"
         Write(Model.Ciudad);

#line default
#line hidden
            EndContext();
            BeginContext(298, 54, true);
            WriteLiteral("</p>\r\n</address>\r\n<p><strong>Año fundación:  </strong>");
            EndContext();
            BeginContext(353, 19, false);
#line 14 "d:\platzi\asp-net-core\asp-net-core\Views\Escuela\Index.cshtml"
                               Write(Model.AñoDeCreación);

#line default
#line hidden
            EndContext();
            BeginContext(372, 5, true);
            WriteLiteral(" </p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591