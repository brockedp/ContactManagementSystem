#pragma checksum "C:\Users\denob\source\repos\ContactApplication\ContactApplication\Pages\Contacts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0d5eba3273dc8fab600f5f3564e6895b09d2730"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\Pages\Contacts.razor"
using ContactApplication.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contacts")]
    public partial class Contacts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\denob\source\repos\ContactApplication\ContactApplication\Pages\Contacts.razor"
       
    List<Contact> contacts;
    protected override async Task OnInitializedAsync()
    {
        contacts = await Task.Run(() => objContactService.GetContacts());

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContactService objContactService { get; set; }
    }
}
#pragma warning restore 1591
