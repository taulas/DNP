#pragma checksum "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c262597e6706da00aea415adf11652c8f3a5630"
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
#nullable restore
#line 4 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
using Managing_Adults.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
using Managing_Adults.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
using global::Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class AdultList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Over here is adult list</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "p");
            __builder.AddAttribute(5, "class", "space-left");
            __builder.AddMarkupContent(6, "\r\n        Search by Id: ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "number");
            __builder.AddAttribute(9, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
                                                       (arg) => FilterById(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "style", "width:50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "p");
            __builder.AddAttribute(14, "class", " row space");
            __builder.AddMarkupContent(15, "\r\n            Search by hair color:\r\n            ");
            __builder.OpenElement(16, "select");
            __builder.AddAttribute(17, "class", "form-control selectpicker");
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
                                                                   (arg) => FilterByHairColor(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "style", "width:100px");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "selected", "true");
            __builder.AddAttribute(23, "disabled", "disabled");
            __builder.AddContent(24, "Select...");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "option");
            __builder.AddContent(27, "Blond");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "option");
            __builder.AddContent(30, "Red");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "option");
            __builder.AddContent(33, "Brown");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "option");
            __builder.AddContent(36, "Black");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "option");
            __builder.AddContent(39, "White");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "option");
            __builder.AddContent(42, "Grey");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "option");
            __builder.AddContent(45, "Blue");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "option");
            __builder.AddContent(48, "Green");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "option");
            __builder.AddContent(51, "Everpostej");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n               \r\n    \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n       \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n");
#nullable restore
#line 38 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
 if (adultsToShow == null) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "    ");
            __builder.AddMarkupContent(57, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 42 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
} else if (!adultsToShow.Any()) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "    ");
            __builder.AddMarkupContent(59, "<p>\r\n        <em>No Adult items exist. Please add some.</em>\r\n    </p>\r\n");
#nullable restore
#line 46 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "    ");
            __builder.OpenElement(61, "table");
            __builder.AddAttribute(62, "class", "table");
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.AddMarkupContent(64, @"<thead>
        <tr>
            <th>ID</th>
            <th>FirstName</th>
            <th>LastName</th>
            <th>JobTitle</th>
            <th>HairColor</th>
            <th>EyeColor</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th>
            <th>Edit</th>
            <th>Delete</th>
        </tr>
        </thead>
        ");
            __builder.OpenElement(65, "tbody");
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 65 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
         foreach (var item in adultsToShow) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "            ");
            __builder.OpenElement(68, "tr");
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.OpenElement(70, "td");
            __builder.AddContent(71, 
#nullable restore
#line 67 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.OpenElement(73, "td");
            __builder.AddContent(74, 
#nullable restore
#line 68 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.OpenElement(76, "td");
            __builder.AddContent(77, 
#nullable restore
#line 69 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.OpenElement(79, "td");
            __builder.AddContent(80, 
#nullable restore
#line 70 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
                     item.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.OpenElement(82, "td");
            __builder.AddContent(83, 
#nullable restore
#line 71 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.OpenElement(85, "td");
            __builder.AddContent(86, 
#nullable restore
#line 72 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.OpenElement(88, "td");
            __builder.AddContent(89, 
#nullable restore
#line 73 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.OpenElement(91, "td");
            __builder.AddContent(92, 
#nullable restore
#line 74 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.OpenElement(94, "td");
            __builder.AddContent(95, 
#nullable restore
#line 75 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
                     item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.OpenElement(97, "td");
            __builder.AddContent(98, 
#nullable restore
#line 76 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                ");
            __builder.OpenElement(100, "td");
            __builder.AddMarkupContent(101, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(102);
            __builder.AddAttribute(103, "Policy", "MustBeAdmin");
            __builder.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(105, "\r\n                                        ");
                __builder2.OpenElement(106, "button");
                __builder2.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
                                                            () => EditAdult(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(108, "\r\n                                                                <i class=\"oi oi-task\" style=\"color:blue\"></i>\r\n                                                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(110, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.OpenElement(112, "td");
            __builder.AddMarkupContent(113, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(114);
            __builder.AddAttribute(115, "Policy", "MustBeAdmin");
            __builder.AddAttribute(116, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(117, "\r\n                        ");
                __builder2.OpenElement(118, "button");
                __builder2.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
                                            () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(120, "\r\n                            <i class=\"oi oi-trash\" style=\"color:red\"></i>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(122, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n");
#nullable restore
#line 93 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(125, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n");
#nullable restore
#line 96 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AdultList.razor"
       
    private IList<Adult> adultsToShow;
    private IList<Adult> allAdults;

    private int? filterById;
    private string? filterByHairColor;

    private void FilterById(ChangeEventArgs changeEventArgs)
    {
        filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }
    private void FilterByHairColor(ChangeEventArgs changeEventArgs) {
        
        
            filterByHairColor = null;
            try
            {
                filterByHairColor = changeEventArgs.Value.ToString();
            }
            catch (Exception e)
            {
            }
            ExecuteFilter();
        
    }
    private void ExecuteFilter()
    {
        adultsToShow = allAdults.Where(t => 
            (filterById != null && t.Id == filterById || filterById == null) &&
            (filterByHairColor != null && t.HairColor == filterByHairColor || filterByHairColor == null)

            ).ToList();
    }

    protected override async Task OnInitializedAsync()
    {
        allAdults = AdultsService.GetAdults();
        adultsToShow = allAdults;
    }

    private void RemoveAdult(int adultId)
    {
        Adult adultToRemove = adultsToShow.First(t => t.Id == adultId);
        AdultsService.RemoveAdult(adultId);
        adultsToShow.Remove(adultToRemove);
    }

    private void EditAdult(int value)
    {
        string result;
        result = value.ToString();
        NavigationManager.NavigateTo($"/EditAdult/{result}");
        
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultsService { get; set; }
    }
}
#pragma warning restore 1591