#pragma checksum "C:\Users\calis\source\repos\Bootcamp_Hw4\Bootcamp_Hw4\Views\Store\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "257f44a82c46355966ba2e1ad09576de0586d1ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Menu), @"mvc.1.0.view", @"/Views/Store/Menu.cshtml")]
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
#line 1 "C:\Users\calis\source\repos\Bootcamp_Hw4\Bootcamp_Hw4\Views\_ViewImports.cshtml"
using Bootcamp_Hw4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\calis\source\repos\Bootcamp_Hw4\Bootcamp_Hw4\Views\_ViewImports.cshtml"
using Bootcamp_Hw4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"257f44a82c46355966ba2e1ad09576de0586d1ff", @"/Views/Store/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77a7500b46d0e428636b1794d52c5d1a4ee3393e", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\calis\source\repos\Bootcamp_Hw4\Bootcamp_Hw4\Views\Store\Menu.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\calis\source\repos\Bootcamp_Hw4\Bootcamp_Hw4\Views\Store\Menu.cshtml"
Write(item.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\calis\source\repos\Bootcamp_Hw4\Bootcamp_Hw4\Views\Store\Menu.cshtml"
              
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
