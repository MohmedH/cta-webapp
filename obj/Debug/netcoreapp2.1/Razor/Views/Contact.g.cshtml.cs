#pragma checksum "/Users/Hira/Desktop/project07/cta-web/Views/Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ecbaff9b2a8fdab179e5d1f0d5faca2d0a18a47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_Contact), @"mvc.1.0.razor-page", @"/Views/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/Contact.cshtml", typeof(program.Pages.Views_Contact), null)]
namespace program.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/Hira/Desktop/project07/cta-web/Views/_ViewImports.cshtml"
using program;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ecbaff9b2a8fdab179e5d1f0d5faca2d0a18a47", @"/Views/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a87352ab55936b7625448d2e9155e1658af919", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/Hira/Desktop/project07/cta-web/Views/Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(66, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(71, 17, false);
#line 6 "/Users/Hira/Desktop/project07/cta-web/Views/Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(88, 10, true);
            WriteLiteral("</h2>\n<h3>");
            EndContext();
            BeginContext(99, 13, false);
#line 7 "/Users/Hira/Desktop/project07/cta-web/Views/Contact.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(112, 297, true);
            WriteLiteral(@"</h3>

<address>
    <strong>Name:</strong> Mohmed Hira <br />
    <strong>NetID:</strong> Mhira2 <br />
    <strong>Email:</strong> <a href=""mailto:mhira2@uic.edu"">mhira2@uic.edu</a><br />
    <strong>Personal Website:</strong> <a href=""http://mohmedhira.com"">mohmedhira.com</a><br />
</address>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel>)PageContext?.ViewData;
        public ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
