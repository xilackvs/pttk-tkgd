#pragma checksum "C:\Users\GMT\Desktop\Thiết kế giao diện\CoffeeHouse\CoffeeHouse\Views\Shared\Components\ShoppingCartSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d49ec6018202d46aa6e02fd0a313ea209f1d098"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ShoppingCartSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ShoppingCartSummary/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ShoppingCartSummary/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ShoppingCartSummary_Default))]
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
#line 1 "C:\Users\GMT\Desktop\Thiết kế giao diện\CoffeeHouse\CoffeeHouse\Views\_ViewImports.cshtml"
using CoffeeHouse;

#line default
#line hidden
#line 2 "C:\Users\GMT\Desktop\Thiết kế giao diện\CoffeeHouse\CoffeeHouse\Views\_ViewImports.cshtml"
using CoffeeHouse.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d49ec6018202d46aa6e02fd0a313ea209f1d098", @"/Views/Shared/Components/ShoppingCartSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0294fe7d5e9d617deee3c63d87515446de498248", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ShoppingCartSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoffeeHouse.ViewModels.ShoppingCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\GMT\Desktop\Thiết kế giao diện\CoffeeHouse\CoffeeHouse\Views\Shared\Components\ShoppingCartSummary\Default.cshtml"
 if (Model.ShoppingCartItemsTotal > 0)
{

#line default
#line hidden
            BeginContext(98, 102, true);
            WriteLiteral("    <span class=\"bag d-flex justify-content-center align-items-center\">\r\n        <small>\r\n            ");
            EndContext();
            BeginContext(201, 28, false);
#line 7 "C:\Users\GMT\Desktop\Thiết kế giao diện\CoffeeHouse\CoffeeHouse\Views\Shared\Components\ShoppingCartSummary\Default.cshtml"
       Write(Model.ShoppingCartItemsTotal);

#line default
#line hidden
            EndContext();
            BeginContext(229, 33, true);
            WriteLiteral("\r\n        </small>\r\n    </span>\r\n");
            EndContext();
#line 10 "C:\Users\GMT\Desktop\Thiết kế giao diện\CoffeeHouse\CoffeeHouse\Views\Shared\Components\ShoppingCartSummary\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoffeeHouse.ViewModels.ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
