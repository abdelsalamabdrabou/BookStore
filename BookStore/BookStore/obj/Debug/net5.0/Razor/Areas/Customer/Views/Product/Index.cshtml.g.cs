#pragma checksum "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "795281ef727d3a79c088a13397f6bc15a7b27e11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"795281ef727d3a79c088a13397f6bc15a7b27e11", @"/Areas/Customer/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42c9fe99ca73f7fcb066a804dfbeb4b9cceadc84", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Categories.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BestSellers.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/pi3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/pi1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/pi4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.flexslider.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Product";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--content-->\r\n<div class=\"product\">\r\n\t<div class=\"container\">\r\n\t\t<div class=\"col-md-3 product-price\">\t\t\t\t  \r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "795281ef727d3a79c088a13397f6bc15a7b27e116509", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\t\t\t\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "795281ef727d3a79c088a13397f6bc15a7b27e117637", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t<div class=\"clearfix\"></div>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-9 product-price1\">\r\n\t\t\t<div class=\"col-md-5 single-top\">\t\r\n\t\t\t\t<div class=\"flexslider\">\r\n\t\t\t\t  <ul class=\"slides\">\r\n\t\t\t\t\t<li data-thumb=\"images/si.jpg\">\r\n\t\t\t\t\t  <img");
            BeginWriteAttribute("src", " src=\"", 486, "\"", 507, 1);
#nullable restore
#line 19 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
WriteAttributeValue("", 492, Model.ImageUrl, 492, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t</li>\r\n\t\t\t\t  </ul>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\t\r\n\t\t\t<div class=\"col-md-7 single-top-in simpleCart_shelfItem\">\r\n\t\t\t\t<div class=\"single-para\">\r\n\t\t\t\t\t<h4>");
#nullable restore
#line 26 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
#nullable restore
#line 27 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                         if (Model.Status == "instock")
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<span class=\"text-success\" style=\"font-size: 16px;\">");
#nullable restore
#line 29 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                                                                           Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 30 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
						}
						else
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<span class=\"text-danger\" style=\"font-size: 16px;\">");
#nullable restore
#line 33 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                                                                          Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 34 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</h4>\r\n\t\t\t\t\t<ul style=\"list-style: none\">\r\n\t\t\t\t\t\t<li><span>author: ");
#nullable restore
#line 37 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                                     Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n\t\t\t\t\t\t<li><span>isbn: ");
#nullable restore
#line 38 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                                   Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n\t\t\t\t\t\t<li><span>publisher: ");
#nullable restore
#line 39 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                                        Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 39 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                                                          Write(Model.Edition);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Edition (");
#nullable restore
#line 39 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                                                                                  Write(Model.PublicationYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span></li>\r\n\t\t\t\t\t\t<li><span>category: ");
#nullable restore
#line 40 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                                       Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
					</ul>
					<div class=""star-on"">
						<ul class=""star-footer"">
							<li><a href=""#""><i></i></a></li>
							<li><a href=""#""><i></i></a></li>
							<li><a href=""#""><i></i></a></li>
							<li><a href=""#""><i></i></a></li>
							<li><a href=""#""><i></i></a></li>
						</ul>
						<div class=""review"">
							<a href=""#""> 1 customer review </a>								
						</div>
					</div>
					<div class=""clearfix""></div>							
");
#nullable restore
#line 55 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                     if (Model.DiscountRate > 0 && Model.Status == "instock")
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<h5 class=\"item_price\" style=\"text-decoration: line-through\">");
#nullable restore
#line 57 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                                                                                Write(String.Format("{0:C}", @Model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t\t\t\t\t<h5 class=\"item_price\" style=\"border-bottom: 1px solid #C4C3C3;\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 59 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                       Write(String.Format("{0:C}", @Model.OfferingPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"background: red; color:white;padding:5px;border-radius:6px;font-size:12px;\">Save ");
#nullable restore
#line 59 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                                                                                                                                                                   Write(Model.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n\t\t\t\t\t\t</h5>\r\n");
#nullable restore
#line 61 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
					}
					else
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<h5 class=\"item_price\" style=\"border-bottom: 1px solid #C4C3C3;\">");
#nullable restore
#line 64 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                                                                                    Write(String.Format("{0:C}", @Model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 65 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t<div class=\"clearfix\"></div>\r\n\r\n");
#nullable restore
#line 69 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                     if (Model.Status == "instock")
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<a href=\"#\" class=\"add-cart item_add\">ADD TO CART</a>\t\t\t\t\t\t\t\r\n");
#nullable restore
#line 72 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"clearfix\"></div>\r\n\r\n\t\t\t<div class=\"bottom-product single-para\">\r\n\t\t\t\t<p style=\"font-size:16px;\">");
#nullable restore
#line 78 "C:\Users\abdul\OneDrive\Desktop\BookStore\BookStore\BookStore\BookStore\Areas\Customer\Views\Product\Index.cshtml"
                                      Write(Model.Description.TrimEnd('.'));

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\" bottom-product\">\r\n\t\t\t\t<div class=\"col-md-4 bottom-cd simpleCart_shelfItem\">\r\n\t\t\t\t\t<div class=\"product-at \">\r\n\t\t\t\t\t\t<a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "795281ef727d3a79c088a13397f6bc15a7b27e1117981", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
							<div class=""pro-grid"">
								<span class=""buy-in"">Buy Now</span>
							</div>
						</a>	
					</div>
					<p class=""tun"">It is a long established fact that a reader</p>
					<a href=""#"" class=""item_add""><p class=""number item_price""><i> </i>$500.00</p></a>						
				</div>
				<div class=""col-md-4 bottom-cd simpleCart_shelfItem"">
					<div class=""product-at "">
						<a href=""#"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "795281ef727d3a79c088a13397f6bc15a7b27e1119597", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
							<div class=""pro-grid"">
								<span class=""buy-in"">Buy Now</span>
							</div>
						</a>	
					</div>
					<p class=""tun"">It is a long established fact that a reader</p>
					<a href=""#"" class=""item_add""><p class=""number item_price""><i> </i>$500.00</p></a>
				</div>
				<div class=""col-md-4 bottom-cd simpleCart_shelfItem"">
					<div class=""product-at "">
						<a href=""#"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "795281ef727d3a79c088a13397f6bc15a7b27e1121207", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
							<div class=""pro-grid"">
								<span class=""buy-in"">Buy Now</span>
							</div>
						</a>	
					</div>
					<p class=""tun"">It is a long established fact that a reader</p>
					<a href=""#"" class=""item_add""><p class=""number item_price""><i> </i>$500.00</p></a>
				</div>
			</div>
			<div class=""clearfix""></div>
		</div>
		<div class=""clearfix""> </div>
	</div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

	<!--initiate accordion-->
	<script>
		$(function() {
			var menu_ul = $('.menu > li > ul'),
			        menu_a  = $('.menu > li > a');
			menu_ul.hide();
			menu_a.click(function(e) {
			    e.preventDefault();
			    if(!$(this).hasClass('active')) {
			        menu_a.removeClass('active');
			        menu_ul.filter(':visible').slideUp('normal');
			        $(this).addClass('active').next().stop(true,true).slideDown('normal');
			    } else {
			        $(this).removeClass('active');
			        $(this).next().stop(true,true).slideUp('normal');
			    }
			});
			
		});
	</script>

	<!-- FlexSlider -->
	");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "795281ef727d3a79c088a13397f6bc15a7b27e1123540", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\t<!-- Can also be used with $(document).ready() -->\r\n\t<script>\r\n\t\t$(window).load(function() {\r\n\t\t  $(\'.flexslider\').flexslider({\r\n\t\t\tanimation: \"slide\",\r\n\t\t\tcontrolNav: \"thumbnails\"\r\n\t\t  });\r\n\t\t});\r\n\t</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
