#pragma checksum "C:\Users\Kacper\Desktop\Na laby\ASP.NET-Core\ExchangeThings.Web\Views\Exchanges\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3174b61d461f18f0dc4f41d299e7efad43545df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exchanges_Display), @"mvc.1.0.view", @"/Views/Exchanges/Display.cshtml")]
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
#line 1 "C:\Users\Kacper\Desktop\Na laby\ASP.NET-Core\ExchangeThings.Web\Views\_ViewImports.cshtml"
using ExchangeThings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kacper\Desktop\Na laby\ASP.NET-Core\ExchangeThings.Web\Views\_ViewImports.cshtml"
using ExchangeThings.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3174b61d461f18f0dc4f41d299e7efad43545df", @"/Views/Exchanges/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71b945ae60c103fd4ccd8e72609152da5e421e59", @"/Views/_ViewImports.cshtml")]
    public class Views_Exchanges_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExchangesModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Company menagement</h1>\n\n<h2>Add new company</h2>\n\n<p>....</p>\n\n");
#nullable restore
#line 9 "C:\Users\Kacper\Desktop\Na laby\ASP.NET-Core\ExchangeThings.Web\Views\Exchanges\Display.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3174b61d461f18f0dc4f41d299e7efad43545df4214", async() => {
                WriteLiteral("\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 13 "C:\Users\Kacper\Desktop\Na laby\ASP.NET-Core\ExchangeThings.Web\Views\Exchanges\Display.cshtml"
   Write(Html.LabelFor(x => x.Name, "Exchange name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 14 "C:\Users\Kacper\Desktop\Na laby\ASP.NET-Core\ExchangeThings.Web\Views\Exchanges\Display.cshtml"
   Write(Html.TextAreaFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 17 "C:\Users\Kacper\Desktop\Na laby\ASP.NET-Core\ExchangeThings.Web\Views\Exchanges\Display.cshtml"
   Write(Html.LabelFor(x => x.Description, "Exchange description"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 18 "C:\Users\Kacper\Desktop\Na laby\ASP.NET-Core\ExchangeThings.Web\Views\Exchanges\Display.cshtml"
   Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n    <div class=\"form-group form-check\">\n        ");
#nullable restore
#line 21 "C:\Users\Kacper\Desktop\Na laby\ASP.NET-Core\ExchangeThings.Web\Views\Exchanges\Display.cshtml"
   Write(Html.CheckBoxFor(x => x.IsVisible, new { @class = "form-check-input" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        ");
#nullable restore
#line 22 "C:\Users\Kacper\Desktop\Na laby\ASP.NET-Core\ExchangeThings.Web\Views\Exchanges\Display.cshtml"
   Write(Html.LabelFor(x => x.IsVisible, "Visible?", new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n    <div class=\"form-group\">\n        <button type=\"submit\" class=\"btn btn-primary\">Add Exchanges</button>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 28 "C:\Users\Kacper\Desktop\Na laby\ASP.NET-Core\ExchangeThings.Web\Views\Exchanges\Display.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExchangesModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
