#pragma checksum "C:\Users\user\source\repos\ProjetAsp2\ProjetAsp2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9eaec361c0fed42d168bd7fc2d6b92284d4740c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\user\source\repos\ProjetAsp2\ProjetAsp2\Views\_ViewImports.cshtml"
using ProjetAsp2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\ProjetAsp2\ProjetAsp2\Views\_ViewImports.cshtml"
using ProjetAsp2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eaec361c0fed42d168bd7fc2d6b92284d4740c9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fa622aa4c29273cbb12563d03460805aec2ac34", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetAsp2.Models.Driver>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "RentCars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllCars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark-border"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive center-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\user\source\repos\ProjetAsp2\ProjetAsp2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Header-->
<header data-background=""img/main-slider-01.jpg"" class=""intro"">
    <!-- Intro Header-->
    <div class=""intro-body"">
        <h4>
            Welcome <span class=""bold"">to</span>
        </h4>
        <h1>Allo Karhba<span class=""badge hidden-sm hidden-xs"">luxury</span></h1>

    </div>


</header>


<!-- Slider-->
<section id=""about"" class=""section-small"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6"">
                <h3>Who We Are</h3>
                <p class=""no-pad"">
                    We know the difference is in the details and that’s why our car rental services, in the tourism and business industry, stand out for their quality and good taste.
                </p>
                <ul class=""mb-0"">
                    <li> We working since 2020 with 20 drivers</li>
                    <li> All brand &amp; type cars in our garage</li>
                    <li> 1000+ picking locations around Tunisia</li>
            ");
            WriteLiteral(@"    </ul>

                <h2 class=""classic"">Allo Karhba</h2>


            </div>

            <!--<div data-wow-duration=""2s"" data-wow-delay="".2s"" class=""col-lg-5 col-lg-offset-1 wow zoomIn"">
                <div id=""carousel-light2"" class=""carousel slide carousel-fade"">
                    <ol class=""carousel-indicators"">
                        <li data-target=""#carousel-light2"" data-slide-to=""0"" class=""active""></li>
                        <li data-target=""#carousel-light2"" data-slide-to=""1""></li>
                        <li data-target=""#carousel-light2"" data-slide-to=""2""></li>
                    </ol>
                    <div role=""listbox"" class=""carousel-inner"">
                        <div class=""item active""><img src=""img/misc/6.png"" alt="""" class=""img-responsive center-block""></div>
                        <div class=""item""><img src=""img/misc/5.png"" alt="""" class=""img-responsive center-block""></div>
                        <div class=""item""><img src=""img/misc/4.png"" alt="""" class=");
            WriteLiteral(@"""img-responsive center-block""></div>
                    </div>
                </div>
            </div>*/-->

        </div>
    </div>
</section>
<!-- About Section-->
<section id=""about2"" class=""bg-gray"">
    <div class=""container wow fadeIn"">
        <div class=""row"">
            <div class=""col-lg-6"">
                <h3>We have magic</h3>
                <p>Rentals are easier, faster and more advantageous. Reserve now to take advantage of special member offers, skip the line, and get an additional free driver.</p>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eaec361c0fed42d168bd7fc2d6b92284d4740c910990", async() => {
                WriteLiteral("Reserve now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


            </div>
           
        </div>
    </div>
</section>
<!-- Services Section-->
<section id=""services"" class=""bg-img7 text-center"">
    <div class=""overlay""></div>
    <div class=""container text-center"">
        <div class=""row"">
            <div class=""col-lg-8 col-lg-offset-2"">
                <h3>Our Services</h3>
                <p>We know the difference is in the details and that’s why our car rental services, in the tourism and business industry, stand out for their quality and good taste.</p>
            </div>
        </div>
        <div class=""row"">
            <div data-wow-delay=""1.6s"" class=""col-lg-3 col-sm-6 wow fadeIn"">
                <h4><i class=""icon icon-big ion-map""></i>Locations</h4>
                <p>royal car offers you 250+ Locations we come where ever you are.</p>
            </div>
            <div data-wow-delay="".2s"" class=""col-lg-3 col-sm-6 wow fadeIn"">
                <h4><i class=""icon icon-big ion-ios-person-outline""></i> vtc</h4>
     ");
            WriteLiteral(@"           <p>To facilitate your travels in Tunisia, make tailor-made excursions..</p>
            </div>
            <div data-wow-delay="".6s"" class=""col-lg-3 col-sm-6 wow fadeIn"">
                <h4><i class=""icon icon-big ion-wifi""></i> Free Wifi</h4>
                <p>royal car offers you a free wifi.</p>
            </div>
            <div data-wow-delay="".4s"" class=""col-lg-3 col-sm-6 wow fadeIn"">
                <h4><i class=""icon icon-big ion-happy-outline""></i> comfort</h4>
                <p> royal car ensures 100% your comfort.</p>
            </div>

            <div data-wow-delay="".8s"" class=""col-lg-3 col-sm-6 wow fadeIn"">
                <h4><i class=""icon icon-big ion-android-calendar""></i> Reservation</h4>
                <p> Reservation Anytime You Wants 24/7 Online Reservation.
                </p>
            </div>
            <div data-wow-delay=""1s"" class=""col-lg-3 col-sm-6 wow fadeIn"">
                <h4><i class=""icon icon-big icon ion-ios-locked-outline""></i>securi");
            WriteLiteral(@"ty</h4>
                <p>royal car ensures your security.</p>
            </div>
            <div data-wow-delay=""1.2s"" class=""col-lg-3 col-sm-6 wow fadeIn"">
                <h4><i class=""icon icon-big ion-model-s""></i>choice of car</h4>
                <p>All brand & type cars in our garage.</p>
            </div>
            <div data-wow-delay=""1.4s"" class=""col-lg-3 col-sm-6 wow fadeIn"">
                <h4><i class=""icon icon-big ion-ios-videocam-outline""></i>enjoyment</h4>
                <p>royal car offers you 100+ new films and series to enjoy the road.</p>
            </div>

        </div>
    </div>
</section>



<!-- Portfolio-->
<section id=""car"" class=""bg-white no-pad-btm"">
    <div class=""container text-center"">
        <div class=""row"">

            <div class=""col-sm-10 col-sm-offset-1"">
                <h3>Our Cars</h3>
                
            </div>
        </div>
    </div>
   
    <div class=""container-fluid"">
        <div id=""grid"" class=""row portfol");
            WriteLiteral("io-items\">\r\n");
#nullable restore
#line 143 "C:\Users\user\source\repos\ProjetAsp2\ProjetAsp2\Views\Home\Index.cshtml"
             foreach (var item in ViewBag.cars)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div data-groups=\"[&quot;design&quot;, &quot;branding&quot;]\" class=\"col-md-3 col-sm-6 no-pad\">\r\n\r\n\r\n\r\n\r\n                    <div class=\"portfolio-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eaec361c0fed42d168bd7fc2d6b92284d4740c916359", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9eaec361c0fed42d168bd7fc2d6b92284d4740c916643", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 6302, "~/images/", 6302, 9, true);
#nullable restore
#line 152 "C:\Users\user\source\repos\ProjetAsp2\ProjetAsp2\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 6311, item.CarPicture, 6311, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <div class=\"portfolio-overlay\">\r\n                                <div class=\"caption\">\r\n                                    <h5>");
#nullable restore
#line 155 "C:\Users\user\source\repos\ProjetAsp2\ProjetAsp2\Views\Home\Index.cshtml"
                                   Write(item.Nom);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                    <span>");
#nullable restore
#line 156 "C:\Users\user\source\repos\ProjetAsp2\ProjetAsp2\Views\Home\Index.cshtml"
                                     Write(item.Transmission);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 151 "C:\Users\user\source\repos\ProjetAsp2\ProjetAsp2\Views\Home\Index.cshtml"
                                                                        WriteLiteral(item.Id);

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
            WriteLiteral("\r\n\r\n                       \r\n\r\n\r\n                    </div>\r\n                    \r\n\r\n                </div>\r\n");
#nullable restore
#line 168 "C:\Users\user\source\repos\ProjetAsp2\ProjetAsp2\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n    </div>\r\n</section>\r\n<div class=\"section-small action bg-white text-center\">\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eaec361c0fed42d168bd7fc2d6b92284d4740c921687", async() => {
                WriteLiteral("View All Cars");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<!-- Team Section-->\r\n\r\n\r\n\r\n<section id=\"driver\" class=\"bg-white text-center\">\r\n    <div class=\"container\">\r\n        <h3>OUR PROFESSIONAL DRIVERS</h3>\r\n        <div class=\"row\">\r\n           \r\n            \r\n");
#nullable restore
#line 190 "C:\Users\user\source\repos\ProjetAsp2\ProjetAsp2\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 col-sm-6\">\r\n                    <p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9eaec361c0fed42d168bd7fc2d6b92284d4740c923930", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7410, "~/images/", 7410, 9, true);
#nullable restore
#line 194 "C:\Users\user\source\repos\ProjetAsp2\ProjetAsp2\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7419, item.DriverPicture, 7419, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </p>\r\n                    <h2 class=\"classic\">\r\n                        ");
#nullable restore
#line 197 "C:\Users\user\source\repos\ProjetAsp2\ProjetAsp2\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(Modelitem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h2>
                    <ul class=""list-inline"">
                        <li><a href=""/""><i class=""fa fa-twitter fa-lg""></i></a></li>
                        <li><a href=""/""><i class=""fa fa-facebook fa-lg""></i></a></li>
                        <li><a href=""/""><i class=""fa fa-google-plus fa-lg""></i></a></li>
                    </ul>
                   
                </div>
");
#nullable restore
#line 206 "C:\Users\user\source\repos\ProjetAsp2\ProjetAsp2\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>

<!-- Quotes-->
<section class=""quote section-small bg-img3 text-center"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-8 col-sm-offset-2"">
                <p><i class=""icon fa fa-quote-left fa-lg""></i></p>
                <p>Automobiles have always been part of my life, and I’m sure they always will be. What is it about them that moves me? The sound of a great engine, the unity and uniqueness of an automobile’s engineering and coachwork, the history of the company and the car, and, of course, the sheer beauty of the thing.</p>
                <h2 class=""no-pad classic"">Sir Edward Herrmann</h2>
            </div>
        </div>
    </div>
</section>
<!-- Why Section-->
<section>
    <div class=""container text-center"">
        <div class=""row"">
            <div class=""col-lg-8 col-lg-offset-2"">
                <h3>Why Choose Us?</h3>
            </div>
        </div>
        <div");
            WriteLiteral(@" class=""row"">
            <div data-wow-delay="".2s"" class=""col-lg-3 col-sm-6 wow fadeIn"">
                <h4><i class=""icon-big icon ion-ios-people-outline""></i>drivers with long experience</h4>
                <p>drivers with extensive experience</p>
            </div>
            <div data-wow-delay="".4s"" class=""col-lg-3 col-sm-6 wow fadeIn"">
                <h4><i class=""icon-big ion-ios-calendar-outline""></i>Reservation Anytime You Wants</h4>
                <p>24/7 Online Reservation</p>
            </div>
            <div data-wow-delay="".6s"" class=""col-lg-3 col-sm-6 wow fadeIn"">
                <h4><i class=""icon-big ion-ios-location-outline""></i> Lots of Picking Locations </h4>
                <p>250+ Locations</p>
            </div>
            <div data-wow-delay="".8s"" class=""col-lg-3 col-sm-6 wow fadeIn"">
                <h4><i class=""icon-big ion-ios-person-outline""></i> 24/7 Customer Online Support</h4>
                <p>Call us Anywhere Anytime</p>
            </div>
        <");
            WriteLiteral(@"/div>
    </div>
</section>



<!-- Contact Section-->
<section id=""contact"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5"">
                <h3>contact us</h3>
                <p>Feel free to contact us. A business has to be involving, it has to be fun, and it has to exercise your creative instincts. Start where you are. Use what you have. Do what you can. Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                <hr>
                <h5>
                    <i class=""fa fa-map-marker fa-fw fa-lg""></i> 1234 Some Avenue, New York, NY 56789
                </h5>
                <h5>
                    <i class=""fa fa-envelope fa-fw fa-lg""></i> info@youwebsite.com
                </h5>
                <h5>
                    <i class=""fa fa-phone fa-fw fa-lg""></i> (123) 456-7890
                </h5>
            </div>
            <div class=""col-md-5 col-md-offset-2"">
                <h3>Say hello</h3>
                <!--");
            WriteLiteral(" Contact Form - Enter your email address on line 17 of the mail/contact_me.php file to make this form work. For more information on how to do this please visit the Docs!-->\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eaec361c0fed42d168bd7fc2d6b92284d4740c929983", async() => {
                WriteLiteral(@"
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls"">
                            <label for=""FullName"" class=""sr-only control-label"">You Name</label>
                            <input name=""FullName"" type=""text"" placeholder=""Your FullName""");
                BeginWriteAttribute("required", " required=\"", 11723, "\"", 11734, 0);
                EndWriteAttribute();
                WriteLiteral(@" data-validation-required-message=""Please enter full name"" class=""form-control input-lg""><span class=""help-block text-danger""></span>
                        </div>
                    </div>
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls"">
                            <label for=""Email"" class=""sr-only control-label"">Your Email</label>
                            <input name=""Email"" type=""email"" placeholder=""You Email""");
                BeginWriteAttribute("required", " required=\"", 12245, "\"", 12256, 0);
                EndWriteAttribute();
                WriteLiteral(@" data-validation-required-message=""Please enter email"" class=""form-control input-lg""><span class=""help-block text-danger""></span>
                        </div>
                    </div>
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls"">
                            <label for=""Subject"" class=""sr-only control-label"">Your Subject</label>
                            <input name=""Subject"" type=""tel"" placeholder=""You Subject""");
                BeginWriteAttribute("required", " required=\"", 12769, "\"", 12780, 0);
                EndWriteAttribute();
                WriteLiteral(@" data-validation-required-message=""Please enter Subject"" class=""form-control input-lg""><span class=""help-block text-danger""></span>
                        </div>
                    </div>
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls"">
                            <label for=""Body"" class=""sr-only control-label"">Message</label>
                            <textarea name=""Body"" rows=""2"" placeholder=""Message""");
                BeginWriteAttribute("required", " required=\"", 13281, "\"", 13292, 0);
                EndWriteAttribute();
                WriteLiteral(@" data-validation-required-message=""Please enter a message."" aria-invalid=""false"" class=""form-control input-lg""></textarea><span class=""help-block text-danger""></span>
                        </div>
                    </div>
                    <div id=""success""></div>
                    <button type=""submit"" value=""Send"" class=""btn btn-dark"">Send</button>
                    <span style=""color:green"">");
#nullable restore
#line 303 "C:\Users\user\source\repos\ProjetAsp2\ProjetAsp2\Views\Home\Index.cshtml"
                                         Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Map Section\r\n<div id=\"map\"></div>\r\n    -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetAsp2.Models.Driver>> Html { get; private set; }
    }
}
#pragma warning restore 1591