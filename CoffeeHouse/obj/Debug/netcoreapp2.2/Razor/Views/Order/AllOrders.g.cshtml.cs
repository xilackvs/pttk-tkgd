#pragma checksum "C:\Users\GMT\Desktop\Thiết kế giao diện\CoffeeHouse\CoffeeHouse\Views\Order\AllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c246caa30475bbf5c16ebdc381adea6069c1af3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_AllOrders), @"mvc.1.0.view", @"/Views/Order/AllOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/AllOrders.cshtml", typeof(AspNetCore.Views_Order_AllOrders))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c246caa30475bbf5c16ebdc381adea6069c1af3", @"/Views/Order/AllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0294fe7d5e9d617deee3c63d87515446de498248", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_AllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoffeeHouse.ViewModels.ListOrdersWithId>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\GMT\Desktop\Thiết kế giao diện\CoffeeHouse\CoffeeHouse\Views\Order\AllOrders.cshtml"
  
    ViewData["Title"] = "AllOrders";
    

#line default
#line hidden
#line 5 "C:\Users\GMT\Desktop\Thiết kế giao diện\CoffeeHouse\CoffeeHouse\Views\Order\AllOrders.cshtml"
     if (User.IsInRole("Admin") == true)
    {
        Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";
    }
    else
    {
        Layout = "~/Areas/Staff/Views/Shared/_LayoutStaff.cshtml";
    }

#line default
#line hidden
            BeginContext(313, 23, true);
            WriteLiteral("\r\n<h1>Đơn hàng</h1>\r\n\r\n");
            EndContext();
            BeginContext(337, 43, false);
#line 18 "C:\Users\GMT\Desktop\Thiết kế giao diện\CoffeeHouse\CoffeeHouse\Views\Order\AllOrders.cshtml"
Write(await Html.PartialAsync("OrderList", Model));

#line default
#line hidden
            EndContext();
            BeginContext(380, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoffeeHouse.ViewModels.ListOrdersWithId> Html { get; private set; }
    }
}
#pragma warning restore 1591