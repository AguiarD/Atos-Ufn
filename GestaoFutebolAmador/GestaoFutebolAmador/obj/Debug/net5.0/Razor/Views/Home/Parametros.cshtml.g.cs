#pragma checksum "C:\Users\Cliente\source\repos\GestaoFutebolAmador\GestaoFutebolAmador\Views\Home\Parametros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdcf4e35a7da07efd41635ee905bf895d9ac426d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Parametros), @"mvc.1.0.view", @"/Views/Home/Parametros.cshtml")]
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
#line 1 "C:\Users\Cliente\source\repos\GestaoFutebolAmador\GestaoFutebolAmador\Views\_ViewImports.cshtml"
using GestaoFutebolAmador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cliente\source\repos\GestaoFutebolAmador\GestaoFutebolAmador\Views\_ViewImports.cshtml"
using GestaoFutebolAmador.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdcf4e35a7da07efd41635ee905bf895d9ac426d", @"/Views/Home/Parametros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970b522d8e673320ea3e589dbb92c49c76fec302", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Parametros : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GestaoFutebolAmador.Models.Parametro>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-sm table-striped table-hover table-responsive-md text-center"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Parametro</th>
            <th>Pontos</th>
            <th>Editar</th>
            <th>Deletar</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\Cliente\source\repos\GestaoFutebolAmador\GestaoFutebolAmador\Views\Home\Parametros.cshtml"
         foreach (var parametro in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Cliente\source\repos\GestaoFutebolAmador\GestaoFutebolAmador\Views\Home\Parametros.cshtml"
               Write(parametro.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Cliente\source\repos\GestaoFutebolAmador\GestaoFutebolAmador\Views\Home\Parametros.cshtml"
               Write(parametro.desc_parametro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Cliente\source\repos\GestaoFutebolAmador\GestaoFutebolAmador\Views\Home\Parametros.cshtml"
               Write(parametro.ponto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a href=\"#\">Editar</a></td>\r\n                <td><a href=\"#\">Editar</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Cliente\source\repos\GestaoFutebolAmador\GestaoFutebolAmador\Views\Home\Parametros.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GestaoFutebolAmador.Models.Parametro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
