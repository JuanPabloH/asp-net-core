#pragma checksum "d:\platzi\asp-net-core\asp-net-core\Views\Asignatura\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1451b51106d9375e6aaa0bbf1b38f198fbcffb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Asignatura_Index), @"mvc.1.0.view", @"/Views/Asignatura/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Asignatura/Index.cshtml", typeof(AspNetCore.Views_Asignatura_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1451b51106d9375e6aaa0bbf1b38f198fbcffb6", @"/Views/Asignatura/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"767e1d73e21edf8f8b2005de957439111a61a136", @"/Views/_ViewImports.cshtml")]
    public class Views_Asignatura_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Asignatura>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ObjetoEscuelaSimple", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "d:\platzi\asp-net-core\asp-net-core\Views\Asignatura\Index.cshtml"
  
    ViewData["Title"] = "Información asignatura";
    Layout="Simple";

#line default
#line hidden
            BeginContext(99, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(104, 17, false);
#line 6 "d:\platzi\asp-net-core\asp-net-core\Views\Asignatura\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(121, 75, true);
            WriteLiteral(" </h1>\r\n\r\n<strong>Desde la vista normal</strong>\r\n    <p>\r\n        Nombre: ");
            EndContext();
            BeginContext(197, 12, false);
#line 10 "d:\platzi\asp-net-core\asp-net-core\Views\Asignatura\Index.cshtml"
           Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(209, 19, true);
            WriteLiteral("<br/>\r\n        Id: ");
            EndContext();
            BeginContext(229, 14, false);
#line 11 "d:\platzi\asp-net-core\asp-net-core\Views\Asignatura\Index.cshtml"
       Write(Model.UniqueId);

#line default
#line hidden
            EndContext();
            BeginContext(243, 55, true);
            WriteLiteral("\r\n    </p>\r\n\r\n<strong>Desde la vista parcial</strong>\r\n");
            EndContext();
            BeginContext(298, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a1451b51106d9375e6aaa0bbf1b38f198fbcffb64751", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(335, 8, true);
            WriteLiteral("\r\n<p><i>");
            EndContext();
            BeginContext(344, 13, false);
#line 16 "d:\platzi\asp-net-core\asp-net-core\Views\Asignatura\Index.cshtml"
 Write(ViewBag.Fecha);

#line default
#line hidden
            EndContext();
            BeginContext(357, 12, true);
            WriteLiteral("</i></p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asignatura> Html { get; private set; }
    }
}
#pragma warning restore 1591