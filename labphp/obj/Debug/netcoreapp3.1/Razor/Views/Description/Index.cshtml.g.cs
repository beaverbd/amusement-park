#pragma checksum "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3007b888cff73beac934bed4fec5aea7dfb341d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Description_Index), @"mvc.1.0.view", @"/Views/Description/Index.cshtml")]
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
#line 1 "C:\Users\dimon\source\repos\labphp\labphp\Views\_ViewImports.cshtml"
using AmusementPark;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dimon\source\repos\labphp\labphp\Views\_ViewImports.cshtml"
using AmusementPark.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3007b888cff73beac934bed4fec5aea7dfb341d1", @"/Views/Description/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b27a75b52b4736c100db31ab1bcc4fa9acd8ec05", @"/Views/_ViewImports.cshtml")]
    public class Views_Description_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AmusementPark.Models.SubscriptionsList>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"w-100 text-light center bg\">");
#nullable restore
#line 5 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
                                      Write(item.Subscription.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div>\r\n        <p class=\"m-0 p-1\"> ");
#nullable restore
#line 7 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
                       Write(item.Subscription.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"m-0 p-1\"><b>Количество аттракционов:</b> ");
#nullable restore
#line 8 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
                                                      Write(item.attractions.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"m-0 p-1\"><b>Количество дополнительных услуг:</b> ");
#nullable restore
#line 9 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
                                                              Write(item.attractions.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"m-0 p-1\"><b>Стоимость взрослого билета:</b> ");
#nullable restore
#line 10 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
                                                         Write(item.Subscription.AdultPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"m-0 p-1\"><b>Стоимость детского билета:</b> ");
#nullable restore
#line 11 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
                                                        Write(item.Subscription.ChildPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <p>\r\n        <h4>Аттракционы:</h4>\r\n    </p>\r\n");
#nullable restore
#line 16 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
     foreach (var item1 in item.attractions)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h5><b><u>");
#nullable restore
#line 19 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
                 Write(item1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></b></h5>\r\n            <p class=\"m-0 p-1\">");
#nullable restore
#line 20 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
                          Write(item1.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"m-0 p-1\"><b>Максимальное количество мест:</b> ");
#nullable restore
#line 21 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
                                                               Write(item1.MaxFreeSeat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <br />\r\n");
#nullable restore
#line 24 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <h4>Дополнительные услуги</h4>\r\n    </p>\r\n");
#nullable restore
#line 29 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
     foreach (var item1 in item.services)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h5><b><u>");
#nullable restore
#line 32 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
                 Write(item1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></b></h5>\r\n            <p class=\"m-0 p-1\">");
#nullable restore
#line 33 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
                          Write(item1.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 35 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\dimon\source\repos\labphp\labphp\Views\Description\Index.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AmusementPark.Models.SubscriptionsList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
