#pragma checksum "/Users/alejandrofigueroa/projects/alejof/simple-blog/src/Views/Home/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44cf43d443ea3da5dffcf722be3e9ad0b8f71045"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#line 1 "/Users/alejandrofigueroa/projects/alejof/simple-blog/src/Views/_ViewImports.cshtml"
using Alejof.SimpleBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alejandrofigueroa/projects/alejof/simple-blog/src/Views/_ViewImports.cshtml"
using Alejof.SimpleBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44cf43d443ea3da5dffcf722be3e9ad0b8f71045", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182c4fe57c0f555f401b36330deedfa4626078fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/alejandrofigueroa/projects/alejof/simple-blog/src/Views/Home/Detail.cshtml"
  
    ViewData["Title"] = "Edit Post";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">AlejoF Simple Blog</h1>\r\n    <p>View Post</p>\r\n</div>\r\n\r\n<div class=\"container my-5 text-left\">\r\n    <h2>");
#nullable restore
#line 13 "/Users/alejandrofigueroa/projects/alejof/simple-blog/src/Views/Home/Detail.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p class=\"small\">By ");
#nullable restore
#line 14 "/Users/alejandrofigueroa/projects/alejof/simple-blog/src/Views/Home/Detail.cshtml"
                   Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Last updated ");
#nullable restore
#line 14 "/Users/alejandrofigueroa/projects/alejof/simple-blog/src/Views/Home/Detail.cshtml"
                                               Write(Model.UpdatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    <div class=\"my-3\">\r\n        <pre>");
#nullable restore
#line 17 "/Users/alejandrofigueroa/projects/alejof/simple-blog/src/Views/Home/Detail.cshtml"
        Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n    </div>\r\n\r\n    <h3>Comments</h3>\r\n\r\n");
#nullable restore
#line 22 "/Users/alejandrofigueroa/projects/alejof/simple-blog/src/Views/Home/Detail.cshtml"
     foreach (var comment in Model.Comments)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card my-3\">\r\n            <div class=\"card-header\">\r\n                ");
#nullable restore
#line 26 "/Users/alejandrofigueroa/projects/alejof/simple-blog/src/Views/Home/Detail.cshtml"
           Write(comment.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <p class=\"card-title\">");
#nullable restore
#line 29 "/Users/alejandrofigueroa/projects/alejof/simple-blog/src/Views/Home/Detail.cshtml"
                                 Write(comment.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"small\">");
#nullable restore
#line 30 "/Users/alejandrofigueroa/projects/alejof/simple-blog/src/Views/Home/Detail.cshtml"
                            Write(comment.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\"><pre>");
#nullable restore
#line 31 "/Users/alejandrofigueroa/projects/alejof/simple-blog/src/Views/Home/Detail.cshtml"
                                     Write(comment.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 34 "/Users/alejandrofigueroa/projects/alejof/simple-blog/src/Views/Home/Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card my-3\">\r\n        <div class=\"card-header\">\r\n            Post new comment\r\n        </div>\r\n        <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44cf43d443ea3da5dffcf722be3e9ad0b8f710457314", async() => {
                WriteLiteral(@"
                <div class=""form-group"">
                    <label for=""Author"">Name</label>
                    <input type=""text"" class=""form-control"" name=""Author"" placeholder=""Your Name"">
                </div>
                <div class=""form-group"">
                    <label for=""Email"">Email</label>
                    <input type=""email"" class=""form-control"" name=""Email"" placeholder=""Your Email"">
                </div>
                <div class=""form-group"">
                    <label for=""Content"">Content</label>
                    <textarea class=""form-control"" name=""Content"" placeholder=""Post Content"" rows=""3""></textarea>
                </div>
                <button type=""submit"" class=""btn btn-primary"">Post Comment</button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-slug", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "/Users/alejandrofigueroa/projects/alejof/simple-blog/src/Views/Home/Detail.cshtml"
                                               WriteLiteral(Model.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44cf43d443ea3da5dffcf722be3e9ad0b8f7104510575", async() => {
                WriteLiteral("Go back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591