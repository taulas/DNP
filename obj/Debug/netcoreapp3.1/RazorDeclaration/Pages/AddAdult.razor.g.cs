#pragma checksum "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7f27feb4b3c4a64e9158404039d01ac6646fa16"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Managing_Adults.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\_Imports.razor"
using Managing_Adults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\_Imports.razor"
using Managing_Adults.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor"
using Managing_Adults.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor"
using Managing_Adults.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor"
using global::Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor"
       
    private Adult newAdultItem = new Adult();

    private void AddNewAdult()
    {
        AdultService.AddAdult(newAdultItem);
        NavigationManager.NavigateTo("/Adults");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
#pragma warning restore 1591
