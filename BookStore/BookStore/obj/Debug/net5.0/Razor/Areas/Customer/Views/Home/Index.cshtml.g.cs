#pragma checksum "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7121fdfccb12e9860ad67ce8b5da85804b161eaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\_ViewImports.cshtml"
using BookStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\_ViewImports.cshtml"
using BookStore.Utility.ConstantsStringSettings;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7121fdfccb12e9860ad67ce8b5da85804b161eaa", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52bb4d9c908cb6a118156e9708711c5c328c7a6b", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("b-link-stripe b-animate-go  thickbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Home Page";
	var firstLineBooks = Model.Take(3);
	var secondLineBooks = Model.Skip(3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Banner", async() => {
                WriteLiteral(@"
	<!-- banner -->
	<div class=""banner"">
		<div class=""container"">
			<div  id=""top"" class=""callbacks_container"">
				<ul class=""rslides"" id=""slider"">
					<li>					
						<div class=""banner-text"">
							<h3>Lorem Ipsum is not simply dummy  </h3>
							<p>Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor .</p>
							<a href=""single.html"">Learn More</a>
						</div>
				
					</li>
					<li>
						<div class=""banner-text"">
							<h3>There are many variations </h3>
							<p>Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor .</p>
							<a href=""single.html"">Learn More</a>
						</div>
					
					</li>
					<li>
						<div class=""banner-text"">
							<h3>Sed ut perspiciatis unde omnis</");
                WriteLiteral(@"h3>
							<p>Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor .</p>
							<a href=""single.html"">Learn More</a>
						</div>
					</li>
				</ul>
			</div>
		</div>
	</div>
");
            }
            );
            WriteLiteral("\r\n<!-- content-top -->\r\n<div class=\"content-top\">\r\n\t<h1>NEW RELEASED</h1>\r\n\t<div class=\"grid-in\">\r\n");
#nullable restore
#line 48 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Home\Index.cshtml"
         foreach (var book in firstLineBooks)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"col-md-4 grid-top\">\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7121fdfccb12e9860ad67ce8b5da85804b161eaa7046", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<img class=\"img-responsive\"");
                BeginWriteAttribute("src", " src=\"", 1865, "\"", 1885, 1);
#nullable restore
#line 52 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 1871, book.ImageUrl, 1871, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1886, "\"", 1903, 1);
#nullable restore
#line 52 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 1892, book.Title, 1892, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t<div class=\"b-wrapper\">\r\n\t\t\t\t\t\t<h3 class=\"b-animate b-from-left b-delay03 \">\r\n\t\t\t\t\t\t\t<span>");
#nullable restore
#line 55 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Home\Index.cshtml"
                             Write(book.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\t\t\t\t\t\t</h3>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Home\Index.cshtml"
                                                                 WriteLiteral(book.BookId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t<p style=\"line-break:anywhere\"><a href=\"single.html\">");
#nullable restore
#line 59 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Home\Index.cshtml"
                                                                Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n\t\t\t</div>\n");
#nullable restore
#line 61 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Home\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"clearfix\"> </div>\r\n\t</div>\r\n\t<div class=\"grid-in\">\r\n");
#nullable restore
#line 65 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Home\Index.cshtml"
         foreach (var book in secondLineBooks)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"col-md-4 grid-top\">\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7121fdfccb12e9860ad67ce8b5da85804b161eaa11858", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<img class=\"img-responsive\"");
                BeginWriteAttribute("src", " src=\"", 2465, "\"", 2485, 1);
#nullable restore
#line 69 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 2471, book.ImageUrl, 2471, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2486, "\"", 2503, 1);
#nullable restore
#line 69 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 2492, book.Title, 2492, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t<div class=\"b-wrapper\">\r\n\t\t\t\t\t\t<h3 class=\"b-animate b-from-left b-delay03 \">\r\n\t\t\t\t\t\t\t<span>");
#nullable restore
#line 72 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Home\Index.cshtml"
                             Write(book.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\t\t\t\t\t\t</h3>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Home\Index.cshtml"
                                                                 WriteLiteral(book.BookId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t<p style=\"line-break:anywhere\"><a href=\"single.html\">");
#nullable restore
#line 76 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Home\Index.cshtml"
                                                                Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n\t\t\t</div>\n");
#nullable restore
#line 78 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Home\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		<div class=""clearfix""> </div>
	</div>
</div>

<!-- content-top-bottom -->
<div class=""content-top-bottom"">
	<h2>Featured Collections</h2>
	<div class=""col-md-6 men"">
		<a href=""single.html"" class=""b-link-stripe b-animate-go  thickbox"">
			<img class=""img-responsive"" src=""images/t1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3057, "\"", 3063, 0);
            EndWriteAttribute();
            WriteLiteral(@">
			<div class=""b-wrapper"">
				<h3 class=""b-animate b-from-top top-in   b-delay03 "">
					<span>Lorem</span>
				</h3>
			</div>
		</a>
	</div>
	<div class=""col-md-6"">
		<div class=""col-md1 "">
			<a href=""single.html"" class=""b-link-stripe b-animate-go  thickbox"">
				<img class=""img-responsive"" src=""images/t2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3392, "\"", 3398, 0);
            EndWriteAttribute();
            WriteLiteral(@">
				<div class=""b-wrapper"">
					<h3 class=""b-animate b-from-top top-in1   b-delay03 "">
						<span>Lorem</span>
					</h3>
				</div>
			</a>
		</div>
		<div class=""col-md2"">
			<div class=""col-md-6 men1"">
				<a href=""single.html"" class=""b-link-stripe b-animate-go  thickbox"">
					<img class=""img-responsive"" src=""images/t3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3743, "\"", 3749, 0);
            EndWriteAttribute();
            WriteLiteral(@">
					<div class=""b-wrapper"">
						<h3 class=""b-animate b-from-top top-in2   b-delay03 "">
							<span>Lorem</span>
						</h3>
					</div>
				</a>
			</div>
			<div class=""col-md-6 men2"">
				<a href=""single.html"" class=""b-link-stripe b-animate-go  thickbox"">
					<img class=""img-responsive"" src=""images/t4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4076, "\"", 4082, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t<div class=\"b-wrapper\">\r\n\t\t\t\t\t\t<h3 class=\"b-animate b-from-top top-in2   b-delay03 \">\r\n\t\t\t\t\t\t\t<span>Lorem</span>\r\n\t\t\t\t\t\t</h3>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</a>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"clearfix\"></div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t<script>\r\n\t\t$(function () {\r\n\t\t\t$(\"#slider\").responsiveSlides({\r\n\t\t\tauto: true,\r\n\t\t\tnav: true,\r\n\t\t\tspeed: 500,\r\n\t\t\tnamespace: \"callbacks\",\r\n\t\t\tpager: true,\r\n\t\t\t});\r\n\t\t});\r\n\t</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
