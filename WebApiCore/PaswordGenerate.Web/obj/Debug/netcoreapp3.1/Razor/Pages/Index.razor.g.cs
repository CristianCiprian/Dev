#pragma checksum "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b20ca49513801b6584f31c8410c7357120f3c324"
// <auto-generated/>
#pragma warning disable 1591
namespace PaswordGenerate.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\_Imports.razor"
using PaswordGenerate.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\_Imports.razor"
using PaswordGenerate.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\Pages\Index.razor"
using PasswordGenerate.DataModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\Pages\Index.razor"
using PaswordGenerate.DataModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\Pages\Index.razor"
using PaswordGenerate.Web.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "PageTitle");
            __builder.AddContent(1, "Index");
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.AddMarkupContent(3, "<h3>Generare parola</h3>\r\n\r\nIntroduceti id-ul user-ului si data!\r\n <hr>  \r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-field");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.AddMarkupContent(7, "<label> Id-ul userului: </label>\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddMarkupContent(9, "\r\n           ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\Pages\Index.razor"
                            UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\Pages\Index.razor"
                                                           UserId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UserId = __value, UserId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n <br> \r\n         ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-field");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.AddMarkupContent(25, "<label> Data: </label>\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(28);
            __builder.AddAttribute(29, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 26 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\Pages\Index.razor"
                             DateTimeUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\Pages\Index.razor"
                                                           DateTimeUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => DateTimeUser = __value, DateTimeUser));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n <hr> \r\n\r\n  ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(40);
            __builder.AddAttribute(41, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 34 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\Pages\Index.razor"
                   model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(43, "\r\n      ");
                __Blazor.PaswordGenerate.Web.Pages.Index.TypeInference.CreateInputDate_0(__builder2, 44, 45, "form-text", 46, 
#nullable restore
#line 35 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\Pages\Index.razor"
                                                model

#line default
#line hidden
#nullable disable
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model = __value, model)), 48, () => model);
                __builder2.AddMarkupContent(49, "\r\n  ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n\r\n");
            __builder.OpenElement(51, "p");
            __builder.AddAttribute(52, "role", "status");
            __builder.AddContent(53, "Parola generata: ");
#nullable restore
#line 38 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\Pages\Index.razor"
__builder.AddContent(54, password);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "class", "btn btn-primary");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\Pages\Index.razor"
                                          PasswordGenerate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(59, "Genereaza parola");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\crist\Desktop\Jobs\WebApiCore\PaswordGenerate.Web\Pages\Index.razor"
      
    [Parameter] public User User { get; set; }
    string DateTimeUser = "";
    string UserId = "";
    DateTime model = DateTime.MinValue;

    private string  password = string.Empty;
    private PaswordResponse paswordResponse = new PaswordResponse();

    private async Task PasswordGenerate()
    {
        User = new User();
        User.DateTimeUser = model;
        //User.UserId = UserId.Cast(Int32); 
        //await base.OnInitializedAsync();        
        paswordResponse = await _paswordServices.GetPaswordResponses(UserId);
        password = paswordResponse.Pasword; 
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPaswordServices _paswordServices { get; set; }
    }
}
namespace __Blazor.PaswordGenerate.Web.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
