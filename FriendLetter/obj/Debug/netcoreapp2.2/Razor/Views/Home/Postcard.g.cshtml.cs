#pragma checksum "/Users/Guest/Desktop/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "755a05ae96adf7b6774a88b4e2d2367ad7797c06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Postcard), @"mvc.1.0.view", @"/Views/Home/Postcard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Postcard.cshtml", typeof(AspNetCore.Views_Home_Postcard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"755a05ae96adf7b6774a88b4e2d2367ad7797c06", @"/Views/Home/Postcard.cshtml")]
    public class Views_Home_Postcard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 45, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\" dir=\"ltr\">\n  ");
            EndContext();
            BeginContext(45, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "755a05ae96adf7b6774a88b4e2d2367ad7797c062886", async() => {
                BeginContext(51, 58, true);
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <title>Postcard</title>\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(116, 3, true);
            WriteLiteral("\n  ");
            EndContext();
            BeginContext(119, 581, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "755a05ae96adf7b6774a88b4e2d2367ad7797c064106", async() => {
                BeginContext(125, 42, true);
                WriteLiteral("\n    <h1>Hello From Afar</h1>\n    <p>Dear ");
                EndContext();
                BeginContext(168, 20, false);
#line 9 "/Users/Guest/Desktop/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
       Write(Model.GetRecipient());

#line default
#line hidden
                EndContext();
                BeginContext(188, 88, true);
                WriteLiteral(",</p>\n    <p>How are you? I hope that you are having a nice weekend. I\'m vacationing in ");
                EndContext();
                BeginContext(277, 20, false);
#line 10 "/Users/Guest/Desktop/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
                                                                             Write(Model.GetLocation1());

#line default
#line hidden
                EndContext();
                BeginContext(297, 40, true);
                WriteLiteral(" while I learn programming! </p>\n    <p>");
                EndContext();
                BeginContext(338, 20, false);
#line 11 "/Users/Guest/Desktop/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
  Write(Model.GetRecipient());

#line default
#line hidden
                EndContext();
                BeginContext(358, 67, true);
                WriteLiteral(", you would not believe how cold it is here. I should have gone to ");
                EndContext();
                BeginContext(426, 20, false);
#line 11 "/Users/Guest/Desktop/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
                                                                                          Write(Model.GetLocation2());

#line default
#line hidden
                EndContext();
                BeginContext(446, 152, true);
                WriteLiteral(" instead.</p>\n    <p>But I like programming a lot, so I\'ve got that going for me. </p>\n    <p>Looking forward to seeing you soon. I\'ll bring you back a ");
                EndContext();
                BeginContext(599, 20, false);
#line 13 "/Users/Guest/Desktop/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
                                                            Write(Model.GetSouvenirs());

#line default
#line hidden
                EndContext();
                BeginContext(619, 51, true);
                WriteLiteral(". </p>\n    <p>Cheers,</p>\n    <p>Travel Enthusiast ");
                EndContext();
                BeginContext(671, 17, false);
#line 15 "/Users/Guest/Desktop/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
                    Write(Model.GetSender());

#line default
#line hidden
                EndContext();
                BeginContext(688, 5, true);
                WriteLiteral("</p>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(700, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591