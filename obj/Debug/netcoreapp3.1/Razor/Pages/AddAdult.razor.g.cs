#pragma checksum "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7f27feb4b3c4a64e9158404039d01ac6646fa16"
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
            __builder.AddMarkupContent(0, "<h3>This page is for adding adults</h3>\r\n\r\n\r\n\r\n\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor"
                      newAdultItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor"
                                                    AddNewAdult

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<div>Add adult verification information:</div>  \r\n        ");
                __builder2.AddMarkupContent(11, "<div> &nbsp;</div>\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "p");
                __builder2.AddAttribute(16, "class", "space-left");
                __builder2.AddMarkupContent(17, "FirstName:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(18);
                __builder2.AddAttribute(19, "rows", "1");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor"
                                                                                       newAdultItem.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.FirstName = __value, newAdultItem.FirstName))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.FirstName));
                __builder2.CloseComponent();
                __builder2.AddContent(23, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenElement(25, "p");
                __builder2.AddAttribute(26, "class", "space");
                __builder2.AddMarkupContent(27, "LastName:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(28);
                __builder2.AddAttribute(29, "rows", "1");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor"
                                                                                 newAdultItem.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.LastName = __value, newAdultItem.LastName))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.LastName));
                __builder2.CloseComponent();
                __builder2.AddContent(33, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.AddMarkupContent(36, "<div> &nbsp;</div>\r\n        ");
                __builder2.AddMarkupContent(37, "<div>Add adult specification information:</div>\r\n        ");
                __builder2.AddMarkupContent(38, "<div> &nbsp;</div>\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "row");
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.OpenElement(42, "p");
                __builder2.AddAttribute(43, "class", "space-left");
                __builder2.AddMarkupContent(44, "HairColor:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(45);
                __builder2.AddAttribute(46, "rows", "1");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor"
                                                                                       newAdultItem.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.HairColor = __value, newAdultItem.HairColor))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.HairColor));
                __builder2.CloseComponent();
                __builder2.AddContent(50, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.OpenElement(52, "p");
                __builder2.AddAttribute(53, "class", "space");
                __builder2.AddMarkupContent(54, "EyeColor:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(55);
                __builder2.AddAttribute(56, "rows", "1");
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor"
                                                                                 newAdultItem.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.EyeColor = __value, newAdultItem.EyeColor))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.EyeColor));
                __builder2.CloseComponent();
                __builder2.AddContent(60, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.OpenElement(62, "p");
                __builder2.AddAttribute(63, "class", "space");
                __builder2.AddMarkupContent(64, "Age:<br> ");
                __Blazor.Managing_Adults.Pages.AddAdult.TypeInference.CreateInputNumber_0(__builder2, 65, 66, 
#nullable restore
#line 31 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor"
                                                                 newAdultItem.Age

#line default
#line hidden
#nullable disable
                , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Age = __value, newAdultItem.Age)), 68, () => newAdultItem.Age);
                __builder2.AddContent(69, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n            ");
                __builder2.OpenElement(71, "p");
                __builder2.AddAttribute(72, "class", "space");
                __builder2.AddMarkupContent(73, "Weight:<br> ");
                __Blazor.Managing_Adults.Pages.AddAdult.TypeInference.CreateInputNumber_1(__builder2, 74, 75, "1", 76, 
#nullable restore
#line 32 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor"
                                                                             newAdultItem.Weight

#line default
#line hidden
#nullable disable
                , 77, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Weight = __value, newAdultItem.Weight)), 78, () => newAdultItem.Weight);
                __builder2.AddContent(79, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.OpenElement(81, "p");
                __builder2.AddAttribute(82, "class", "space");
                __builder2.AddMarkupContent(83, "Height:<br> ");
                __Blazor.Managing_Adults.Pages.AddAdult.TypeInference.CreateInputNumber_2(__builder2, 84, 85, 
#nullable restore
#line 33 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor"
                                                                    newAdultItem.Height

#line default
#line hidden
#nullable disable
                , 86, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Height = __value, newAdultItem.Height)), 87, () => newAdultItem.Height);
                __builder2.AddContent(88, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n            ");
                __builder2.OpenElement(90, "p");
                __builder2.AddAttribute(91, "class", "space");
                __builder2.AddMarkupContent(92, "Select Gender<br> ");
                __Blazor.Managing_Adults.Pages.AddAdult.TypeInference.CreateInputSelect_3(__builder2, 93, 94, 
#nullable restore
#line 34 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor"
                                                                          newAdultItem.Sex

#line default
#line hidden
#nullable disable
                , 95, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Sex = __value, newAdultItem.Sex)), 96, () => newAdultItem.Sex, 97, (__builder3) => {
                    __builder3.AddMarkupContent(98, "\r\n                    ");
                    __builder3.AddMarkupContent(99, "<option selected=\"true\" disabled=\"disabled\">Select sex ...</option>\r\n                    ");
                    __builder3.AddMarkupContent(100, "<option value=\"M\">Male</option>\r\n                    ");
                    __builder3.AddMarkupContent(101, "<option value=\"F\">Female</option>\r\n                ");
                }
                );
                __builder2.AddMarkupContent(102, "\r\n           \r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n    \r\n        ");
                __builder2.AddMarkupContent(105, "<div> &nbsp;</div>\r\n        ");
                __builder2.AddMarkupContent(106, "<div>Add adult job information:</div>\r\n        ");
                __builder2.AddMarkupContent(107, "<div> &nbsp;</div>\r\n        ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "form-group");
                __builder2.AddMarkupContent(110, " Job Title:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(111);
                __builder2.AddAttribute(112, "rows", "1");
                __builder2.AddAttribute(113, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\tbile\RiderProjects\HandIn\Managing Adults\Pages\AddAdult.razor"
                                                                                      newAdultItem.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.JobTitle = __value, newAdultItem.JobTitle))));
                __builder2.AddAttribute(115, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.JobTitle));
                __builder2.CloseComponent();
                __builder2.AddContent(116, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n    \r\n        ");
                __builder2.AddMarkupContent(118, "<p class=\"actions\">\r\n            <button class=\"btn btn-outline-dark\" type=\"submit\">Create</button>\r\n        </p>\r\n    ");
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.Managing_Adults.Pages.AddAdult
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
