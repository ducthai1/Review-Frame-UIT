#pragma checksum "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb/firstWeb/Views/Khoa/LietKeKhoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e996e2541057ee85981c5be2a49a0c9589fc0ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Khoa_LietKeKhoa), @"mvc.1.0.view", @"/Views/Khoa/LietKeKhoa.cshtml")]
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
#line 1 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb/firstWeb/Views/_ViewImports.cshtml"
using firstWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb/firstWeb/Views/_ViewImports.cshtml"
using firstWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e996e2541057ee85981c5be2a49a0c9589fc0ff", @"/Views/Khoa/LietKeKhoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea9515439e0332af4f526c5f2070991c3ff06d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Khoa_LietKeKhoa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<firstWeb.Models.Khoa>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb/firstWeb/Views/Khoa/LietKeKhoa.cshtml"
  
    ViewData["Title"] = "Liệt kê khoa";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Danh Sách các Album</h2>\r\n<table border=\"1\">\r\n    <tr>\r\n        <th>Mã Khoa</th>\r\n        <th>Tên Khoa</th>\r\n        <th>Chức năng</th>\r\n\r\n\r\n    </tr>\r\n\r\n");
#nullable restore
#line 16 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb/firstWeb/Views/Khoa/LietKeKhoa.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 20 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb/firstWeb/Views/Khoa/LietKeKhoa.cshtml"
           Write(item.MaKhoa);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 24 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb/firstWeb/Views/Khoa/LietKeKhoa.cshtml"
           Write(item.TenKhoa);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 479, "\"", 512, 2);
            WriteAttributeValue("", 486, "DeleteKhoa?Id=", 486, 14, true);
#nullable restore
#line 27 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb/firstWeb/Views/Khoa/LietKeKhoa.cshtml"
WriteAttributeValue("", 500, item.MaKhoa, 500, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 541, "\"", 572, 2);
            WriteAttributeValue("", 548, "ViewKhoa?Id=", 548, 12, true);
#nullable restore
#line 28 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb/firstWeb/Views/Khoa/LietKeKhoa.cshtml"
WriteAttributeValue("", 560, item.MaKhoa, 560, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a>\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 32 "/Users/XuanHung/Teach/FrameWork/code/netcore/firstWeb/firstWeb/Views/Khoa/LietKeKhoa.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<firstWeb.Models.Khoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591