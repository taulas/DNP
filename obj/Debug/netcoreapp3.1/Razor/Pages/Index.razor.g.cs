#pragma checksum "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d4a14c03926ace6f78f26b3a7369766afbd7040"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.AddMarkupContent(3, "<div>\r\n            <h1>Hello, Guest!</h1>\r\n            <h1>Please login to get extra functions</h1>\r\n        </div>\r\n        \r\n    ");
            }
            ));
            __builder.AddAttribute(4, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddMarkupContent(7, "\r\n                           ");
                __builder2.OpenElement(8, "h1");
                __builder2.AddContent(9, "Hello, ");
                __builder2.AddContent(10, 
#nullable restore
#line 14 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\Index.razor"
                                       context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(11, " !");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n                           ");
                __builder2.AddMarkupContent(13, "<h1>You got extra functionality</h1>\r\n                       ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
