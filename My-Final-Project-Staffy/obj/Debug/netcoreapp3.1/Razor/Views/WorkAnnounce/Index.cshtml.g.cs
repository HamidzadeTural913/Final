#pragma checksum "C:\Users\User\Dropbox\PC\Desktop\My-Final-Project-Staffy\My-Final-Project-Staffy\Views\WorkAnnounce\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91b7219a2079b1f13e3ccdef0e98f3cf7956c4bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkAnnounce_Index), @"mvc.1.0.view", @"/Views/WorkAnnounce/Index.cshtml")]
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
#line 1 "C:\Users\User\Dropbox\PC\Desktop\My-Final-Project-Staffy\My-Final-Project-Staffy\Views\_ViewImports.cshtml"
using My_Final_Project_Staffy.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Dropbox\PC\Desktop\My-Final-Project-Staffy\My-Final-Project-Staffy\Views\_ViewImports.cshtml"
using My_Final_Project_Staffy.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91b7219a2079b1f13e3ccdef0e98f3cf7956c4bd", @"/Views/WorkAnnounce/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2502aae31647f192a9018416ff9dd235a2bf945", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_WorkAnnounce_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Vacation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Dropbox\PC\Desktop\My-Final-Project-Staffy\My-Final-Project-Staffy\Views\WorkAnnounce\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n    <section id=\"company-ano\">\r\n        <div class=\"contain-company\">\r\n");
#nullable restore
#line 9 "C:\Users\User\Dropbox\PC\Desktop\My-Final-Project-Staffy\My-Final-Project-Staffy\Views\WorkAnnounce\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""company-box "">
                    <div class=""up-content"">
                        <div class=""right-content"">
                            <div class=""announce-imgg"">
                                <img src=""./assets/images/Company.png """);
            BeginWriteAttribute("alt", " alt=\"", 473, "\"", 479, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </div>\r\n                            <div>\r\n                                <h4><a href=\"detail.html\">");
#nullable restore
#line 18 "C:\Users\User\Dropbox\PC\Desktop\My-Final-Project-Staffy\My-Final-Project-Staffy\Views\WorkAnnounce\Index.cshtml"
                                                     Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h4>

                                <p>Sirket</p>
                            </div>
                        </div>
                        <div class=""left-content"">
                            <i class=""fa-regular fa-bookmark""></i>
                        </div>
                    </div>
                    <div class=""main mt-3"">
                        <ul>
                            <li class=""main-1""><a");
            BeginWriteAttribute("href", " href=\"", 1057, "\"", 1064, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-wallet\"></i>");
#nullable restore
#line 29 "C:\Users\User\Dropbox\PC\Desktop\My-Final-Project-Staffy\My-Final-Project-Staffy\Views\WorkAnnounce\Index.cshtml"
                                                                                       Write(item.MinSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 29 "C:\Users\User\Dropbox\PC\Desktop\My-Final-Project-Staffy\My-Final-Project-Staffy\Views\WorkAnnounce\Index.cshtml"
                                                                                                       Write(item.MaxSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN</a></li>\r\n                            <li class=\"main-2\"><a");
            BeginWriteAttribute("href", " href=\"", 1195, "\"", 1202, 0);
            EndWriteAttribute();
            WriteLiteral(">Yeni</a></li>\r\n                            <li class=\"main-3\"><a");
            BeginWriteAttribute("href", " href=\"", 1268, "\"", 1275, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-briefcase\"></i>");
#nullable restore
#line 31 "C:\Users\User\Dropbox\PC\Desktop\My-Final-Project-Staffy\My-Final-Project-Staffy\Views\WorkAnnounce\Index.cshtml"
                                                                                          Write(item.State.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li class=\"main-4\"><a");
            BeginWriteAttribute("href", " href=\"", 1390, "\"", 1397, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-angles-right\"></i>Asan Muraciet</a></li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 36 "C:\Users\User\Dropbox\PC\Desktop\My-Final-Project-Staffy\My-Final-Project-Staffy\Views\WorkAnnounce\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </section>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Vacation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
