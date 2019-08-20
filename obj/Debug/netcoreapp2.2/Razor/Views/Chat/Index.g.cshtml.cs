#pragma checksum "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc761e63c1da9a7e1f45d9bf15701748efb38cf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chat/Index.cshtml", typeof(AspNetCore.Views_Chat_Index))]
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
#line 1 "/Users/Guest/Desktop/MessagesClient/Views/_ViewImports.cshtml"
using MessagesClient;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/MessagesClient/Views/_ViewImports.cshtml"
using MessagesClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc761e63c1da9a7e1f45d9bf15701748efb38cf6", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6414cc97f5fab9b2a9dd4f42f8271475602b36e", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessagesClient.Models.Message>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 36, true);
            WriteLiteral("\n\n<h2>All Articles</h2>\n<hr />\n<ol>\n");
            EndContext();
#line 6 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
     foreach (var message in @ViewBag.allMessages)
    {

#line default
#line hidden
            BeginContext(93, 61, true);
            WriteLiteral("        <li>\n            <ul>\n                <li>MessageId: ");
            EndContext();
            BeginContext(155, 17, false);
#line 10 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
                          Write(message.MessageId);

#line default
#line hidden
            EndContext();
            BeginContext(172, 36, true);
            WriteLiteral("</li>\n                <li>Username: ");
            EndContext();
            BeginContext(209, 16, false);
#line 11 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
                         Write(message.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(225, 39, true);
            WriteLiteral("</li>\n                <li>MessageText: ");
            EndContext();
            BeginContext(265, 19, false);
#line 12 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
                            Write(message.MessageText);

#line default
#line hidden
            EndContext();
            BeginContext(284, 41, true);
            WriteLiteral("</li>\n                <li>MessageNumber: ");
            EndContext();
            BeginContext(326, 21, false);
#line 13 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
                              Write(message.MessageNumber);

#line default
#line hidden
            EndContext();
            BeginContext(347, 39, true);
            WriteLiteral("</li>\n                <li>MessageNote: ");
            EndContext();
            BeginContext(387, 19, false);
#line 14 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
                            Write(message.MessageNote);

#line default
#line hidden
            EndContext();
            BeginContext(406, 72, true);
            WriteLiteral("</li>\n                <hr>\n            \n            </ul>\n        </li>\n");
            EndContext();
#line 19 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(484, 5, true);
            WriteLiteral("    \n");
            EndContext();
            BeginContext(526, 27, true);
            WriteLiteral("\n<h3>Make a message:</h3>\n\n");
            EndContext();
#line 25 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(586, 40, false);
#line 27 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
Write(Html.HiddenFor(model => model.MessageId));

#line default
#line hidden
            EndContext();
            BeginContext(633, 41, false);
#line 29 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
Write(Html.LabelFor(model => model.MessageText));

#line default
#line hidden
            EndContext();
            BeginContext(681, 42, false);
#line 30 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
Write(Html.EditorFor(model => model.MessageText));

#line default
#line hidden
            EndContext();
            BeginContext(731, 43, false);
#line 32 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
Write(Html.LabelFor(model => model.MessageNumber));

#line default
#line hidden
            EndContext();
            BeginContext(781, 44, false);
#line 33 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
Write(Html.EditorFor(model => model.MessageNumber));

#line default
#line hidden
            EndContext();
            BeginContext(834, 41, false);
#line 35 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
 Write(Html.LabelFor(model => model.MessageNote));

#line default
#line hidden
            EndContext();
            BeginContext(882, 42, false);
#line 36 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
Write(Html.EditorFor(model => model.MessageNote));

#line default
#line hidden
            EndContext();
            BeginContext(933, 38, false);
#line 38 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
 Write(Html.LabelFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(978, 39, false);
#line 39 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"
Write(Html.EditorFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1022, 44, true);
            WriteLiteral("     <input type =\"submit\" value =\"Save\" />\n");
            EndContext();
#line 42 "/Users/Guest/Desktop/MessagesClient/Views/Chat/Index.cshtml"

}

#line default
#line hidden
            BeginContext(1069, 6, true);
            WriteLiteral("\n</ol>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessagesClient.Models.Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
