#pragma checksum "C:\Users\Noel\Desktop\examennoel\Lab3 08-01-2021\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "501885dc78be742c4fd7f470badec2fe7e6ffebe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "C:\Users\Noel\Desktop\examennoel\Lab3 08-01-2021\Views\_ViewImports.cshtml"
using Lab3_08_01_2021;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Noel\Desktop\examennoel\Lab3 08-01-2021\Views\_ViewImports.cshtml"
using Lab3_08_01_2021.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"501885dc78be742c4fd7f470badec2fe7e6ffebe", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00906d919ff22f8edda9931c8a8aae98c930cb1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab3_08_01_2021.Models.Domain.Student>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Noel\Desktop\examennoel\Lab3 08-01-2021\Views\Student\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "501885dc78be742c4fd7f470badec2fe7e6ffebe3513", async() => {
                WriteLiteral("\r\n\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "501885dc78be742c4fd7f470badec2fe7e6ffebe4552", async() => {
                WriteLiteral("\r\n\r\n    <div>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Noel\Desktop\examennoel\Lab3 08-01-2021\Views\Student\Index.cshtml"
         using (Html.BeginForm("Index", "Student", FormMethod.Post))

        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<table>\r\n\r\n                <tr>\r\n\r\n                    <td>UserName</td>\r\n\r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 29 "C:\Users\Noel\Desktop\examennoel\Lab3 08-01-2021\Views\Student\Index.cshtml"
                   Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 31 "C:\Users\Noel\Desktop\examennoel\Lab3 08-01-2021\Views\Student\Index.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        <br />\r\n\r\n                    </td>\r\n\r\n                </tr>\r\n\r\n                <tr>\r\n\r\n                    <td>Password</td>\r\n\r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 45 "C:\Users\Noel\Desktop\examennoel\Lab3 08-01-2021\Views\Student\Index.cshtml"
                   Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control", @type = "password" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 47 "C:\Users\Noel\Desktop\examennoel\Lab3 08-01-2021\Views\Student\Index.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        <br />

                    </td>

                </tr>

                <tr>

                    <td></td>

                    <td>

                        <br />

                        <input type=""submit"" value=""Login"" class=""btn-default"" />

                    </td>

                </tr>

            </table>
");
#nullable restore
#line 70 "C:\Users\Noel\Desktop\examennoel\Lab3 08-01-2021\Views\Student\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab3_08_01_2021.Models.Domain.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
