#pragma checksum "C:\Users\thiag\source\repos\EncontreSeuLivro\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3aae4249a1e99335c1afa768608bfeb572aced9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\thiag\source\repos\EncontreSeuLivro\Views\_ViewImports.cshtml"
using EncontreSeuLivro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thiag\source\repos\EncontreSeuLivro\Views\_ViewImports.cshtml"
using EncontreSeuLivro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3aae4249a1e99335c1afa768608bfeb572aced9", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47533ebc688870f55d37b405add7fc21495738e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3aae4249a1e99335c1afa768608bfeb572aced94113", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "C:\Users\thiag\source\repos\EncontreSeuLivro\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - EncontreSeuLivro</title>\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css\" integrity=\"sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm\" crossorigin=\"anonymous\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c3aae4249a1e99335c1afa768608bfeb572aced94980", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3aae4249a1e99335c1afa768608bfeb572aced96862", async() => {
                WriteLiteral(@"
    <header>
        <nav class=""site-header fixed-top py-1"">
            <div class=""container d-flex flex-column flex-md-row justify-content-between"">
                <a class=""py-2"" href=""#"" aria-label=""Product"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" fill=""none"" stroke=""currentColor"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" class=""d-block mx-auto"" role=""img"" viewBox=""0 0 24 24"" focusable=""false""><title>Product</title><circle cx=""12"" cy=""12"" r=""10"" /><path d=""M14.31 8l5.74 9.94M9.69 8h11.48M7.38 12l5.74-9.94M9.69 16L3.95 6.06M14.31 16H2.83m13.79-4l-5.74 9.94"" /></svg>
                </a>
                <a class=""py-2 d-none d-md-inline-block"" href=""#"">Adicionar livros</a>
                <a class=""py-2 d-none d-md-inline-block""");
                BeginWriteAttribute("href", " href=\"", 1312, "\"", 1348, 1);
#nullable restore
#line 18 "C:\Users\thiag\source\repos\EncontreSeuLivro\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1319, Url.Action("Busca","livros"), 1319, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Busca de livros</a>
                <a class=""py-2 d-none d-md-inline-block"" href=""#"">Busca de editoras</a>
                <a class=""py-2 d-none d-md-inline-block"" href=""#"">Atualizar livro publicado</a>
                <a class=""py-2 d-none d-md-inline-block""");
                BeginWriteAttribute("href", " href=\"", 1613, "\"", 1655, 1);
#nullable restore
#line 21 "C:\Users\thiag\source\repos\EncontreSeuLivro\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1620, Url.Action("Lancamentos","livros"), 1620, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\">Lançamentos de livros</a>\r\n            </div>\r\n        </nav>\r\n    </header>\r\n    \r\n            ");
#nullable restore
#line 26 "C:\Users\thiag\source\repos\EncontreSeuLivro\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <footer class=""container py-5"">
        <div class=""row"">
            <div class=""col-12 col-md"">
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" fill=""none"" stroke=""currentColor"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" class=""d-block mb-2"" role=""img"" viewBox=""0 0 24 24"" focusable=""false""><title>Product</title><circle cx=""12"" cy=""12"" r=""10"" /><path d=""M14.31 8l5.74 9.94M9.69 8h11.48M7.38 12l5.74-9.94M9.69 16L3.95 6.06M14.31 16H2.83m13.79-4l-5.74 9.94"" /></svg>
                <small class=""d-block mb-3 text-muted"">&copy; 2017-{{ site.time | date: ""%Y"" }}</small>
            </div>
            <div class=""col-6 col-md"">
                <h5>Features</h5>
                <ul class=""list-unstyled text-small"">
                    <li><a class=""text-muted"" href=""#"">Cool stuff</a></li>
                    <li><a class=""text-muted"" href=""#"">Random feature</a></li>
                    <li><a class=""text-muted"" href=""#"">Team feature</a></li>
   ");
                WriteLiteral(@"                 <li><a class=""text-muted"" href=""#"">Stuff for developers</a></li>
                    <li><a class=""text-muted"" href=""#"">Another one</a></li>
                    <li><a class=""text-muted"" href=""#"">Last time</a></li>
                </ul>
            </div>
            <div class=""col-6 col-md"">
                <h5>Resources</h5>
                <ul class=""list-unstyled text-small"">
                    <li><a class=""text-muted"" href=""#"">Resource</a></li>
                    <li><a class=""text-muted"" href=""#"">Resource name</a></li>
                    <li><a class=""text-muted"" href=""#"">Another resource</a></li>
                    <li><a class=""text-muted"" href=""#"">Final resource</a></li>
                </ul>
            </div>
            <div class=""col-6 col-md"">
                <h5>Resources</h5>
                <ul class=""list-unstyled text-small"">
                    <li><a class=""text-muted"" href=""#"">Business</a></li>
                    <li><a class=""text-muted"" href=""");
                WriteLiteral(@"#"">Education</a></li>
                    <li><a class=""text-muted"" href=""#"">Government</a></li>
                    <li><a class=""text-muted"" href=""#"">Gaming</a></li>
                </ul>
            </div>
            <div class=""col-6 col-md"">
                <h5>About</h5>
                <ul class=""list-unstyled text-small"">
                    <li><a class=""text-muted"" href=""#"">Team</a></li>
                    <li><a class=""text-muted"" href=""#"">Locations</a></li>
                    <li><a class=""text-muted"" href=""#"">Privacy</a></li>
                    <li><a class=""text-muted"" href=""#"">Terms</a></li>
                </ul>
            </div>
        </div>
    </footer>
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgP");
                WriteLiteral(@"xhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
");
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
            WriteLiteral("\r\n</html>\r\n");
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
