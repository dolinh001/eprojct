#pragma checksum "C:\Users\Admin\OneDrive\Desktop\Yash Gems & Jewelleries\Client\eProjectClient\eProjectClient\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "846ba22df84f274dd260e4b45b43f2aec4e1eea2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Category/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Category_Index))]
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
#line 1 "C:\Users\Admin\OneDrive\Desktop\Yash Gems & Jewelleries\Client\eProjectClient\eProjectClient\Areas\Admin\Views\_ViewImports.cshtml"
using eProjectClient;

#line default
#line hidden
#line 2 "C:\Users\Admin\OneDrive\Desktop\Yash Gems & Jewelleries\Client\eProjectClient\eProjectClient\Areas\Admin\Views\_ViewImports.cshtml"
using eProjectClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"846ba22df84f274dd260e4b45b43f2aec4e1eea2", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"857ec834c38819c1b6bafa28989cf5819da42e6c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Data.DataModel.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 73, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-10 offset-lg-1\">\r\n        <p>");
            EndContext();
            BeginContext(118, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f9ab4c2dc3441ecac1d65f407fed15e", async() => {
                BeginContext(202, 9, true);
                WriteLiteral("Dashboard");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(215, 1033, true);
            WriteLiteral(@" / Categorys list</p>
    </div>
</div>

<div class=""row"">
    <div class=""col-lg-10 offset-lg-1 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-header"">
                <button type=""button"" class=""btn btn-primary btn-rounded btn-fw btn-sm"" data-bs-toggle=""modal"" data-bs-target=""#myModal"">Add new</button>
                <button type=""button"" class=""btn btn-primary btn-danger btn-fw btn-sm"">Delete</button>

                <button id=""showSearch"" class=""btn btn-warning btn-sm "" style=""float: right;"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseExample"" aria-expanded=""false"" aria-controls=""collapseExample"">
                    <span id=""iconSearch"" class=""icon-search""><span />
                </button>
            </div>
            <div class=""card-body"">
                <h4 class=""card-title"">Categorys list</h4>
                <div class=""collapse"" id=""collapseExample"">
                    <div class=""card card-body"">
               ");
            WriteLiteral("         ");
            EndContext();
            BeginContext(1248, 713, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4decfbfef2ff46368b026dec2fbf3984", async() => {
                BeginContext(1279, 675, true);
                WriteLiteral(@"
                            <div class=""form-group col-lg-6"">
                                <label for=""exampleInputUsername1"">Category name</label>
                                <input type=""text"" class=""form-control form-control-sm"" id=""exampleInputUsername1"" placeholder=""Category name"">
                            </div>
                            <div class=""form-group col-lg-6"">
                                <label for=""exampleInputEmail1"">Status</label>
                                <input type=""email"" class=""form-control form-control-sm"" id=""exampleInputEmail1"" placeholder=""Status"">
                            </div>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1961, 537, true);
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""table-responsive"">
                    <table class=""table table-hover"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Category name</th>
                                <th>Status</th>
                                <th>Operation</th>
                            </tr>
                        </thead>
                        <tbody id=""list"">
");
            EndContext();
            BeginContext(4660, 108, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
            BeginContext(4823, 574, true);
            WriteLiteral(@"        </div>
    </div>
    <div class=""modal"" id=""myModal"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">

                <!-- Modal Header -->
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Add New Category</h4>
                    <button type=""button"" class=""btn btn-danger btn-rounded btn-sm"" data-bs-dismiss=""modal""><span class=""mdi mdi-close""></span></button>
                </div>

                <!-- Modal body -->
                <div class=""modal-body"">
                    ");
            EndContext();
            BeginContext(5397, 1115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28c912505ca44f6482fa1ab52616e1e9", async() => {
                BeginContext(5424, 1081, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label for=""exampleInputUsername1"">Category Name</label>
                            <input type=""text"" class=""form-control"" id=""CategoryName"" placeholder=""Username"">
                        </div>

                        <div class=""form-group row no-gutters"">
                            <label class=""col-sm-12"">Status</label>
                            <div class=""col-sm-4"">
                                <div class=""form-check"">
                                    <label class=""form-check-label"">
                                        <input type=""checkbox"" class=""form-check-input"" name=""membershipRadios"" id=""Status"" value=""true"" checked>
                                        Activity
                                    </label>
                                </div>
                            </div>
                        </div>
                        <button type=""button"" id=""add-new"" class=""btn btn-pr");
                WriteLiteral("imary mr-2 add-new\">Submit</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6512, 309, true);
            WriteLiteral(@"
                </div>

                <!-- Modal footer -->
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-danger btn-sm"" data-bs-dismiss=""modal"">Close</button>
                </div>

            </div>
        </div>
    </div>
</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6838, 1662, true);
                WriteLiteral(@"

    <script>
        function listCategory() {
            $(document).ready(function () {
                url: ""/admin/Category/getList"";
                $.get(url, function (res) {
                var html = '';
                for (let i = 0; i < res.length; i++) {
                    html += '<tr>';
                    html += '<td>' + ""dsadasd"" + '</td>';
                    html += '<td>' + ""dsadasd"" + '</td>';
                    html += '<td>' + ""dsadasd"" + '</td>';

                    html += '</tr>';
                }
                // gán nội dung của biến html vào thẻ có id=""list""
                $('#list').html(html);
            })
        })};

        listCategory();
    </script>

    <script>
        $(document).ready(function () {
            
            $('.add-new').click(function () {
                var _name = $('input#CategoryName').val();
                var _status = $('input#Status').change().val();
                var _model = {
                ");
                WriteLiteral(@"    CategoryId : """",
                    CategoryName: _name,
                    Status: _status
                };

                console.log(_model);
                
                $.ajax({
                    url: '/admin/Category/Create',
                    type: 'POST',
                    data: _model, 
                    success: function (res) {
                        location.reload();
                    },
                    error: function (req, status, error) {
                        console.log(status);
                    }
                });
            });
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Data.DataModel.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591