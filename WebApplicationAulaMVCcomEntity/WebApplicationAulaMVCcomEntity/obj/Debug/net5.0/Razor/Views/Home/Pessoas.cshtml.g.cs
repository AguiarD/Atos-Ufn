#pragma checksum "C:\Users\Cliente\source\repos\WebApplicationAulaMVCcomEntity\WebApplicationAulaMVCcomEntity\Views\Home\Pessoas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afae4415c2e973f842f962694f678b2d83ab50d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Pessoas), @"mvc.1.0.view", @"/Views/Home/Pessoas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afae4415c2e973f842f962694f678b2d83ab50d9", @"/Views/Home/Pessoas.cshtml")]
    public class Views_Home_Pessoas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplicationAulaMVCcomEntity.Models.Pessoa>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Cliente\source\repos\WebApplicationAulaMVCcomEntity\WebApplicationAulaMVCcomEntity\Views\Home\Pessoas.cshtml"
 foreach (var pessoa in @Model)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <strong>");
#nullable restore
#line 12 "C:\Users\Cliente\source\repos\WebApplicationAulaMVCcomEntity\WebApplicationAulaMVCcomEntity\Views\Home\Pessoas.cshtml"
       Write(pessoa.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    <br />\r\n");
#nullable restore
#line 15 "C:\Users\Cliente\source\repos\WebApplicationAulaMVCcomEntity\WebApplicationAulaMVCcomEntity\Views\Home\Pessoas.cshtml"
     foreach (var email in @pessoa.Emails)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Cliente\source\repos\WebApplicationAulaMVCcomEntity\WebApplicationAulaMVCcomEntity\Views\Home\Pessoas.cshtml"
   Write(email.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 19 "C:\Users\Cliente\source\repos\WebApplicationAulaMVCcomEntity\WebApplicationAulaMVCcomEntity\Views\Home\Pessoas.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Cliente\source\repos\WebApplicationAulaMVCcomEntity\WebApplicationAulaMVCcomEntity\Views\Home\Pessoas.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplicationAulaMVCcomEntity.Models.Pessoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
