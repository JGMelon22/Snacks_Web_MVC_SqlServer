#pragma checksum "/home/joaog/Documents/Snacks_Web_MVC_SqlServer/SnackApp/SnackApp/Views/Shared/Components/CarrinhoCompraResumo/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83b9061c081a8f010f4e17167cfec1aadbc39dcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CarrinhoCompraResumo_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CarrinhoCompraResumo/Default.cshtml")]
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
#line 2 "/home/joaog/Documents/Snacks_Web_MVC_SqlServer/SnackApp/SnackApp/Views/_ViewImports.cshtml"
using SnackApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/joaog/Documents/Snacks_Web_MVC_SqlServer/SnackApp/SnackApp/Views/_ViewImports.cshtml"
using SnackApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/joaog/Documents/Snacks_Web_MVC_SqlServer/SnackApp/SnackApp/Views/_ViewImports.cshtml"
using SnackApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83b9061c081a8f010f4e17167cfec1aadbc39dcf", @"/Views/Shared/Components/CarrinhoCompraResumo/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d301b3e58d8964c087bb9d3a790e7bf2c7cc5ee2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CarrinhoCompraResumo_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarrinhoCompraViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CarrinhoCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/joaog/Documents/Snacks_Web_MVC_SqlServer/SnackApp/SnackApp/Views/Shared/Components/CarrinhoCompraResumo/Default.cshtml"
 if (Model.CarrinhoCompra.CarrinhoCompraItens.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83b9061c081a8f010f4e17167cfec1aadbc39dcf4037", async() => {
                WriteLiteral("\n            <span class=\"glyphicon glyphicon-shopping-cart\"></span>\n            <span id=\"cart-status\">\n                ");
#nullable restore
#line 9 "/home/joaog/Documents/Snacks_Web_MVC_SqlServer/SnackApp/SnackApp/Views/Shared/Components/CarrinhoCompraResumo/Default.cshtml"
           Write(Model.CarrinhoCompra.CarrinhoCompraItens.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </span>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </li>\n");
#nullable restore
#line 13 "/home/joaog/Documents/Snacks_Web_MVC_SqlServer/SnackApp/SnackApp/Views/Shared/Components/CarrinhoCompraResumo/Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarrinhoCompraViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
