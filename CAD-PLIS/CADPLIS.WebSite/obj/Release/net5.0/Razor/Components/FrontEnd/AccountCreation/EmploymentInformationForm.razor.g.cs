#pragma checksum "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Components\FrontEnd\AccountCreation\EmploymentInformationForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34a0df01557b943e9ab430d175e7fc5e9344654c"
// <auto-generated/>
#pragma warning disable 1591
namespace CADPLIS.WebSite.Components.FrontEnd.AccountCreation
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.Components.FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.Components.LandingPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.Components.Layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.Domain.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using BlazorStrap.Extensions.TreeView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.Domain.MCApplications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.HttpClients;

#line default
#line hidden
#nullable disable
    public partial class EmploymentInformationForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "id", "personalInformationForm");
            __builder.AddMarkupContent(2, "<div class=\"row formHeader my-3\"><p>\r\n            Please enter your current employment information (if applicable)\r\n        </p></div>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Components\FrontEnd\AccountCreation\EmploymentInformationForm.razor"
                     model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-12");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<div class=\"row\"><label for=\"empStatusInput\">Employment status*</label></div>\r\n                    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "row");
                __builder2.OpenComponent<CADPLIS.WebSite.Components.FrontEnd.RadioButtonInput>(15);
                __builder2.AddAttribute(16, "Type", "EmploymentStatus");
                __builder2.AddAttribute(17, "Class", "flex-row");
                __builder2.AddAttribute(18, "GetSelectedValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 15 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Components\FrontEnd\AccountCreation\EmploymentInformationForm.razor"
                                                                                                      GetSelectedValue

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 20 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Components\FrontEnd\AccountCreation\EmploymentInformationForm.razor"
         if (model.EmpStatus == "Employed")
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "row");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-6");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "<label for=\"industryOfEmployerInput\">Industry of employer</label>\r\n                        ");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "type", "text");
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "id", "industryOfEmployerInput");
                __builder2.AddAttribute(30, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 26 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Components\FrontEnd\AccountCreation\EmploymentInformationForm.razor"
                                                                                                                                       validation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Components\FrontEnd\AccountCreation\EmploymentInformationForm.razor"
                                                                                                          model.Industry

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.Industry = __value, model.Industry));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-6");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "<label for=\"employerNameInput\">Employer Name</label>\r\n                        ");
                __builder2.OpenElement(39, "input");
                __builder2.AddAttribute(40, "type", "text");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "id", "employerNameInput");
                __builder2.AddAttribute(43, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 32 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Components\FrontEnd\AccountCreation\EmploymentInformationForm.razor"
                                                                                                                                     validation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Components\FrontEnd\AccountCreation\EmploymentInformationForm.razor"
                                                                                                    model.EmployerName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.EmployerName = __value, model.EmployerName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "row");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "col-6");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-group");
                __builder2.AddMarkupContent(53, "<label for=\"staffCardNumberInput\">Staff Card Number</label>\r\n                        ");
                __builder2.OpenElement(54, "input");
                __builder2.AddAttribute(55, "type", "text");
                __builder2.AddAttribute(56, "class", "form-control");
                __builder2.AddAttribute(57, "id", "staffCardNumberInput");
                __builder2.AddAttribute(58, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 40 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Components\FrontEnd\AccountCreation\EmploymentInformationForm.razor"
                                                                                                                                       validation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Components\FrontEnd\AccountCreation\EmploymentInformationForm.razor"
                                                                                                       model.StaffNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.StaffNumber = __value, model.StaffNumber));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                ");
                __builder2.AddMarkupContent(62, "<div class=\"col-6\"><div class=\"form-group\"><label for=\"staffCardProofInput\">Proof of Staff Card*</label></div></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "row");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "col-6");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "form-group");
                __builder2.AddMarkupContent(70, "<label for=\"employedFromInput\">Employed from*</label>\r\n                        ");
                __builder2.OpenElement(71, "input");
                __builder2.AddAttribute(72, "type", "text");
                __builder2.AddAttribute(73, "class", "form-control");
                __builder2.AddAttribute(74, "id", "employedFromInput");
                __builder2.AddAttribute(75, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 54 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Components\FrontEnd\AccountCreation\EmploymentInformationForm.razor"
                                                                                                                                     validation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Components\FrontEnd\AccountCreation\EmploymentInformationForm.razor"
                                                                                                    model.EmployedFrom

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.EmployedFrom = __value, model.EmployedFrom));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                ");
                __builder2.AddMarkupContent(79, "<div class=\"col-6\"><div class=\"form-group\">\r\n                        &nbsp;\r\n                    </div></div>");
                __builder2.CloseElement();
#nullable restore
#line 63 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Components\FrontEnd\AccountCreation\EmploymentInformationForm.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(80, "\r\n    ");
            __builder.AddMarkupContent(81, @"<div class=""row"" id=""nextBtnDiv""><div class=""col-6""><button type=""button"" class=""btn btn-outline-secondary w-100"">Previous</button></div>
        <div class=""col-6""><button type=""button"" class=""btn btn-primary w-100"" id=""nextBtn"">Next</button></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\r\n<style></style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Components\FrontEnd\AccountCreation\EmploymentInformationForm.razor"
       
        [Parameter]
        public Action OnPrevActionClicked { get; set; }
        [Parameter]
        public Action OnNextActionClicked { get; set; }
    private bool isValid { get; set; } = false;
    private List<String> empStatusList = new List<String>();
    private EmploymentInformationFormModel model { get; set; } = new EmploymentInformationFormModel();

    #region Dummy Data
    private void initDummyData()
    {
        empStatusList = new List<string>();
        empStatusList.Add("Employed");
        empStatusList.Add("Not specified");
    }
    #endregion Dummy Data

    protected override void OnInitialized()
    {
        base.OnInitialized();
        initDummyData();
    }

    private void validation()
    {
        isValid = false;
        //if (!String.IsNullOrEmpty(LoginId) && !String.IsNullOrEmpty(Password) && !String.IsNullOrEmpty(RePassword) && Password == RePassword)
        if (1 == 1)
        {
            isValid = true;
        }
    }

    private void OnNextBtnClicked()
    {
        validation();
        if (isValid)
        {
            OnNextActionClicked?.Invoke();
        }
    }

    private void GetSelectedValue(String value)
    {
        model.EmpStatus = value;
        Console.WriteLine("## GetSelectedValue: " + value);
    }

    //#region Setting
    //private List<IBrowserFile> loadedFiles = new();
    //private long maxFileSize = 1024 * 15;
    //private int maxAllowedFiles = 3;
    //private bool isLoading;
    //#endregion Setting

    //private async Task UploadStaffCardProof(InputFileChangeEventArgs e)
    //{
    //    isLoading = true;
    //    loadedFiles.Clear();

    //    foreach (var file in e.GetMultipleFiles(maxAllowedFiles))
    //    {
    //        try
    //        {
    //            loadedFiles.Add(file);

    //            var trustedFileNameForFileStorage = Path.GetRandomFileName();
    //            //var path = Path.Combine(Environment.ContentRootPath,
    //            //        Environment.EnvironmentName, "unsafe_uploads",
    //            //        trustedFileNameForFileStorage);
    //            var path = trustedFileNameForFileStorage;

    //            await using FileStream fs = new(path, FileMode.Create);
    //            await file.OpenReadStream(maxFileSize).CopyToAsync(fs);
    //        }
    //        catch (Exception ex)
    //        {
    //            //Logger.LogError("File: {Filename} Error: {Error}", file.Name, ex.Message);
    //            Console.WriteLine("File: {Filename} Error: {Error}", file.Name, ex.Message);
    //        }
    //    }
    //    isLoading = false;
    //}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591