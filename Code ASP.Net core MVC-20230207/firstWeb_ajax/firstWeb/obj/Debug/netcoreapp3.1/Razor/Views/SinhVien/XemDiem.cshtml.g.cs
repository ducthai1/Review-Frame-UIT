#pragma checksum "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb_ajax/firstWeb/Views/SinhVien/XemDiem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "138af2609c9b3a6d6acfde1132f84cf2759fc4f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SinhVien_XemDiem), @"mvc.1.0.view", @"/Views/SinhVien/XemDiem.cshtml")]
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
#line 1 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb_ajax/firstWeb/Views/_ViewImports.cshtml"
using firstWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb_ajax/firstWeb/Views/_ViewImports.cshtml"
using firstWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"138af2609c9b3a6d6acfde1132f84cf2759fc4f2", @"/Views/SinhVien/XemDiem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea9515439e0332af4f526c5f2070991c3ff06d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_SinhVien_XemDiem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb_ajax/firstWeb/Views/SinhVien/XemDiem.cshtml"
  
    ViewData["Title"] = "Trang sinh vien";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2> Trang sinh viên</h2>\r\n<p>Đây là trang web thông tin sinh viên</p>\r\n<p>Tên sinh viên:");
#nullable restore
#line 6 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb_ajax/firstWeb/Views/SinhVien/XemDiem.cshtml"
            Write(ViewData["name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Điểm:");
#nullable restore
#line 7 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb_ajax/firstWeb/Views/SinhVien/XemDiem.cshtml"
   Write(ViewData["diem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
