#pragma checksum "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a2569300b05c6b3f7938d51851a8ba544f75674"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\Pages\Login.razor"
using Assignment1.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\Pages\Login.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "container-fluid px-1 px-md-5 px-lg-1 px-xl-5 py-5 mx-auto");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "card card0 border-0");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row d-flex");
                __builder2.AddMarkupContent(8, "<div class=\"col-lg-6\"><div class=\"card1 pb-5\"><div class=\"row px-3 justify-content-center mt-4 mb-5 border-line\"><img src=\"https://i.imgur.com/xzBl9OX.png\" width=\"600px\" alt=\"hey bits\"></div></div></div>\r\n                    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-lg-6 align-self-center");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card2 card border-0 px-4 py-5 d-flex");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "row px-3");
                __builder2.AddMarkupContent(15, "<label class=\"mb-1\"><h6 class=\"mb-0 text-sm\">Username</h6></label> ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "class", "mb-4");
                __builder2.AddAttribute(18, "type", "text");
                __builder2.AddAttribute(19, "name", "email");
                __builder2.AddAttribute(20, "placeholder", "Enter a valid username");
                __builder2.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\Pages\Login.razor"
                                                                                                                                        username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                            ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "row px-3");
                __builder2.AddMarkupContent(26, "<label class=\"mb-1\"><h6 class=\"mb-0 text-sm\">Password</h6></label> ");
                __builder2.OpenElement(27, "input");
                __builder2.AddAttribute(28, "type", "password");
                __builder2.AddAttribute(29, "name", "password");
                __builder2.AddAttribute(30, "placeholder", "Enter password");
                __builder2.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\Pages\Login.razor"
                                                                                                                          password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                            ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "style", "color:red");
                __builder2.AddContent(36, 
#nullable restore
#line 31 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\Pages\Login.razor"
                                                    errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                            ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "row mb-3 px-3");
                __builder2.OpenElement(40, "button");
                __builder2.AddAttribute(41, "type", "submit");
                __builder2.AddAttribute(42, "class", "btn btn-blue text-center");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\Pages\Login.razor"
                                                                                                 PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(44, "Login");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.AddMarkupContent(46, "<div class=\"bg-blue py-4\"><div class=\"row px-3\"><small class=\"ml-4 ml-sm-5 mb-2\"></small></div></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\Dokumenter D\Git\DNP1_Assignments\Assignments\Assignment1\Pages\Login.razor"
       
    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin()
    {
        errorMessage = "";
        try
        {
            await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            username = "";
            password = "";
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
