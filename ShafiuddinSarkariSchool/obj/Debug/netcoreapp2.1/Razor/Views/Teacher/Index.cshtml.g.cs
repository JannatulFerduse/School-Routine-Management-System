#pragma checksum "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da9fcc6f58eca38a43b2aae287cc13c3a6f0fa20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Index), @"mvc.1.0.view", @"/Views/Teacher/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/Index.cshtml", typeof(AspNetCore.Views_Teacher_Index))]
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
#line 1 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\_ViewImports.cshtml"
using ShafiuddinSarkariSchool;

#line default
#line hidden
#line 2 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\_ViewImports.cshtml"
using ShafiuddinSarkariSchool.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da9fcc6f58eca38a43b2aae287cc13c3a6f0fa20", @"/Views/Teacher/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9842226b56e2dd8f10c659b2115a57fa49081256", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShafiuddinSarkariSchool.Models.tblTeacher>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TeacherLayout.cshtml";

#line default
#line hidden
            BeginContext(160, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(189, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45944ec2ab9f4ac09436439ffeeeca4b", async() => {
                BeginContext(212, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(226, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(319, 40, false);
#line 17 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(359, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(415, 42, false);
#line 20 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bangla));

#line default
#line hidden
            EndContext();
            BeginContext(457, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(513, 43, false);
#line 23 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.English));

#line default
#line hidden
            EndContext();
            BeginContext(556, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(612, 40, false);
#line 26 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Math));

#line default
#line hidden
            EndContext();
            BeginContext(652, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(708, 44, false);
#line 29 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Religion));

#line default
#line hidden
            EndContext();
            BeginContext(752, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(808, 49, false);
#line 32 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SocialScience));

#line default
#line hidden
            EndContext();
            BeginContext(857, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(913, 43, false);
#line 35 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Science));

#line default
#line hidden
            EndContext();
            BeginContext(956, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1012, 46, false);
#line 38 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalMarks));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1114, 44, false);
#line 41 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.tblClass));

#line default
#line hidden
            EndContext();
            BeginContext(1158, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1214, 43, false);
#line 44 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.tblExam));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1313, 46, false);
#line 47 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.tblSection));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1415, 46, false);
#line 50 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.tblStudent));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 56 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1579, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1628, 39, false);
#line 59 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1667, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1723, 41, false);
#line 62 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bangla));

#line default
#line hidden
            EndContext();
            BeginContext(1764, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1820, 42, false);
#line 65 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.English));

#line default
#line hidden
            EndContext();
            BeginContext(1862, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1918, 39, false);
#line 68 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Math));

#line default
#line hidden
            EndContext();
            BeginContext(1957, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2013, 43, false);
#line 71 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Religion));

#line default
#line hidden
            EndContext();
            BeginContext(2056, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2112, 48, false);
#line 74 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SocialScience));

#line default
#line hidden
            EndContext();
            BeginContext(2160, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2216, 42, false);
#line 77 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Science));

#line default
#line hidden
            EndContext();
            BeginContext(2258, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2314, 45, false);
#line 80 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalMarks));

#line default
#line hidden
            EndContext();
            BeginContext(2359, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2415, 48, false);
#line 83 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.tblClass.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2463, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2519, 47, false);
#line 86 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.tblExam.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2566, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2622, 50, false);
#line 89 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.tblSection.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2672, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2728, 53, false);
#line 92 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.tblStudent.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2781, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2836, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dda446f49967410087d985866c6ee483", async() => {
                BeginContext(2888, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
                                       WriteLiteral(item.TeacherId);

#line default
#line hidden
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
            EndContext();
            BeginContext(2896, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2916, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f93e2a6ae6bc4d0eb5e6683e971101e1", async() => {
                BeginContext(2971, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
                                          WriteLiteral(item.TeacherId);

#line default
#line hidden
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
            EndContext();
            BeginContext(2982, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3002, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9392c5082c141dea8b8cc3a3d216c7c", async() => {
                BeginContext(3056, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
                                         WriteLiteral(item.TeacherId);

#line default
#line hidden
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
            EndContext();
            BeginContext(3066, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 100 "F:\Project\update shafi\update shafi\ShafiuddinSarkariSchool\ShafiuddinSarkariSchool\Views\Teacher\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3105, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShafiuddinSarkariSchool.Models.tblTeacher>> Html { get; private set; }
    }
}
#pragma warning restore 1591