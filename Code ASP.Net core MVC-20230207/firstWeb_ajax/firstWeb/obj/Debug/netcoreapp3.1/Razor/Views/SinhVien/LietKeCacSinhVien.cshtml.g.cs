#pragma checksum "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb_ajax/firstWeb/Views/SinhVien/LietKeCacSinhVien.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61a7978dfe5a995cff462e390799af54830d7b59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SinhVien_LietKeCacSinhVien), @"mvc.1.0.view", @"/Views/SinhVien/LietKeCacSinhVien.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61a7978dfe5a995cff462e390799af54830d7b59", @"/Views/SinhVien/LietKeCacSinhVien.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea9515439e0332af4f526c5f2070991c3ff06d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_SinhVien_LietKeCacSinhVien : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<firstWeb.Models.SinhVien>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb_ajax/firstWeb/Views/SinhVien/LietKeCacSinhVien.cshtml"
  
    ViewData["Title"] = "Liệt kê sinh viên";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Danh Sách các sinh viên</h2>\r\n<table border=\"1\">\r\n    <tr>\r\n        <th>Mã sinh viên</th>\r\n        <th>Tên sinh viên</th>\r\n        <th>Điểm trung bình</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 14 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb_ajax/firstWeb/Views/SinhVien/LietKeCacSinhVien.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 18 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb_ajax/firstWeb/Views/SinhVien/LietKeCacSinhVien.cshtml"
           Write(item.MaSinhVien);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 22 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb_ajax/firstWeb/Views/SinhVien/LietKeCacSinhVien.cshtml"
           Write(item.TenSinhVien);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb_ajax/firstWeb/Views/SinhVien/LietKeCacSinhVien.cshtml"
           Write(item.DiemTrungBinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb_ajax/firstWeb/Views/SinhVien/LietKeCacSinhVien.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<firstWeb.Models.SinhVien>> Html { get; private set; }
    }
}
#pragma warning restore 1591
