#pragma checksum "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "355f2dd5746d4ef970de7b0cd39e591219b749e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Photos_Details), @"mvc.1.0.view", @"/Views/Photos/Details.cshtml")]
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
#line 1 "D:\capstone\new project\Photosphere\Photosphere\Views\_ViewImports.cshtml"
using Photosphere;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\capstone\new project\Photosphere\Photosphere\Views\_ViewImports.cshtml"
using Photosphere.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"355f2dd5746d4ef970de7b0cd39e591219b749e6", @"/Views/Photos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d753330030edae0a99d1f9a69ec00f7f546181ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Photos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Photosphere.Models.Photo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n<input type=\"button\" class=\"btn btn-outline-success m-1\" value=\"Add to Favourite\"");
            BeginWriteAttribute("onclick", " onclick=\"", 179, "\"", 261, 3);
            WriteAttributeValue("", 189, "location.href=\'", 189, 15, true);
#nullable restore
#line 8 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
WriteAttributeValue("", 204, Url.Action("AddToFav", "Photos", new { id = Model.Id }), 204, 56, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 260, "\'", 260, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n<input type=\"button\" class=\"btn btn-outline-success m-1\" value=\"Add to Comments\"");
            BeginWriteAttribute("onclick", " onclick=\"", 345, "\"", 431, 3);
            WriteAttributeValue("", 355, "location.href=\'", 355, 15, true);
#nullable restore
#line 9 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
WriteAttributeValue("", 370, Url.Action("AddToComment", "Photos", new { id = Model.Id }), 370, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 430, "\'", 430, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n<div class=\"col-lg-6  align-items-start\">\r\n    <h4>Photo</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-md-4\">\r\n            ");
#nullable restore
#line 16 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FileName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-8\">\r\n            ");
#nullable restore
#line 19 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.FileName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-4\">\r\n            ");
#nullable restore
#line 22 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FileType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-8\">\r\n            ");
#nullable restore
#line 25 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.FileType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-md-4\">\r\n            ");
#nullable restore
#line 29 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Manufacturer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-8\">\r\n            ");
#nullable restore
#line 32 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Manufacturer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-4\">\r\n            ");
#nullable restore
#line 35 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-8\">\r\n            ");
#nullable restore
#line 38 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-4\">\r\n            ");
#nullable restore
#line 41 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ExposureTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-8\">\r\n            ");
#nullable restore
#line 44 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.ExposureTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-4\">\r\n            ");
#nullable restore
#line 47 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FStop));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-8\">\r\n            ");
#nullable restore
#line 50 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.FStop));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-4\">\r\n            ");
#nullable restore
#line 53 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FocalLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-8\">\r\n            ");
#nullable restore
#line 56 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.FocalLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-4\">\r\n            ");
#nullable restore
#line 59 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxAperture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-8\">\r\n            ");
#nullable restore
#line 62 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaxAperture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-4\">\r\n            ");
#nullable restore
#line 65 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ExposureBias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-8\">\r\n            ");
#nullable restore
#line 68 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.ExposureBias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-md-4\">\r\n            ");
#nullable restore
#line 72 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-8\">\r\n            ");
#nullable restore
#line 75 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-4\">\r\n            ");
#nullable restore
#line 78 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-8\">\r\n            ");
#nullable restore
#line 81 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-4\">\r\n            ");
#nullable restore
#line 84 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AffectedFocalLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-8\">\r\n            ");
#nullable restore
#line 87 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.AffectedFocalLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-md-4\">\r\n            ");
#nullable restore
#line 90 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-md-8\">\r\n            ");
#nullable restore
#line 93 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div class=\"col-lg-4  align-items-end\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 3320, "\"", 3385, 2);
            WriteAttributeValue("", 3326, "data:image/jpeg;base64,", 3326, 23, true);
#nullable restore
#line 98 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
WriteAttributeValue("", 3349, Convert.ToBase64String(Model.Image), 3349, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 100%; height: 100%;\" />\r\n</div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "355f2dd5746d4ef970de7b0cd39e591219b749e614177", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "D:\capstone\new project\Photosphere\Photosphere\Views\Photos\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "355f2dd5746d4ef970de7b0cd39e591219b749e616317", async() => {
                WriteLiteral("Back to List");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Photosphere.Models.Photo> Html { get; private set; }
    }
}
#pragma warning restore 1591