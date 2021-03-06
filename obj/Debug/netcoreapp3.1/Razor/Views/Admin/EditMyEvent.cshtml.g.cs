#pragma checksum "D:\NET_Workspace\CodexEvents\Views\Admin\EditMyEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45ba002c4255a6979d237aed00ff138f1c612d58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditMyEvent), @"mvc.1.0.view", @"/Views/Admin/EditMyEvent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45ba002c4255a6979d237aed00ff138f1c612d58", @"/Views/Admin/EditMyEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce086ff6333d3f2cf17b96db242419ceb7d9edb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditMyEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CodexEvents.Models.Event>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editEvent_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\NET_Workspace\CodexEvents\Views\Admin\EditMyEvent.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\NET_Workspace\CodexEvents\Views\Admin\EditMyEvent.cshtml"
  
    Event e = ViewBag.Event;
    DateTime eventTime = e.Time;
    string eventTimeStr = eventTime.ToString("yyyy'-'MM'-'dd'T'HH':'mm");

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45ba002c4255a6979d237aed00ff138f1c612d585553", async() => {
                WriteLiteral(@"
    <meta charset=""ISO-8859-1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <link href=""https://fonts.googleapis.com/css?family=Montserrat"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Lato"" rel=""stylesheet"" type=""text/css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-validator/0.4.5/js/bootstrapvalidator.min.js""></script>
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
        }");
                WriteLiteral(@"

            .navbar li a, .navbar .navbar-brand {
                color: #fff !important;
            }

        .navbar-nav li a:hover, .navbar-nav li.active a {
            color: #f4511e !important;
            background-color: #fff !important;
        }

        .navbar-default .navbar-toggle {
            border-color: transparent;
            color: #fff !important;
        }

        .neomorphism {
            width: 85%;
            margin: 0 auto;
            border-radius: 16px;
            background: #ffffff;
            box-shadow: 10px 10px 21px #8a8a8a, -10px -10px 21px #ffffff;
            font-family: Montserrat, sans-serif;
            padding: 30px;
            padding-top: 50px;
        }
    </style>
    <script>
        $(document).ready(function () {
            $('#editEvent_form').bootstrapValidator({
                // To use feedback icons, ensure that you use Bootstrap v3.1.0 or later
                feedbackIcons: {
                    valid: 'gl");
                WriteLiteral(@"yphicon glyphicon-ok',
                    invalid: 'glyphicon glyphicon-remove',
                    validating: 'glyphicon glyphicon-refresh'
                },
                fields: {
                    name: {
                        validators: {
                            stringLength: {
                                min: 2,
                            },
                            notEmpty: {
                                message: 'Please enter the Name of Event'
                            }
                        }
                    },
                    description: {
                        validators: {
                            stringLength: {
                                min: 2,
                            },
                            notEmpty: {
                                message: 'Please enter event description'
                            }
                        }
                    },
                    location: {
                      ");
                WriteLiteral(@"  validators: {
                            stringLength: {
                                min: 1,
                            },
                            notEmpty: {
                                message: 'Please enter event location'
                            }
                        }
                    },
                }
            })
                .on('success.form.bv', function (e) {
                    $('#success_message').slideDown({ opacity: ""show"" }, ""slow"") // Do something ...
                    $('#addCourse_form').data('bootstrapValidator').resetForm();
                    // Prevent form submission
                    e.preventDefault();
                    // Get the form instance
                    var $form = $(e.target);
                    // Get the BootstrapValidator instance
                    var bv = $form.data('bootstrapValidator');
                    // Use Ajax to submit form data
                    $.post($form.attr('action'), $form.seriali");
                WriteLiteral("ze(), function (result) {\r\n                        console.log(result);\r\n                    }, \'json\');\r\n                });\r\n        });\r\n    </script>\r\n    <title>Edit Event Details</title>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45ba002c4255a6979d237aed00ff138f1c612d5810997", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-default navbar-fixed-top"">
        <div class=""container"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target=""#myNavbar"">
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
                <a class=""navbar-brand"" href=""ShowDashboard"">CodeX Events</a>
            </div>
            <div class=""collapse navbar-collapse"" id=""myNavbar"">
                <ul class=""nav navbar-nav navbar-right"">
                    <li><a href=""ShowProfile"">My Profile</a></li>
                    <li><a href=""PerformLogout"">Logout</a></li>
                </ul>
            </div>
        </div>
    </nav>
    <div class=""neomorphism"">
        <h2>Edit Event Details</h2><hr />
        <div>Edit event details</div>
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45ba002c4255a6979d237aed00ff138f1c612d5812262", async() => {
                    WriteLiteral(@"
            <div class=""form-group"">
                <label class=""col-md-4 control-label"">Event ID</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
                        <input class=""form-control"" name=""id""");
                    BeginWriteAttribute("value", " value=\"", 6014, "\"", 6027, 1);
#nullable restore
#line 147 "D:\NET_Workspace\CodexEvents\Views\Admin\EditMyEvent.cshtml"
WriteAttributeValue("", 6022, e.Id, 6022, 5, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" READONLY type=""text"" />
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-md-4 control-label"">Name</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-bullhorn""></i></span>
                        <input class=""form-control""");
                    BeginWriteAttribute("value", " value=\"", 6499, "\"", 6514, 1);
#nullable restore
#line 156 "D:\NET_Workspace\CodexEvents\Views\Admin\EditMyEvent.cshtml"
WriteAttributeValue("", 6507, e.Name, 6507, 7, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" type=""text"" name=""name"" />
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-md-4 control-label"">Description</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-list-alt""></i></span>
                        <input class=""form-control""");
                    BeginWriteAttribute("value", " value=\"", 6996, "\"", 7018, 1);
#nullable restore
#line 165 "D:\NET_Workspace\CodexEvents\Views\Admin\EditMyEvent.cshtml"
WriteAttributeValue("", 7004, e.Description, 7004, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" type=""text"" name=""description"" />
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-md-4 control-label"">Time</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-calendar""></i></span>
                        <input type=""datetime-local"" name=""time""");
                    BeginWriteAttribute("value", " value=\"", 7513, "\"", 7534, 1);
#nullable restore
#line 174 "D:\NET_Workspace\CodexEvents\Views\Admin\EditMyEvent.cshtml"
WriteAttributeValue("", 7521, eventTimeStr, 7521, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" class=""form-control"" />
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-md-4 control-label"">Location</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-map-marker""></i></span>
                        <input class=""form-control""");
                    BeginWriteAttribute("value", " value=\"", 8012, "\"", 8031, 1);
#nullable restore
#line 183 "D:\NET_Workspace\CodexEvents\Views\Admin\EditMyEvent.cshtml"
WriteAttributeValue("", 8020, e.Location, 8020, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" type=""text"" name=""location"" />
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-md-4 control-label"">TotalSeats</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
                        <input class=""form-control"" type=""number""");
                    BeginWriteAttribute("value", " value=\"", 8526, "\"", 8547, 1);
#nullable restore
#line 192 "D:\NET_Workspace\CodexEvents\Views\Admin\EditMyEvent.cshtml"
WriteAttributeValue("", 8534, e.TotalSeats, 8534, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" name=""totalSeats"" />
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <label class=""col-md-4 control-label""></label>
                <div class=""col-md-4"">
                    <br>
                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<button type=""submit"" class=""btn btn-warning"">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbspSAVE EVENT&nbsp&nbsp<span class=""glyphicon glyphicon-check""></span>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</button>
                </div>
            </div>

        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
