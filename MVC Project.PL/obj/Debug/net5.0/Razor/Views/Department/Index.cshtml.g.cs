#pragma checksum "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "631c645d5251d5b1f1bf6f18f9d2736e07e27b76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
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
#line 1 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\_ViewImports.cshtml"
using MVC_Project.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\_ViewImports.cshtml"
using MVC_Project.PL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\_ViewImports.cshtml"
using MVC_Project.BLL.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\_ViewImports.cshtml"
using MVC_Project.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"631c645d5251d5b1f1bf6f18f9d2736e07e27b76", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9adabd2d007b4029b9696499312448099dcc3ecc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Department>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Department", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "All Departments";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml"
 if (TempData["message"] is not null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-primary mt-5\">\r\n        ");
#nullable restore
#line 10 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml"
   Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>All Departments</h1>\r\n<br />\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "631c645d5251d5b1f1bf6f18f9d2736e07e27b766067", async() => {
                WriteLiteral("Create New Department");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 21 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"mt-4 table table-striped table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml"
               Write(Html.DisplayNameFor(D=>D.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml"
               Write(Html.DisplayNameFor(D=>D.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml"
               Write(Html.DisplayNameFor(D=>D.DateOfCreation.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>Details</td>\r\n                <td>Update</td>\r\n                <td>Delete</td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml"
             foreach(var department in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml"
                   Write(department.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml"
                   Write(department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml"
                   Write(department.DateOfCreation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "631c645d5251d5b1f1bf6f18f9d2736e07e27b7610067", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 42 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = department.Id.ToString();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml"
               
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 48 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mt-5 alert alert-warning\">\r\n        <h2> There is No Departments</h2>\r\n    </div>\r\n");
#nullable restore
#line 55 "C:\Users\Mohamed\Desktop\MVC Project Solution\MVC Project.PL\Views\Department\Index.cshtml"
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Department>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
