#pragma checksum "D:\documents\GitHub\Game2048\Game2048\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8fbb224e8245ec4bc0596ac0cbe5af74c58bc85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8fbb224e8245ec4bc0596ac0cbe5af74c58bc85", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d761a72cfee4f2b878ddf8de2ccd411ec58c9816", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Game2048.Models.GameBoardViewModel>
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\documents\GitHub\Game2048\Game2048\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(90, 30, true);
            WriteLiteral("<div id=\"mainContainer\">\r\n    ");
            EndContext();
            BeginContext(120, 735, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09e02a611ba549f4a55067ebb053a7a9", async() => {
                BeginContext(140, 106, true);
                WriteLiteral("\r\n        <table id=\"gameBoard\" class=\"table table-hover-cells table-responsive\">\r\n            <tbody>\r\n\r\n");
                EndContext();
#line 11 "D:\documents\GitHub\Game2048\Game2048\Views\Home\Index.cshtml"
                 for (int i = 0; i < Model.BoardSize; i++)
                {

#line default
#line hidden
                BeginContext(325, 38, true);
                WriteLiteral("                    <tr class=\"row\">\r\n");
                EndContext();
#line 14 "D:\documents\GitHub\Game2048\Game2048\Views\Home\Index.cshtml"
                         for (int j = 0; j < Model.BoardSize; j++)
                        {

#line default
#line hidden
                BeginContext(458, 47, true);
                WriteLiteral("                            <td class=\"cell\">\r\n");
                EndContext();
#line 17 "D:\documents\GitHub\Game2048\Game2048\Views\Home\Index.cshtml"
                                 if (@Model.Matrix[i, j] != 0)
                                {
                                    

#line default
#line hidden
                BeginContext(641, 18, false);
#line 19 "D:\documents\GitHub\Game2048\Game2048\Views\Home\Index.cshtml"
                               Write(Model.Matrix[i, j]);

#line default
#line hidden
                EndContext();
#line 19 "D:\documents\GitHub\Game2048\Game2048\Views\Home\Index.cshtml"
                                                       
                                }

#line default
#line hidden
                BeginContext(696, 35, true);
                WriteLiteral("                            </td>\r\n");
                EndContext();
#line 22 "D:\documents\GitHub\Game2048\Game2048\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(758, 27, true);
                WriteLiteral("                    </tr>\r\n");
                EndContext();
#line 24 "D:\documents\GitHub\Game2048\Game2048\Views\Home\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(804, 44, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n    ");
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
            BeginContext(855, 3064, true);
            WriteLiteral(@"
    <!--
    <form action="""">
        First name: <input type=""text"" id=""txt1"" onkeyup=""showHint(this.value)"">
    </form>
    <p>Suggestions: <span id=""txtHint""></span></p>
    <script>
        function showHint(str) {
            var xhttp;
            if (str.length == 0) {
                document.getElementById(""txtHint"").innerHTML = """";
                return;
            }
            xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function () {
                if (this.readyState == 4 && this.status == 200) {
                    document.getElementById(""txtHint"").innerHTML = this.responseText;
                }
            };
            xhttp.open(""GET"", ""gethint.asp?q="" + str, true);
            xhttp.send();
        }
    </script>-->
    <!--
    <div class=""Rtable Rtable--4cols"">

        <div class=""Rtable-cell""><h3>Eddard Stark</h3></div>
        <div class=""Rtable-cell"">Has a sword named Ice</div>
        <div class=""Rtable-cell"">No direwolf</d");
            WriteLiteral(@"iv>
        <div class=""Rtable-cell""><strong>Lord of Winterfell</strong></div>

        <div class=""Rtable-cell""><h3>Jon Snow</h3></div>
        <div class=""Rtable-cell"">Has a sword named Longclaw</div>
        <div class=""Rtable-cell"">Direwolf: Ghost</div>
        <div class=""Rtable-cell""><strong>Knows nothing</strong></div>

        <div class=""Rtable-cell""><h3>Arya Stark</h3></div>
        <div class=""Rtable-cell"">Has a sword named Needle</div>
        <div class=""Rtable-cell"">Direwolf: Nymeria</div>
        <div class=""Rtable-cell""><strong>No one</strong></div>

    </div>-->



</div>

<button type=""submit"" onclick=""SwipeUp()"">up</button>
<button type=""submit"" onclick=""SwipeDown()"">down</button>
<button type=""submit"" onclick=""SwipeLeft()"">left</button>
<button type=""submit"" onclick=""SwipeRight()"">right</button>
<!--add ajax func that call the GM swipe func-->


<!--
<!DOCTYPE html>
<html>
<body>

    <h1>The XMLHttpRequest Object</h1>

    <p id=""demo"">Let AJAX change thi");
            WriteLiteral(@"s text.</p>

    <button type=""button"" onclick=""loadDoc()"">Change Content</button>

    <script>
        function loadDoc() {
            var xhttp;
            if (window.XMLHttpRequest) {
                // code for modern browsers
                xhttp = new XMLHttpRequest();
            } else {
                // code for IE6, IE5
                xhttp = new ActiveXObject(""Microsoft.XMLHTTP"");
            }
            xhttp.onreadystatechange = function () {
                if (this.readyState == 4 && this.status == 200) {
                    document.getElementById(""demo"").innerHTML = ""asdasd"";
                }
            };
            xhttp.open(""GET"", ""ajax_info.txt"", true);
            xhttp.send();
        }
    </script>

</body>
</html>
-->
<!--<div class=""form-group"">
    <input type=""submit"" value=""New Game"" class=""btn btn-default"" />
</div>-->
<!--<div class=""form-group"">
    <input type=""submit"" value=""SaveGame"" class=""btn btn-default"" />
</div>-->
");
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
