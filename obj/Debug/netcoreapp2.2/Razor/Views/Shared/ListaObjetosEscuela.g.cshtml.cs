#pragma checksum "d:\platzi\asp-net-core\asp-net-core\Views\Shared\ListaObjetosEscuela.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0d1e8707afe44e7a8e879ca5b3c59ab41af569f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ListaObjetosEscuela), @"mvc.1.0.view", @"/Views/Shared/ListaObjetosEscuela.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ListaObjetosEscuela.cshtml", typeof(AspNetCore.Views_Shared_ListaObjetosEscuela))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0d1e8707afe44e7a8e879ca5b3c59ab41af569f", @"/Views/Shared/ListaObjetosEscuela.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"767e1d73e21edf8f8b2005de957439111a61a136", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ListaObjetosEscuela : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 19, true);
            WriteLiteral("\r\n<p>\r\n    Nombre: ");
            EndContext();
            BeginContext(58, 12, false);
#line 5 "d:\platzi\asp-net-core\asp-net-core\Views\Shared\ListaObjetosEscuela.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(70, 15, true);
            WriteLiteral("<br/>\r\n    Id: ");
            EndContext();
            BeginContext(86, 14, false);
#line 6 "d:\platzi\asp-net-core\asp-net-core\Views\Shared\ListaObjetosEscuela.cshtml"
   Write(Model.UniqueId);

#line default
#line hidden
            EndContext();
            BeginContext(100, 172, true);
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table table-dark table-hover\">\r\n  <thead>\r\n    <tr>\r\n    <th scope=\"col\">Nombre</th>\r\n    <th scope=\"col\">Id</th>\r\n    </tr>\r\n  <thead>\r\n  <tbody>\r\n");
            EndContext();
#line 17 "d:\platzi\asp-net-core\asp-net-core\Views\Shared\ListaObjetosEscuela.cshtml"
     foreach(var obj in Model)
    {

#line default
#line hidden
            BeginContext(311, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(334, 10, false);
#line 20 "d:\platzi\asp-net-core\asp-net-core\Views\Shared\ListaObjetosEscuela.cshtml"
       Write(obj.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(344, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(364, 12, false);
#line 21 "d:\platzi\asp-net-core\asp-net-core\Views\Shared\ListaObjetosEscuela.cshtml"
       Write(obj.UniqueId);

#line default
#line hidden
            EndContext();
            BeginContext(376, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 23 "d:\platzi\asp-net-core\asp-net-core\Views\Shared\ListaObjetosEscuela.cshtml"
    }

#line default
#line hidden
            BeginContext(401, 22, true);
            WriteLiteral("  </tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591