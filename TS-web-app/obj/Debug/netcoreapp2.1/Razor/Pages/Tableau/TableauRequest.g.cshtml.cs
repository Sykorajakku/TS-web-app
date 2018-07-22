#pragma checksum "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4cfbea8fda51b87751c4e03b4fa478f6f8ba351"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ts.App.Pages.Tableau.Pages_Tableau_TableauRequest), @"mvc.1.0.razor-page", @"/Pages/Tableau/TableauRequest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Tableau/TableauRequest.cshtml", typeof(Ts.App.Pages.Tableau.Pages_Tableau_TableauRequest), null)]
namespace Ts.App.Pages.Tableau
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
using Ts.IO;

#line default
#line hidden
#line 3 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
using Ts.App.Model;

#line default
#line hidden
#line 4 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
using Ts.App.Pages.Tableau;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4cfbea8fda51b87751c4e03b4fa478f6f8ba351", @"/Pages/Tableau/TableauRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad7be71f54cd76b8617cfc4303d7862ccd536670", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Tableau_TableauRequest : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Tableau/InputVerification", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
  
    ViewData["Title"] = "Tableau Solver";

#line default
#line hidden
            BeginContext(170, 77, true);
            WriteLiteral("\r\n<style>\r\n    #requestForm {\r\n        margin-top: 50px;\r\n    }\r\n</style>\r\n\r\n");
            EndContext();
            BeginContext(247, 2221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "962f7f50a69d4ce59db463285d5ef4e5", async() => {
                BeginContext(305, 264, true);
                WriteLiteral(@"
    <div id=""requestForm"">
        <table id=""container"">
            <tr>
                <th>Formula</th>
                <th><center>Truth value</center></th>
                <th></th>
                <th>Parser error message</th>
            </tr>

");
                EndContext();
#line 26 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
             for (var i = 0; i < Model.FormulaParseRequests.Count; ++i) {

                var isTrue = (Model.FormulaParseRequests[i].UnparsedTableauNode.TruthLabel == TruthLabel.True) ? '1' : '0';


#line default
#line hidden
                BeginContext(773, 68, true);
                WriteLiteral("                <tr>\r\n                    <td><input id=\"formulaRow\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 841, "\"", 872, 3);
                WriteAttributeValue("", 848, "Formula[", 848, 8, true);
#line 31 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
WriteAttributeValue("", 856, Html.Encode(i), 856, 15, false);

#line default
#line hidden
                WriteAttributeValue("", 871, "]", 871, 1, true);
                EndWriteAttribute();
                BeginContext(873, 12, true);
                WriteLiteral(" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 885, "\"", 964, 1);
#line 31 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
WriteAttributeValue("", 893, Html.Encode(Model.FormulaParseRequests[i].UnparsedTableauNode.Formula), 893, 71, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("onchange", " onchange=\"", 965, "\"", 1011, 3);
                WriteAttributeValue("", 976, "eraseErrorResponse(", 976, 19, true);
#line 31 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
WriteAttributeValue("", 995, Html.Encode(i), 995, 15, false);

#line default
#line hidden
                WriteAttributeValue("", 1010, ")", 1010, 1, true);
                EndWriteAttribute();
                BeginContext(1012, 80, true);
                WriteLiteral("></td>\r\n                    <td style=\"text-align: center;\"><input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1092, "\"", 1126, 3);
                WriteAttributeValue("", 1099, "TruthLabel[", 1099, 11, true);
#line 32 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
WriteAttributeValue("", 1110, Html.Encode(i), 1110, 15, false);

#line default
#line hidden
                WriteAttributeValue("", 1125, "]", 1125, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1127, "\"", 1155, 1);
#line 32 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
WriteAttributeValue("", 1135, Html.Encode(isTrue), 1135, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1156, 94, true);
                WriteLiteral("><input type=\"checkbox\" onclick=\"this.previousSibling.value = 1 - this.previousSibling.value\" ");
                EndContext();
#line 32 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
                                                                                                                                                                                                                                       if (isTrue == '1') {
                                                                                                                                                                                                                  

#line default
#line hidden
                BeginContext(1484, 34, false);
#line 33 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
                                                                                                                                                                                                             Write(Html.Encode("checked = 'checked'"));

#line default
#line hidden
                EndContext();
#line 33 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
                                                                                                                                                                                                                                                     
                                                                                                                                                                                                              }

#line default
#line hidden
                BeginContext(1727, 188, true);
                WriteLiteral("></td>\r\n                    <td><input type=\"button\" value=\"Remove formula\" onclick=\"deleteRow(this.parentNode.parentNode)\"/></td>\r\n                    <td><input type=\"text\" id=\"errorRow\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1915, "\"", 1952, 3);
                WriteAttributeValue("", 1922, "ErrorResponse[", 1922, 14, true);
#line 36 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
WriteAttributeValue("", 1936, Html.Encode(i), 1936, 15, false);

#line default
#line hidden
                WriteAttributeValue("", 1951, "]", 1951, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1953, "\"", 2018, 1);
#line 36 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
WriteAttributeValue("", 1961, Html.Encode(Model.FormulaParseRequests[i].ErrorResponse), 1961, 57, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2019, 51, true);
                WriteLiteral(" readonly=\"readonly\"></td>\r\n                </tr>\r\n");
                EndContext();
#line 38 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
            }

#line default
#line hidden
                BeginContext(2085, 163, true);
                WriteLiteral("\r\n        </table>\r\n    </div>\r\n\r\n    <p><input type=\"button\" id=\"addFormula\" value=\"Add new tableau formula\" onclick=\"addField();\"/></p>\r\n    <p>Expected result: ");
                EndContext();
                BeginContext(2248, 158, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "124fabce18c94fd1b7cab6e45727da59", async() => {
                    BeginContext(2391, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 44 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ExpectedTableauType);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 44 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
                                                        WriteLiteral(Html.Encode(nameof(Model.ExpectedTableauType)));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 44 "C:\Users\Sykoj\TS\TS-web-app\TS-web-app\Pages\Tableau\TableauRequest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<TableauType>();

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2406, 55, true);
                WriteLiteral("</p>\r\n    <p><input type=\"submit\" value=\"Solve\"/></p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2468, 3518, true);
            WriteLiteral(@"

<script type=""text/javascript"">
    function eraseErrorResponse(index) {

        var errorResponse = document.getElementsByName(""ErrorResponse["" + index + ""]"");
        errorResponse[0].setAttribute(""value"", """");
    }
</script>

<style>
    #formulaRow {
        width: 350px
    }
    #errorRow {
        width: 350px;
        font-size: 9px;
    }

</style>

<script type=""text/javascript"">
    function deleteRow(row) {

        var index = row.rowIndex;

        var table = document.getElementById(""container"");

        if (table.rows.length > 2) {

            for (var i = index + 1; i < table.rows.length; ++i) {
                updateIndex(i - 2, table.rows[i]);
            }

            table.deleteRow(index);
        }
    }
</script>

<script type=""text/javascript"">
    function updateIndex(index, element) {

        element.children[0].firstChild.setAttribute(""name"", ""Formula["" + index + ""]"");

        element.children[0].firstChild.setAttribute(""onchange");
            WriteLiteral(@""", ""eraseErrorMessage("" + index + "")"");

        element.children[1].firstChild.setAttribute(""name"", ""TruthLabel["" + index + ""]"");

        element.children[3].firstChild.setAttribute(""name"", ""ErrorResponse["" + index + ""]"");
    }
</script>

<script type=""text/javascript"">
    function addField(argument) {

        var myTable = document.getElementById(""container"");
        var currentIndex = myTable.rows.length;
        var currentRow = myTable.insertRow(-1);

        var linksBox = document.createElement(""input"");
        linksBox.setAttribute(""id"", ""formulaRow"");
        linksBox.setAttribute(""name"", ""Formula["" + (currentIndex - 1) + ""]"");
        linksBox.setAttribute(""type"", ""text"");
        linksBox.setAttribute(""onchange"", ""eraseErrorResponse("" + (currentIndex - 1) + "")"");
        linksBox.setAttribute(""value"", """");

        var hiddenBox = document.createElement(""input"");
        hiddenBox.setAttribute(""type"", ""hidden"");
        hiddenBox.setAttribute(""name"", ""TruthLabel["" + (c");
            WriteLiteral(@"urrentIndex - 1) + ""]"");
        hiddenBox.setAttribute(""value"", ""0"");

        var keywordsBox = document.createElement(""input"");
        keywordsBox.setAttribute(""type"", ""checkbox"");
        keywordsBox.setAttribute(""onclick"", ""this.previousSibling.value = 1 - this.previousSibling.value"");

        var removeFormula = document.createElement(""input"");
        removeFormula.setAttribute(""type"", ""button"");
        removeFormula.setAttribute(""value"", ""Remove formula"");
        removeFormula.setAttribute(""onclick"", ""deleteRow(this.parentNode.parentNode)"");

        var errorResponse = document.createElement(""input"");
        errorResponse.setAttribute(""type"", ""text"");
        errorResponse.setAttribute(""id"", ""errorRow"");
        errorResponse.setAttribute(""name"", ""ErrorResponse["" + (currentIndex - 1)+ ""]"");
        errorResponse.setAttribute(""value"", """");
        errorResponse.setAttribute(""readonly"", ""readonly"");

        var currentCell = currentRow.insertCell(-1);
        currentCell.appen");
            WriteLiteral(@"dChild(linksBox);

        currentCell = currentRow.insertCell(-1);
        currentRow.setAttribute(""style"", ""text-align:center;"");
        currentCell.appendChild(hiddenBox);
        currentCell.appendChild(keywordsBox);

        currentCell = currentRow.insertCell(-1);
        currentCell.appendChild(removeFormula);

        currentCell = currentRow.insertCell(-1);
        currentCell.appendChild(errorResponse);
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ts.App.Pages.Tableau.TableauRequestModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ts.App.Pages.Tableau.TableauRequestModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ts.App.Pages.Tableau.TableauRequestModel>)PageContext?.ViewData;
        public Ts.App.Pages.Tableau.TableauRequestModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
