#pragma checksum "C:\Users\emiel\Desktop\CreditCards\Application_CreditCard\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5b1d0ca490fd075858594790d874bcd4a292841b4a51cf16ee545dc5209254ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\emiel\Desktop\CreditCards\Application_CreditCard\Views\_ViewImports.cshtml"
using Application_CreditCard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emiel\Desktop\CreditCards\Application_CreditCard\Views\_ViewImports.cshtml"
using Application_CreditCard.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\emiel\Desktop\CreditCards\Application_CreditCard\Views\Home\Index.cshtml"
using Contentful.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5b1d0ca490fd075858594790d874bcd4a292841b4a51cf16ee545dc5209254ab", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0e416024b8b29bba88b60f77a3a3548abc12546e0a65bda6496dd1576986f997", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContentfulCollection<CreditCard>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\emiel\Desktop\CreditCards\Application_CreditCard\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"Credit Cards\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n");
#nullable restore
#line 11 "C:\Users\emiel\Desktop\CreditCards\Application_CreditCard\Views\Home\Index.cshtml"
     foreach (var card in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>");
#nullable restore
#line 13 "C:\Users\emiel\Desktop\CreditCards\Application_CreditCard\Views\Home\Index.cshtml"
       Write(card.Issuer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h2>");
#nullable restore
#line 14 "C:\Users\emiel\Desktop\CreditCards\Application_CreditCard\Views\Home\Index.cshtml"
       Write(card.Fee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h2>");
#nullable restore
#line 15 "C:\Users\emiel\Desktop\CreditCards\Application_CreditCard\Views\Home\Index.cshtml"
       Write(card.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 16 "C:\Users\emiel\Desktop\CreditCards\Application_CreditCard\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentfulCollection<CreditCard>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
