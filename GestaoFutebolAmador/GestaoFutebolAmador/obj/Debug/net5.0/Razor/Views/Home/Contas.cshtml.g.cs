#pragma checksum "C:\Users\Cliente\source\repos\GestaoFutebolAmador\GestaoFutebolAmador\Views\Home\Contas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8f94c76a875da0677533d4586fbaf6272c324d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contas), @"mvc.1.0.view", @"/Views/Home/Contas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8f94c76a875da0677533d4586fbaf6272c324d0", @"/Views/Home/Contas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970b522d8e673320ea3e589dbb92c49c76fec302", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GestaoFutebolAmador.Models.Conta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-sm table-striped table-hover table-responsive-md text-center"">
    <thead>
        <tr>
            <th>Tipo</th>
            <th>Conta</th>
            <th>Observacao</th>
            <th>Editar</th>
            <th>Deletar</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\Cliente\source\repos\GestaoFutebolAmador\GestaoFutebolAmador\Views\Home\Contas.cshtml"
             foreach (var conta in @Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\Cliente\source\repos\GestaoFutebolAmador\GestaoFutebolAmador\Views\Home\Contas.cshtml"
                   Write(conta.desc_conta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\Cliente\source\repos\GestaoFutebolAmador\GestaoFutebolAmador\Views\Home\Contas.cshtml"
                   Write(conta.tipo_conta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\Cliente\source\repos\GestaoFutebolAmador\GestaoFutebolAmador\Views\Home\Contas.cshtml"
                   Write(conta.obs_conta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a href=\"#\">Editar</a></td>\r\n                    <td><a href=\"#\">Deletar</a></td>\r\n                </tr>   \r\n");
#nullable restore
#line 28 "C:\Users\Cliente\source\repos\GestaoFutebolAmador\GestaoFutebolAmador\Views\Home\Contas.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GestaoFutebolAmador.Models.Conta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
