#pragma checksum "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a44bf06bf116a5e1ff99d33943efafc988eea22b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ShowEventDetails), @"mvc.1.0.view", @"/Views/User/ShowEventDetails.cshtml")]
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
#line 1 "D:\NET_Workspace\CodexEvents\Views\_ViewImports.cshtml"
using CodexEvents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NET_Workspace\CodexEvents\Views\_ViewImports.cshtml"
using CodexEvents.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a44bf06bf116a5e1ff99d33943efafc988eea22b", @"/Views/User/ShowEventDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce086ff6333d3f2cf17b96db242419ceb7d9edb8", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ShowEventDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CodexEvents.Models.Event>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myPage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString(".navbar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-offset", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
  
    Event e = ViewBag.Event;
    int isUserRegistered = ViewBag.UserAlreadyRegistered;
    string prerequisite = ViewBag.prerequisite;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a44bf06bf116a5e1ff99d33943efafc988eea22b5080", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <link href=""https://fonts.googleapis.com/css?family=Montserrat"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Lato"" rel=""stylesheet"" type=""text/css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
    <meta charset=""ISO-8859-1"">
    <style>
        .navbar {
            margin-bottom: 0;
            background-color: #f4511e;
            z-index: 9999;
            border: 0;
            font-size: 12px !important;
            line-height: 1.42857143 !important;
            letter-spacing: 4px;
            border-radius: 0;
            font-family: Montserrat, sans-serif;
        }

            .navbar li a, .navbar .navbar-brand {
                color: #fff !important;
            }

        .p");
                WriteLiteral(@"rofileheading {
            padding: 60px 10px 10px 20px;
            text-align: center;
        }

        .userdetail {
            width: 30%;
        }

        .user-details-table {
            width: 85%;
            margin: 0 auto;
            border-radius: 16px;
            background: #ffffff;
            box-shadow: 10px 10px 21px #8a8a8a, -10px -10px 21px #ffffff;
            font-family: Montserrat, sans-serif;
        }

        .showRegistrationsFooter {
            background-color: #f4511e;
            letter-spacing: 4px;
            border-radius: 0;
            width: 100%;
            box-sizing: border-box;
            padding: 14px 16px;
            width: 100%;
            align-self: stretch;
        }

            .showRegistrationsFooter a {
                color: #fff !important;
                float: center;
                text-align: center;
                padding: 14px 16px;
                text-decoration: none;
                font-size: ");
                WriteLiteral(@"17px;
                border: 1px solid #f4511e;
                display: inline-block;
                width: 100%;
                height: 100%;
                align-self: stretch;
            }

                .showRegistrationsFooter a:hover {
                    color: #f4511e !important;
                    background-color: #fff !important;
                }

        .profile-buttons {
            display: flex;
            height: 30px;
            justify-content: space-around;
            flex-wrap: wrap;
            align-content: center;
            align-items: stretch;
        }

            .profile-buttons a, button {
                align-self: auto;
                width: 200px;
                padding: 20px;
            }
    </style>
    <title>Event Details</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a44bf06bf116a5e1ff99d33943efafc988eea22b9013", async() => {
                WriteLiteral(@"

    <nav class=""navbar navbar-default navbar-fixed-top"">
        <div class=""navbar-header"">
            <a class=""navbar-brand"" href=""ShowDashboard"">CodeX Events</a>
        </div>
    </nav>
    <h2 class=""profileheading"">Event Details</h2><br />

    <div class=""user-details-table"">
        <table class=""table"">
            <tr>
                <td class=""userdetail"">Event Id</td>
                <td>");
#nullable restore
#line 114 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
               Write(e.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td class=\"userdetail\">Name</td>\r\n                <td>");
#nullable restore
#line 118 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
               Write(e.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td class=\"userdetail\">Description</td>\r\n                <td>");
#nullable restore
#line 122 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
               Write(e.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td class=\"userdetail\">Time</td>\r\n                <td>");
#nullable restore
#line 126 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
               Write(e.Time);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td class=\"userdetail\">Location</td>\r\n                <td>");
#nullable restore
#line 130 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
               Write(e.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td class=\"userdetail\">Total Seats</td>\r\n                <td>");
#nullable restore
#line 134 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
               Write(e.TotalSeats);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td class=\"userdetail\">Available Seats</td>\r\n                <td>");
#nullable restore
#line 138 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
               Write(e.AvailableSeats);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 140 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
             if(prerequisite != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td class=\"userdetail\">Pre-requisites</td>\r\n                    <td>");
#nullable restore
#line 144 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
                   Write(prerequisite);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 146 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    </div>\r\n");
#nullable restore
#line 149 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
     if (isUserRegistered < 0)
    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
     if (e.AvailableSeats != 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"showRegistrationsFooter\">\r\n        <a");
                BeginWriteAttribute("href", " href=\"", 4815, "\"", 4848, 2);
                WriteAttributeValue("", 4822, "RaiseRequest?eventId=", 4822, 21, true);
#nullable restore
#line 154 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
WriteAttributeValue("", 4843, e.Id, 4843, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Raise Request</a>\r\n    </div>\r\n");
#nullable restore
#line 156 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 156 "D:\NET_Workspace\CodexEvents\Views\User\ShowEventDetails.cshtml"
     

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CodexEvents.Models.Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
