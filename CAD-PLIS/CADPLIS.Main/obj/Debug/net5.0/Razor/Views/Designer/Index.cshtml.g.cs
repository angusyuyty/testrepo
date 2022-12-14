#pragma checksum "D:\project\CAD-PLIS\CADPLIS.Main\Views\Designer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f043857c63def48d7791ca8489fc47fd4ac76ca2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Designer_Index), @"mvc.1.0.view", @"/Views/Designer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f043857c63def48d7791ca8489fc47fd4ac76ca2", @"/Views/Designer/Index.cshtml")]
    public class Views_Designer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\project\CAD-PLIS\CADPLIS.Main\Views\Designer\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<script");
            BeginWriteAttribute("src", " src=\"", 66, "\"", 102, 1);
#nullable restore
#line 6 "D:\project\CAD-PLIS\CADPLIS.Main\Views\Designer\Index.cshtml"
WriteAttributeValue("", 72, Url.Content("~/js/jquery.js"), 72, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text/javascript\"></script>\r\n<link");
            BeginWriteAttribute("href", " href=\"", 143, "\"", 188, 1);
#nullable restore
#line 7 "D:\project\CAD-PLIS\CADPLIS.Main\Views\Designer\Index.cshtml"
WriteAttributeValue("", 150, Url.Content("~/css/semantic.min.css"), 150, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n<link");
            BeginWriteAttribute("href", " href=\"", 232, "\"", 269, 1);
#nullable restore
#line 8 "D:\project\CAD-PLIS\CADPLIS.Main\Views\Designer\Index.cshtml"
WriteAttributeValue("", 239, Url.Content("~/css/site.css"), 239, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n\r\n<link");
            BeginWriteAttribute("href", " href=\"", 315, "\"", 366, 1);
#nullable restore
#line 10 "D:\project\CAD-PLIS\CADPLIS.Main\Views\Designer\Index.cshtml"
WriteAttributeValue("", 322, Url.Content("~/css/pace-theme-minimal.css"), 322, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n<script>window.paceOptions = { restartOnPushState: false };</script>\r\n<script");
            BeginWriteAttribute("src", " src=\"", 482, "\"", 520, 1);
#nullable restore
#line 12 "D:\project\CAD-PLIS\CADPLIS.Main\Views\Designer\Index.cshtml"
WriteAttributeValue("", 488, Url.Content("~/js/pace.min.js"), 488, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text/javascript\"></script>\r\n<link href=\"/css/workflowdesigner.min.css\" rel=\"stylesheet\" type=\"text/css\" />\r\n<script src=\"/js/workflowdesigner.min.js\" type=\"text/javascript\"></script>\r\n\r\n<form");
            BeginWriteAttribute("action", " action=\"", 719, "\"", 728, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""uploadform"" method=""post"" enctype=""multipart/form-data"" onsubmit=""tmp()"" style=""padding-top: 8px;"">
    <div>
        <a href=""javascript:OnNew()"" class=""ui secondary button"">New scheme</a>
        <a href=""javascript:OnSave()"" class=""ui secondary button"">Save scheme</a>
        <a href=""javascript:DownloadScheme()"" class=""ui primary button"">Download XML</a>
        <a href=""javascript:SelectScheme('wfe')"" class=""ui secondary button"">Upload XML</a>
        <a href=""javascript:DownloadSchemeBPMN()"" class=""ui secondary button"">Download BPMN2</a>
        <a href=""javascript:SelectScheme('bpmn')"" class=""ui secondary button"">Upload BPMN2</a>
    </div>
    <input type=""file"" name=""uploadFile"" id=""uploadFile"" style=""display:none"" onchange=""javascript: UploadScheme(this);"">
</form>
<div id=""wfdesigner"" style=""min-height:600px""></div>

<script>
    var QueryString = function () {
        // This function is anonymous, is executed immediately and
        // the return value is assigned to QueryStr");
            WriteLiteral(@"ing!

        var query_string = {};
        var query = window.location.search.substring(1);
        var vars = query.split(""&"");
        for (var i = 0; i < vars.length; i++) {
            var pair = vars[i].split(""="");
            // If first entry with this name
            if (typeof query_string[pair[0]] === ""undefined"") {
                query_string[pair[0]] = pair[1];
                // If second entry with this name
            } else if (typeof query_string[pair[0]] === ""string"") {
                var arr = [query_string[pair[0]], pair[1]];
                query_string[pair[0]] = arr;
                // If third or later entry with this name
            } else {
                query_string[pair[0]].push(pair[1]);
            }
        }
        return query_string;
    }();

    var schemecode = QueryString.code ? QueryString.code : 'SimpleWF';//'InlineScheme';
    var processid = QueryString.processid;
    var graphwidth = 1200;
    var graphminheight = 600;
    var grap");
            WriteLiteral(@"hheight = graphminheight;

    var wfdesigner = undefined;
    function wfdesignerRedraw() {
        var data;

        if (wfdesigner != undefined) {
            wfdesigner.destroy();
        }

        wfdesigner = new WorkflowDesigner({
            name: 'simpledesigner',
            apiurl: '/Designer/API',
            renderTo: 'wfdesigner',
            templatefolder: '/templates/',
            graphwidth: graphwidth,
            graphheight: graphheight
        });
        debugger
        if (data == undefined) {
            var isreadonly = false;
            if (processid != undefined && processid != '')
                isreadonly = true;

            var p = { schemecode: schemecode, processid: processid, readonly: isreadonly };
            if (wfdesigner.exists(p))
                wfdesigner.load(p);
            else
                wfdesigner.create(schemecode);
        }
        else {
            wfdesigner.data = data;
            wfdesigner.render();
        }");
            WriteLiteral(@"
    }

    wfdesignerRedraw();

    $(window).resize(function () {
        if (window.wfResizeTimer) {
            clearTimeout(window.wfResizeTimer);
            window.wfResizeTimer = undefined;
        }
        window.wfResizeTimer = setTimeout(function () {
            var w = $(window).width();
            var h = $(window).height();

            if (w > 300)
                graphwidth = w - 40;

            if (h > 300)
                graphheight = h - 250;

            if (graphheight < graphminheight)
                graphheight = graphminheight;

            wfdesigner.resize(graphwidth, graphheight);
        }, 150);

    });

    $(window).resize();

    function DownloadScheme() {
        wfdesigner.downloadscheme();
    }

    function DownloadSchemeBPMN() {
        wfdesigner.downloadschemeBPMN();
    }

    var selectSchemeType;
    function SelectScheme(type) {
        if (type)
            selectSchemeType = type;

        var file = $('#uploadFil");
            WriteLiteral(@"e');
        file.trigger('click');
    }

    function UploadScheme(form) {

        if (form.value == """")
            return;

        if (selectSchemeType == ""bpmn"") {
            wfdesigner.uploadschemeBPMN($('#uploadform')[0], function () {
                wfdesigner.autoarrangement();
                alert('The file is uploaded!');
            });
        }
        else {
            wfdesigner.uploadscheme($('#uploadform')[0], function () {
                alert('The file is uploaded!');
            });
        }
    }

    function OnSave() {
        wfdesigner.schemecode = schemecode;

        var err = wfdesigner.validate();
        if (err != undefined && err.length > 0) {
            alert(err);
        }
        else {
            wfdesigner.save(function () {
                alert('The scheme is saved!');
            });
        }
    }
    function OnNew() {
        wfdesigner.create();
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
