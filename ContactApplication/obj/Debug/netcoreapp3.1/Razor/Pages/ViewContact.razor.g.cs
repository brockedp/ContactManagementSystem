#pragma checksum "C:\Users\denob\source\repos\ContactApplication\ContactApplication\Pages\ViewContact.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "071f6f282aa5eebd6b630432a57b8131afad975a"
// <auto-generated/>
#pragma warning disable 1591
namespace ContactApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\_Imports.razor"
using ContactApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\_Imports.razor"
using ContactApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\Pages\ViewContact.razor"
using ContactApplication.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewContact/{CurrentID}")]
    public partial class ViewContact : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Contact Info</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<label>Id:</label>\r\n            ");
            __builder.OpenElement(11, "label");
            __builder.AddContent(12, 
#nullable restore
#line 12 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\Pages\ViewContact.razor"
                    contact.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.AddMarkupContent(18, "<label>First Name:</label>\r\n            ");
            __builder.OpenElement(19, "label");
            __builder.AddContent(20, " ");
            __builder.AddContent(21, 
#nullable restore
#line 16 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\Pages\ViewContact.razor"
                     contact.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.AddMarkupContent(27, "<label>Last Name:</label>\r\n            ");
            __builder.OpenElement(28, "label");
            __builder.AddContent(29, " ");
            __builder.AddContent(30, 
#nullable restore
#line 20 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\Pages\ViewContact.razor"
                     contact.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.AddMarkupContent(36, "<label>Phone Number:</label>\r\n            ");
            __builder.OpenElement(37, "label");
            __builder.AddContent(38, 
#nullable restore
#line 24 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\Pages\ViewContact.razor"
                    contact.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-group");
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.AddMarkupContent(44, "<label>Birth Date:</label>\r\n            ");
            __builder.OpenElement(45, "label");
            __builder.AddContent(46, 
#nullable restore
#line 28 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\Pages\ViewContact.razor"
                    contact.BirthDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "row");
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "col-md-4");
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "type", "button");
            __builder.AddAttribute(57, "class", "btn btn-primary");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\Pages\ViewContact.razor"
                                                                        Done

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "value", "Done");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\Pages\ViewContact.razor"
       
    [Parameter]
    public string CurrentID { get; set; }
    Contact contact = new Contact();

    protected override async Task OnInitializedAsync()
    {
        contact = await Task.Run(() => objContactService.GetContactById(Convert.ToInt32(CurrentID)));

    }

    protected void Done()
    {
        NavigationManager.NavigateTo("Contacts");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Contacts");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContactService objContactService { get; set; }
    }
}
#pragma warning restore 1591
