#pragma checksum "C:\Users\radut\Desktop\ase\MasterAfaceriElectronice\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb3397cf9a7d049695d424ad2099489c8ddf4b92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\radut\Desktop\ase\MasterAfaceriElectronice\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using ProiectMaster.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\radut\Desktop\ase\MasterAfaceriElectronice\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using ProiectMaster.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\radut\Desktop\ase\MasterAfaceriElectronice\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using ProiectMaster.Models.DTOs.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\radut\Desktop\ase\MasterAfaceriElectronice\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb3397cf9a7d049695d424ad2099489c8ddf4b92", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acab5ba8a5e668c9b84f92ed0a269c98a5931ed1", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 300px; height: 150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("nu exista imagine momentan"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\radut\Desktop\ase\MasterAfaceriElectronice\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Product";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mb-2 mt-2 operationsButtons"">
    <div class=""col-md-12"">
        <a href=""/Product/New"" class=""btn btn-new btn-outline-new font-weight-bold mr-2"" data-toggle=""tooltip"" title=""New"" data-placement=""top"">
            <span class=""fa fa-plus-circle""></span>
        </a>

        <button class=""btn btn-outline-dark font-weight-bold mr-2"" data-toggle=""tooltip"" title=""Edit"" data-placement=""top"" onclick=""Product.onEditBtnPress()"">
            <span class=""fa fa-edit""></span>
        </button>

        <button type=""button"" class=""btn btn-delete btn-outline-delete font-weight-bold mr-2"" id=""btnDelete"" data-toggle=""tooltip"" data-placement=""top"" title=""Delete"" onclick=""Product.onDelete()"">
            <span class=""fa fa-trash""></span>
        </button>
    </div>
</div>

<br/><br/>

     <table id=""table"" class=""table table-hover table-striped table-dark"">
         <thead>
             <tr>
                 <th hidden>Product Id</th>
                 <th>Image</th>
             ");
            WriteLiteral("    <th>Product name</th>\r\n                 <th>Description</th>\r\n                 <th>Price</th>\r\n                 <th>Is in stoc</th>\r\n             </tr>\r\n         </thead>\r\n\r\n         <tbody>\r\n\r\n");
#nullable restore
#line 39 "C:\Users\radut\Desktop\ase\MasterAfaceriElectronice\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
              foreach (var item in Model)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <tr");
            BeginWriteAttribute("id", " id=\"", 1374, "\"", 1387, 1);
#nullable restore
#line 41 "C:\Users\radut\Desktop\ase\MasterAfaceriElectronice\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
WriteAttributeValue("", 1379, item.Id, 1379, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                 <td hidden>");
#nullable restore
#line 42 "C:\Users\radut\Desktop\ase\MasterAfaceriElectronice\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                 <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb3397cf9a7d049695d424ad2099489c8ddf4b927086", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1502, "~/", 1502, 2, true);
#nullable restore
#line 43 "C:\Users\radut\Desktop\ase\MasterAfaceriElectronice\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 1504, item.ImagePath, 1504, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                 <td>");
#nullable restore
#line 44 "C:\Users\radut\Desktop\ase\MasterAfaceriElectronice\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                 <td>");
#nullable restore
#line 45 "C:\Users\radut\Desktop\ase\MasterAfaceriElectronice\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
                Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                 <td>");
#nullable restore
#line 46 "C:\Users\radut\Desktop\ase\MasterAfaceriElectronice\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                 <td><input type=\"checkbox\" disabled");
            BeginWriteAttribute("checked", " checked=\"", 1737, "\"", 1764, 1);
#nullable restore
#line 47 "C:\Users\radut\Desktop\ase\MasterAfaceriElectronice\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
WriteAttributeValue("", 1747, item.IsAvailable, 1747, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n             </tr>\r\n");
#nullable restore
#line 49 "C:\Users\radut\Desktop\ase\MasterAfaceriElectronice\Seminar 3\ProiectMaster\ProiectMaster.Web\Views\Product\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n         </tbody>\r\n\r\n     </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
