#pragma checksum "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bb343ad571fd13b82f3ccb8764cf719cbf6b832"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#line 1 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\_ViewImports.cshtml"
using MovieStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\_ViewImports.cshtml"
using MovieStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bb343ad571fd13b82f3ccb8764cf719cbf6b832", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a8c2dc702b202c6daeaeb5df09bdab9162bf52c", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieStore.Models.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/reviewSearch.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/MovieDetails/detailsStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reviews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("One movies"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(" "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/reviewSearch.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.dotdotdot.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
  
    ViewData [ "Title" ] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--\r\nauthor: W3layouts\r\nauthor URL: http://w3layouts.com\r\nLicense: Creative Commons Attribution 3.0 Unported\r\nLicense URL: http://creativecommons.org/licenses/by/3.0/\r\n-->\r\n<!-- single -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9bb343ad571fd13b82f3ccb8764cf719cbf6b8327580", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9bb343ad571fd13b82f3ccb8764cf719cbf6b8328695", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""single-page-agile-main"">
    <div class=""container"">
        <div class=""single-page-agile-info"">
            <!-- /movie-browse-agile -->
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-4 video-grid-single-page-agileits"">
                        <img");
            BeginWriteAttribute("src", " src=", 763, "", 781, 1);
#nullable restore
#line 25 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
WriteAttributeValue("", 768, Model.Poster, 768, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 781, "\"", 787, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\" id=\"single-poster\" />\r\n                    </div>\r\n                    <div class=\"col-md-8 coloum\">\r\n                        <p class=\"fexi_header\">");
#nullable restore
#line 28 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <div class=""row"">
                            <div class=""col-sm-2"">
                                <div class=""profile-details"">
                                    Story Line :
                                </div>
                            </div>
                            <div class=""col-sm-10"">
                                <div class=""profile-details-content"">
                                    ");
#nullable restore
#line 37 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                               Write(Model.Storyline);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-2"">
                                <div class=""profile-details"">
                                    Date of Release :
                                </div>
                            </div>
                            <div class=""col-sm-10"">
                                <div class=""profile-details-content"">
                                    ");
#nullable restore
#line 49 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                               Write(Model.ReleaseDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-2"">
                                <div class=""profile-details"">
                                    Genres :
                                </div>
                            </div>
                            <div class=""col-sm-10"">
                                <div class=""profile-details-content"">
");
#nullable restore
#line 61 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                       if ( ViewBag.genres != null )
                                            {
                                            for ( int i = 0 ; i < ViewBag.genres.Count - 1 ; i++ )
                                                {
                                                var genre = ViewBag.genres [ i ].Type.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a href=\"genres.html\" style=\"color:black\">");
#nullable restore
#line 66 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                                                                     Write(genre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | </a>\r\n");
#nullable restore
#line 67 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                                }
                                            var genreLast = ViewBag.genres [ ViewBag.genres.Count - 1 ].Type.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a href=\"genres.html\" style=\"color:black\">");
#nullable restore
#line 69 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                                                                 Write(genreLast);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 70 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-2"">
                                <div class=""profile-details"">
                                    Actors :
                                </div>
                            </div>
                            <div class=""col-sm-10"">
                                <div class=""profile-details-content"">
");
#nullable restore
#line 82 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                       if ( ViewBag.actors != null )
                                            {
                                            for ( int i = 0 ; i < ViewBag.actors.Count - 1 ; i++ )
                                                {
                                                var actor = ViewBag.actors [ i ].Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a href=\"genres.html\" style=\"color:black\">");
#nullable restore
#line 87 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                                                                     Write(actor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | </a>\r\n");
#nullable restore
#line 88 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                                }
                                            var actorLast = ViewBag.actors [ ViewBag.actors.Count - 1 ].Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a href=\"genres.html\" style=\"color:black\">");
#nullable restore
#line 90 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                                                                 Write(actorLast);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 91 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-2"">
                                <div class=""profile-details"">
                                    Star Rating :
                                </div>
                            </div>
                            <div class=""col-sm-10"">
                                <div class=""profile-details-content"">
");
#nullable restore
#line 103 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                      

                                        int intAverageRating = (int) Math.Floor( Model.AverageRating ); // 7.3 -> 7
                                        for ( int i = 0 ; i < intAverageRating ; i++ ) // 7
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i></span>\r\n");
#nullable restore
#line 109 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                            }
                                        if ( Model.AverageRating - intAverageRating > 0 ) // 7.5 - 7 = 0.5
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span href=\"#\"><i class=\"fa fa-star-half-o\" aria-hidden=\"true\"></i></span>\r\n");
#nullable restore
#line 113 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                            }
                                        else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span href=\"#\"><i class=\"fa fa-star-o\" aria-hidden=\"true\"></i></span>\r\n");
#nullable restore
#line 117 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                            }
                                        for ( int i = 1 ; i < 10 - intAverageRating ; i++ ) //10-7 = 3
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span href=\"#\"><i class=\"fa fa-star-o\" aria-hidden=\"true\"></i></span>\r\n");
#nullable restore
#line 121 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                            }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                            </div>
                        </div>
            }
                    </div>
                </div>
                <div class=""song-grid-right"">
                    <div class=""share"">
                        <h5>Share this</h5>
                        <div class=""single-agile-shar-buttons"">
                            <ul>
                                <li>
                                    <div class=""fb-like"" data-href=""https://www.facebook.com/w3layouts"" data-layout=""button_count"" data-action=""like"" data-size=""small"" data-show-faces=""false"" data-share=""false""></div>
                                    <script>
                                        (function (d, s, id) {
                                            var js, fjs = d.getElementsByTagName(s)[0];
                                            if (d.getElementById(id)) return;
                                            js = d.createElement(s); js.id = id;
");
            WriteLiteral(@"                                            js.src = ""//connect.facebook.net/en_GB/sdk.js#xfbml=1&version=v2.7"";
                                            fjs.parentNode.insertBefore(js, fjs);
                                        }(document, 'script', 'facebook-jssdk'));</script>
                                </li>
                                <li>
                                    <div class=""fb-share-button"" data-href=""https://www.facebook.com/w3layouts"" data-layout=""button_count"" data-size=""small"" data-mobile-iframe=""true""><a class=""fb-xfbml-parse-ignore"" target=""_blank"" href=""https://www.facebook.com/sharer/sharer.php?u=https%3A%2F%2Fwww.facebook.com%2Fw3layouts&amp;src=sdkpreparse"">Share</a></div>
                                </li>
                                <li class=""news-twitter"">
                                    <a href=""https://twitter.com/w3layouts"" class=""twitter-follow-button"" data-show-count=""false"">Follow w3layouts</a>
                                    <script ");
            WriteLiteral(@"async src=""//platform.twitter.com/widgets.js"" charset=""utf-8""></script>
                                </li>
                                <li>
                                    <a href=""https://twitter.com/intent/tweet?screen_name=w3layouts"" class=""twitter-mention-button"" data-show-count=""false"">Tweet to w3layouts</a>
                                    <script async src=""//platform.twitter.com/widgets.js"" charset=""utf-8""></script>
                                </li>
                                <li>
                                    <!-- Place this tag where you want the +1 button to render. -->
                                    <div class=""g-plusone"" data-size=""medium""></div>

                                    <!-- Place this tag after the last +1 button tag. -->
                                    <script type=""text/javascript"">
                                        (function () {
                                            var po = document.createElement('script'); po.type ");
            WriteLiteral(@"= 'text/javascript'; po.async = true;
                                            po.src = 'https://apis.google.com/js/platform.js';
                                            var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);
                                        })();
                                    </script>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""clearfix""> </div>

                <div class=""s01"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bb343ad571fd13b82f3ccb8764cf719cbf6b83224511", async() => {
                WriteLiteral("\r\n                        <fieldset>\r\n");
                WriteLiteral(@"                            <h1 style=""color:black "">Search Review:</h1>
                        </fieldset>
                        <div class=""inner-form"">

                            <div class=""input-field second-wrap"">
                                <input id=""fromYears"" type=""text"" placeholder=""From"" />
                            </div>

                            <div class=""input-field second-wrap"">
                                <input id=""toYears"" type=""text"" placeholder=""To"" />
                            </div>

                            <div class=""input-field second-wrap"">
                                <input id=""user"" type=""text"" placeholder=""User"" />
                            </div>

                            <div class=""input-field second-wrap"">
                                <input id=""content"" type=""text"" placeholder=""Content"" />
                            </div>

                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"clearfix\"> </div>\r\n\r\n                <div class=\"all-comments\">\r\n");
#nullable restore
#line 206 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                     if ( Context.Session.GetString( "Type" ) != null )
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"all-comments-info\">\r\n                            <a href=\"#\">Comments</a>\r\n                            <div class=\"agile-info-wthree-box\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bb343ad571fd13b82f3ccb8764cf719cbf6b83227493", async() => {
                WriteLiteral(@"
                                    <input type=""text"" placeholder=""Headline"" name=""Headline"">
                                    <input type=""text"" placeholder=""Content"" name=""Content"">
                                    <input type=""text"" placeholder=""Rating"" name=""Rating"">
                                    <input name=""movieid""");
                BeginWriteAttribute("value", " value=\"", 12148, "\"", 12165, 1);
#nullable restore
#line 215 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
WriteAttributeValue("", 12156, Model.Id, 12156, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\" />\r\n                                    <input name=\"userid\"");
                BeginWriteAttribute("value", " value=\"", 12241, "\"", 12287, 1);
#nullable restore
#line 216 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
WriteAttributeValue("", 12249, Context.Session.GetString( "UserId" ), 12249, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\" />\r\n                                    <input type=\"submit\" value=\"SEND\">\r\n                                    <div class=\"clearfix\"> </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 222 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"media-grids\">\r\n");
#nullable restore
#line 226 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                           if ( ViewBag.reviews != null )
                                foreach ( Review review in ViewBag.reviews )
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"media\">\r\n                                        <h5>");
#nullable restore
#line 230 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                       Write(review.Headline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <div class=\"media-left\">\r\n                                            <a href=\"#\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9bb343ad571fd13b82f3ccb8764cf719cbf6b83231880", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </a>\r\n                                        </div>\r\n                                        <div class=\"media-body\">\r\n                                            <p>");
#nullable restore
#line 237 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                          Write(review.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <div>Written by: ");
#nullable restore
#line 238 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                                        Write(review.Author.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                            <div>Published: ");
#nullable restore
#line 239 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                                       Write(review.Published.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                            <div>Rating: ");
#nullable restore
#line 240 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                                    Write(review.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 243 "C:\Users\Dell\source\repos\afikmenashe21\MovieStore\MovieStore\Views\Movies\Details.cshtml"
                                    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"clearfix\"> </div>\r\n        </div>\r\n\r\n    </div>\r\n    <!-- //w3l-latest-movies-grids -->\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bb343ad571fd13b82f3ccb8764cf719cbf6b83235227", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bb343ad571fd13b82f3ccb8764cf719cbf6b83236267", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieStore.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
