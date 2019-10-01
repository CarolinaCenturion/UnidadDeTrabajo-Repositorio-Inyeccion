#pragma checksum "C:\Users\dalia\source\repos\CleanArch\CleanArch.Mvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80d99817fb258da5738f6ed9682adb7a34b70c52"
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
#line 1 "C:\Users\dalia\source\repos\CleanArch\CleanArch.Mvc\Views\_ViewImports.cshtml"
using CleanArch.Mvc;

#line default
#line hidden
#line 2 "C:\Users\dalia\source\repos\CleanArch\CleanArch.Mvc\Views\_ViewImports.cshtml"
using CleanArch.Mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80d99817fb258da5738f6ed9682adb7a34b70c52", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad188cbe7dd57a8794ff436f3b6d4e994ac68bef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CleanArch.Domain.Models.School>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteSchool", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\dalia\source\repos\CleanArch\CleanArch.Mvc\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";


#line default
#line hidden
            BeginContext(103, 777, true);
            WriteLiteral(@"
<h2>Index</h2>

<div class=""container bs-docs-container"">
   
    <div class=""row"">
        <div class=""col-md-12"">
            <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#modalCreateSchool"">Agregar escuela</button>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <table id=""tableSchools"" class=""table table-bordered"">
                    <thead>
                        <tr>
                            <td>Acciones</td>
                            <td>Nombre</td>
                            <td>Descripción</td>
                            <td>Fecha Creacion</td>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 30 "C:\Users\dalia\source\repos\CleanArch\CleanArch.Mvc\Views\Home\Index.cshtml"
                         foreach (var school in Model)
                        {

#line default
#line hidden
            BeginContext(963, 149, true);
            WriteLiteral("                            <tr>\r\n                                <td><a data-toggle=\"modal\" data-target=\"#modalUpdateSchool\" class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1112, "\"", 1182, 4);
            WriteAttributeValue("", 1122, "GetDataUpdateSchool(", 1122, 20, true);
#line 33 "C:\Users\dalia\source\repos\CleanArch\CleanArch.Mvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 1142, school.Id, 1142, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1152, ",", 1152, 1, true);
            WriteAttributeValue(" ", 1153, "\'Home/GetDataUpdateSchool\');", 1154, 29, true);
            EndWriteAttribute();
            BeginContext(1183, 12, true);
            WriteLiteral(">Editar</a> ");
            EndContext();
            BeginContext(1195, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c644fafb7a04130b0bcb7aeab91afba", async() => {
                BeginContext(1273, 8, true);
                WriteLiteral("Eliminar");
                EndContext();
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
#line 33 "C:\Users\dalia\source\repos\CleanArch\CleanArch.Mvc\Views\Home\Index.cshtml"
                                                                                                                                                                                                                                     WriteLiteral(school.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1285, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1329, 11, false);
#line 34 "C:\Users\dalia\source\repos\CleanArch\CleanArch.Mvc\Views\Home\Index.cshtml"
                               Write(school.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1340, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1384, 18, false);
#line 35 "C:\Users\dalia\source\repos\CleanArch\CleanArch.Mvc\Views\Home\Index.cshtml"
                               Write(school.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1402, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1446, 19, false);
#line 36 "C:\Users\dalia\source\repos\CleanArch\CleanArch.Mvc\Views\Home\Index.cshtml"
                               Write(school.CreationDate);

#line default
#line hidden
            EndContext();
            BeginContext(1465, 44, true);
            WriteLiteral("</td>\r\n\r\n                            </tr>\r\n");
            EndContext();
#line 39 "C:\Users\dalia\source\repos\CleanArch\CleanArch.Mvc\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1536, 2512, true);
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>

    </div>
<!--Modals-->
<div class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" id=""modalUpdateSchool"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Editar Escuela</h4>
            </div>
            <div class=""modal-body"">
                <input type=""hidden"" id=""txthdnIdSchool"" />
                <div class=""form-group"">
                    <label>Nombre:</label>
                    <input type=""text"" id=""txtNameSchool"" class=""form-control"" />
                </div>

                <div class=""form-group"">
                    <label>Descripción:</label>
                    <textarea cols=""5"" rows=""3"" id=""txtADescriptionSchool"" class=""form-control""></textarea>
                </div>
            </div>
            <div class=""modal-footer""");
            WriteLiteral(@">
                <button type=""button"" class=""btn btn-primary"" onclick=""UpdateSchool('Home/UpdateSchool')"">Save changes</button>
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"" >Close</button>

            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" id=""modalCreateSchool"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Crear Escuela</h4>
            </div>
            <div class=""modal-body"">
                <input type=""hidden"" id=""txthdnIdSchool"" />
                <div class=""form-group"">
                    <label>Nombre:</label>
                    <input type=""text"" id=""txtNameSchoolC"" class=""form-control"" />
                </div>

                <div class=""form-group"">
                    <label>Descripción:</label>
                   ");
            WriteLiteral(@" <textarea cols=""5"" rows=""3"" id=""txtADescriptionSchoolC"" class=""form-control""></textarea>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" onclick=""CreateSchool('Home/CreateNewSchool')"">Save changes</button>
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>

            </div>
        </div>
    </div>
</div>
");
            EndContext();
            BeginContext(4048, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0aa4c6b4b07b4587b8d5af74548de368", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4099, 1608, true);
            WriteLiteral(@"
<!-- page script -->
<script>


    function GetDataUpdateSchool(id, action) {
        $.ajax({
            type: ""POST"",
            url: action,
            data: { id },
            success: function (response)
            {
                $(""#txthdnIdSchool"").val(response.id);
                $(""#txtNameSchool"").val(response.name);
                $(""#txtADescriptionSchool"").val(response.description);
               
            }
        });
    }

    function UpdateSchool(action)
    {
        const school = new Object();
        school.Id = parseInt($(""#txthdnIdSchool"").val());
        school.Name =$(""#txtNameSchool"").val();
        school.Description = $(""#txtADescriptionSchool"").val();
        $.ajax({
            type: ""POST"",
            url: action,
            data: { school },
            success: function (response)
            {
                alert(""Actualización exitosa."");
                $(""#modalUpdateSchool"").modal(""hide"");
                location.r");
            WriteLiteral(@"eload();
            }
        });
    }

    function CreateSchool(action) {
        const school = new Object();
        school.Name = $(""#txtNameSchoolC"").val();
        school.Description = $(""#txtADescriptionSchoolC"").val();
        $.ajax({
            type: ""POST"",
            url: action,
            data: { school },
            success: function (response)
            {
                alert("" Creación exitosa."");
                $(""#modalCreateSchool"").modal(""hide"");
                location.reload();
            }
        });
    }

</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CleanArch.Domain.Models.School>> Html { get; private set; }
    }
}
#pragma warning restore 1591
