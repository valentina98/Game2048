#pragma checksum "D:\documents\GitHub\Game2048\Game2048\Views\Home\_GameBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ef5d09f92c253b42c3ed940bc05a70235561886"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__GameBoard), @"mvc.1.0.view", @"/Views/Home/_GameBoard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_GameBoard.cshtml", typeof(AspNetCore.Views_Home__GameBoard))]
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
#line 1 "D:\documents\GitHub\Game2048\Game2048\Views\_ViewImports.cshtml"
using Game2048;

#line default
#line hidden
#line 2 "D:\documents\GitHub\Game2048\Game2048\Views\_ViewImports.cshtml"
using Game2048.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ef5d09f92c253b42c3ed940bc05a70235561886", @"/Views/Home/_GameBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d761a72cfee4f2b878ddf8de2ccd411ec58c9816", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__GameBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Game2048.Models.GameBoardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(165, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(167, 854, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8795554b2e484303898bc355875b76af", async() => {
                BeginContext(187, 79, true);
                WriteLiteral("\r\n\r\n    <!--partial view-->\r\n    <table class=\"game-matrix\">\r\n        <tbody>\r\n");
                EndContext();
#line 11 "D:\documents\GitHub\Game2048\Game2048\Views\Home\_GameBoard.cshtml"
             for (int i = 0; i < Model.BoardSize; i++)
            {

#line default
#line hidden
                BeginContext(337, 22, true);
                WriteLiteral("                <tr>\r\n");
                EndContext();
#line 14 "D:\documents\GitHub\Game2048\Game2048\Views\Home\_GameBoard.cshtml"
                     for (int j = 0; j < Model.BoardSize; j++)
                    {

#line default
#line hidden
                BeginContext(446, 103, true);
                WriteLiteral("                        <td class=\"box\">\r\n                            <div class=\"content boardcell\">\r\n");
                EndContext();
#line 18 "D:\documents\GitHub\Game2048\Game2048\Views\Home\_GameBoard.cshtml"
                                 if (@Model.Matrix[i, j] != 0)
                                {
                                    

#line default
#line hidden
                BeginContext(685, 18, false);
#line 20 "D:\documents\GitHub\Game2048\Game2048\Views\Home\_GameBoard.cshtml"
                               Write(Model.Matrix[i, j]);

#line default
#line hidden
                EndContext();
#line 20 "D:\documents\GitHub\Game2048\Game2048\Views\Home\_GameBoard.cshtml"
                                                       
                                }

#line default
#line hidden
                BeginContext(740, 67, true);
                WriteLiteral("                            </div>\r\n                        </td>\r\n");
                EndContext();
                BeginContext(809, 44, true);
                WriteLiteral("                        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 853, "", 879, 1);
#line 25 "D:\documents\GitHub\Game2048\Game2048\Views\Home\_GameBoard.cshtml"
WriteAttributeValue("", 860, Model.Matrix[i, j], 860, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(879, 42, true);
                WriteLiteral("> <!-- hidden inputs with the values -->\r\n");
                EndContext();
#line 26 "D:\documents\GitHub\Game2048\Game2048\Views\Home\_GameBoard.cshtml"
                    }

#line default
#line hidden
                BeginContext(944, 23, true);
                WriteLiteral("                </tr>\r\n");
                EndContext();
#line 28 "D:\documents\GitHub\Game2048\Game2048\Views\Home\_GameBoard.cshtml"
            }

#line default
#line hidden
                BeginContext(982, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1021, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Game2048.Models.GameBoardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
