#pragma checksum "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cf79f2f110aaa73a814873e9936976f4f156e9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Publishers_Index), @"mvc.1.0.view", @"/Views/Publishers/Index.cshtml")]
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
#line 1 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\_ViewImports.cshtml"
using Mirza_Lorena_Lab2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\_ViewImports.cshtml"
using Mirza_Lorena_Lab2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cf79f2f110aaa73a814873e9936976f4f156e9b", @"/Views/Publishers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8155465db0928e19e6ce195243f834a55c47db95", @"/Views/_ViewImports.cshtml")]
    public class Views_Publishers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mirza_Lorena_Lab2.Models.LibraryViewModels.PublisherIndexData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
  
    ViewData["Title"] = "Publishers";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Publishers</h2>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cf79f2f110aaa73a814873e9936976f4f156e9b5039", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Publisher Name</th>\r\n            <th>Adress</th>\r\n            <th>Books</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
         foreach (var item in Model.Publishers)
        {
            string selectedRow = "";
            if (item.ID == (int?)ViewData["PublisherID"])
            {
                selectedRow = "success";
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 644, "\"", 664, 1);
#nullable restore
#line 26 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
WriteAttributeValue("", 652, selectedRow, 652, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PublisherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n");
#nullable restore
#line 35 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
                      
                        foreach (var book in item.PublishedBooks)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
                       Write(book.Book.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
                                        Write(book.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 39 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cf79f2f110aaa73a814873e9936976f4f156e9b9405", async() => {
                WriteLiteral("Select");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
                                            WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cf79f2f110aaa73a814873e9936976f4f156e9b11620", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
                                           WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cf79f2f110aaa73a814873e9936976f4f156e9b13833", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
                                              WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cf79f2f110aaa73a814873e9936976f4f156e9b16052", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
                                             WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n\r\n");
#nullable restore
#line 55 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
     if (Model.Books != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Books Published by Selected Publisher</h3>\r\n        <table class=\"table\">\r\n            <tr>\r\n                <th></th>\r\n                <th>Title</th>\r\n                <th>Author</th>\r\n                <th>Price</th>\r\n            </tr>\r\n");
#nullable restore
#line 65 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
             foreach (var item in Model.Books)
            {
                string selectedRow = "";
                if (item.ID == (int?)ViewData["BookID"])
                {
                    selectedRow = "success";
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("class", " class=\"", 2154, "\"", 2174, 1);
#nullable restore
#line 72 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
WriteAttributeValue("", 2162, selectedRow, 2162, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
                   Write(Html.ActionLink("Select", "Index", new { bookID = item.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 77 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 80 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
                   Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 83 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 86 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 88 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 90 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
         if (Model.Orders != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h3>
                Customers that have ordered the Selected Book
            </h3>
            <table class=""table"">
                <tr>
                    <th>Name</th>
                    <th>Order Date</th>
                </tr>
");
#nullable restore
#line 100 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
                 foreach (var item in Model.Orders)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 104 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
                       Write(item.Customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 107 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 110 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 112 "C:\Users\Asus\OneDrive\Documents\facultate\FSEGA\map\Mirza_Lorena_Lab2\Mirza_Lorena_Lab2\Views\Publishers\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mirza_Lorena_Lab2.Models.LibraryViewModels.PublisherIndexData> Html { get; private set; }
    }
}
#pragma warning restore 1591
