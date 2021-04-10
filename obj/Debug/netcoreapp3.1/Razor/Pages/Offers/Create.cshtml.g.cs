#pragma checksum "C:\Users\broke\source\repos\OtoMoto\Pages\Offers\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f537a06a7c8c50a6b2df490b9b56ff7a8295d2ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OtoMoto.Pages.Offers.Pages_Offers_Create), @"mvc.1.0.razor-page", @"/Pages/Offers/Create.cshtml")]
namespace OtoMoto.Pages.Offers
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
#line 1 "C:\Users\broke\source\repos\OtoMoto\Pages\_ViewImports.cshtml"
using OtoMoto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/Create")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f537a06a7c8c50a6b2df490b9b56ff7a8295d2ba", @"/Pages/Offers/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07456d661dd8dd917655bb1f3a5258a1a627cb88", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Offers_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\broke\source\repos\OtoMoto\Pages\Offers\Create.cshtml"
  
    ViewData["Title"] = "Dodaj ogłoszenie";
    var error = TempData["ErrorMessage"] as string;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Dodaj ogłoszenie</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\broke\source\repos\OtoMoto\Pages\Offers\Create.cshtml"
 if (error?.Length > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"color:red;\">");
#nullable restore
#line 12 "C:\Users\broke\source\repos\OtoMoto\Pages\Offers\Create.cshtml"
                        Write(error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    <br />\r\n    <br />\r\n");
#nullable restore
#line 15 "C:\Users\broke\source\repos\OtoMoto\Pages\Offers\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"box\" style=\"justify-content: center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f537a06a7c8c50a6b2df490b9b56ff7a8295d2ba4562", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label for=""exampleFormControlTextarea1"">Marka Pojazdu</label>
            <input id=""Make"" class=""form-control"" name=""Make"" placeholder=""Marka pojazdu"" />
        </div>
        <div class=""form-group"">
            <label for=""exampleFormControlTextarea1"">Model Pojazdu</label>
            <input id=""Model"" class=""form-control"" name=""Model"" placeholder=""Model pojazdu"" />
        </div>
        <div class=""form-group"">
            <label for=""exampleFormControlTextarea1"">Tytuł Oferty</label>
            <input class=""form-control"" name=""Title"" type=""text"" placeholder=""Tytuł"">
        </div>
        <div class=""form-group"">
            <label for=""exampleFormControlTextarea1"">Opis Oferty</label>
            <textarea id=""TextArea"" class=""form-control"" onchange=""TextArea2Input()"" rows=""3""></textarea>
            <input id=""Description"" type=""hidden"" name=""Description"" />
        </div>
        <div class=""form-group"">
            <label for=""exampl");
                WriteLiteral(@"eFormControlTextarea1"">Dane Kontaktowe</label>
            <input id=""Kontakt"" class=""form-control"" name=""Kontakt"" placeholder=""Podaj dane kontaktowe (e-mail, tel.)"" />
        </div>
        <div class=""form-group"">
            <label for=""exampleFormControlTextarea1"">Rocznik</label>
            <input class=""form-control"" name=""Rocznik"" min=""1950"" max=""2020"" type=""number"" placeholder=""Podaj rok produkcji"">
        </div>
        <div class=""form-group"">
            <label for=""exampleFormControlTextarea1"">Przebieg (km)</label>
            <input class=""form-control"" name=""Przebieg"" min=""0"" max=""5000000"" type=""number"" placeholder=""Podaj przebieg w kilometrach"">
        </div>

        <div class=""form-group"" >
            <label for=""exampleFormControlTextarea1"">Typ paliwa pojazdu</label>
            <select name=""TypPaliwaId"" class=""custom-select"" input id=""TypPaliwa"">
");
#nullable restore
#line 51 "C:\Users\broke\source\repos\OtoMoto\Pages\Offers\Create.cshtml"
                 foreach (var item in Model.TypyPaliwa)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f537a06a7c8c50a6b2df490b9b56ff7a8295d2ba7143", async() => {
#nullable restore
#line 53 "C:\Users\broke\source\repos\OtoMoto\Pages\Offers\Create.cshtml"
                        Write(item.Nazwa);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\broke\source\repos\OtoMoto\Pages\Offers\Create.cshtml"
       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\broke\source\repos\OtoMoto\Pages\Offers\Create.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label for=\"exampleFormControlTextarea1\">Typ nadwozia pojazdu</label>\r\n            <select name=\"NadwoziePojazduId\" class=\"custom-select\" input id=\"NadwoziePojazdu\">\r\n");
#nullable restore
#line 61 "C:\Users\broke\source\repos\OtoMoto\Pages\Offers\Create.cshtml"
                 foreach (var item in Model.TypyNadwozia)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f537a06a7c8c50a6b2df490b9b56ff7a8295d2ba9652", async() => {
#nullable restore
#line 63 "C:\Users\broke\source\repos\OtoMoto\Pages\Offers\Create.cshtml"
                        Write(item.Nazwa);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\broke\source\repos\OtoMoto\Pages\Offers\Create.cshtml"
       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\broke\source\repos\OtoMoto\Pages\Offers\Create.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </select>
        </div>

        <div class=""form-group"">
            <label for=""exampleFormControlTextarea1"">Cena (w PLN)</label>
            <input id=""Cena"" class=""form-control"" name=""Cena"" min=""0"" max=""50000000"" type=""number"" placeholder=""Podaj cenę pojazdu"">
        </div>

        <div id=""images"" style=""display:none;"">

        </div>

        <div id=""imagesPreview"">

        </div>

        <div class=""uploader"" onclick=""$('#filePhoto').click()"">
            <input type=""file"" name=""userprofile_picture"" id=""filePhoto"" />
            Przeciągnij lub kliknij aby dodać zdjęcie
        </div>
        <br />
        <button type=""submit"" class=""btn btn-primary"">Dodaj</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

    <script>
        var imageLoader = document.getElementById('filePhoto');
        imageLoader.addEventListener('change', handleImage, false);

        function handleImage(e) {
            var reader = new FileReader();
            var images = document.getElementById(""imagesPreview"");
            reader.onload = function (event) {
                let base64 = event.target.result;
                let img = document.createElement('img');
                img.setAttribute(""src"", base64);
                img.height = 600;
                img.width = 800; //rozmiar zdjęcia przy dodawaniu ogłoszenia
                images.appendChild(img);
                upload(base64);
            }
            reader.readAsDataURL(e.target.files[0]);
        }

        function upload(base64) {
            var url = ""/UploadImage"";
            var base64ImageContent = base64.replace(/^data:image\/(png|jpg);base64,/, """");
            var blob = base64ToBlob(base64ImageContent, 'image/png');
 ");
            WriteLiteral(@"           var formData = new FormData();
            formData.append('Image', blob);

            $.ajax({
                url: url,
                type: ""POST"",
                cache: false,
                contentType: false,
                processData: false,
                data: formData
            })
                .done(function (e) {
                    let inp = document.createElement('input');
                    inp.setAttribute(""name"", ""Images[]"");
                    inp.setAttribute(""type"", ""hidden"");
                    inp.setAttribute(""value"", e);

                    document.getElementById(""images"").appendChild(inp);
                });
        }

        function base64ToBlob(base64, mime) {
            mime = mime || '';
            var sliceSize = 1024;
            var byteChars = window.atob(base64);
            var byteArrays = [];

            for (var offset = 0, len = byteChars.length; offset < len; offset += sliceSize) {
                var slice = ");
            WriteLiteral(@"byteChars.slice(offset, offset + sliceSize);

                var byteNumbers = new Array(slice.length);
                for (var i = 0; i < slice.length; i++) {
                    byteNumbers[i] = slice.charCodeAt(i);
                }
                var byteArray = new Uint8Array(byteNumbers);
                byteArrays.push(byteArray);
            }

            return new Blob(byteArrays, { type: mime });
        }

        function TextArea2Input() {
            document.getElementById(""Description"").value = document.getElementById(""TextArea"").value;
        }
    </script>

    <style>
        .uploader {
            margin-top: 15px;
            position: relative;
            overflow: hidden;
            width: 100px;
            height: 100px;
            background: #f3f3f3;
            border: 2px dashed #e8e8e8;
        }

        #filePhoto {
            position: absolute;
            width: 300px;
            height: 400px;
            top: -50px;
          ");
            WriteLiteral(@"  left: 0;
            z-index: 2;
            opacity: 0;
            cursor: pointer;
        }

        .uploader img {
            position: absolute;
            width: 15%;
            height: 15%;
            top: -1px;
            left: -1px;
            z-index: 1;
            border: none;
        }

        .box {
            margin: 5px;
            margin-right: 15%;
            margin-left: 15%;
        }
    </style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OtoMoto.Pages.Offers.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OtoMoto.Pages.Offers.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OtoMoto.Pages.Offers.CreateModel>)PageContext?.ViewData;
        public OtoMoto.Pages.Offers.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
