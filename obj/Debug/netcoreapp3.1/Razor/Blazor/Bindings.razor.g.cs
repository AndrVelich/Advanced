#pragma checksum "C:\Users\Euheni\Advanced\Blazor\Bindings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9103ac4a4961fa7b829c9506e0bd294a233290c6"
// <auto-generated/>
#pragma warning disable 1591
namespace Advanced.Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Euheni\Advanced\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Euheni\Advanced\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Euheni\Advanced\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Euheni\Advanced\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Euheni\Advanced\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Euheni\Advanced\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Euheni\Advanced\_Imports.razor"
using Advanced.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Euheni\Advanced\Blazor\Bindings.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class Bindings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<label>City:</label>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\Users\Euheni\Advanced\Blazor\Bindings.razor"
                                             City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => City = __value, City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "p-2 mb-2");
            __builder.AddContent(12, "City Value: ");
            __builder.AddContent(13, 
#nullable restore
#line 7 "C:\Users\Euheni\Advanced\Blazor\Bindings.razor"
                                   City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Euheni\Advanced\Blazor\Bindings.razor"
                                            () => City = "Paris"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Paris");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Euheni\Advanced\Blazor\Bindings.razor"
                                            () => City = "Chicago"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Chicago");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group mt-2");
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.AddMarkupContent(28, "<label>Time:</label>\r\n    ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "class", "form-control my-1");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Euheni\Advanced\Blazor\Bindings.razor"
                                            Time

#line default
#line hidden
#nullable disable
            , format: "MMM-dd", culture: 
#nullable restore
#line 12 "C:\Users\Euheni\Advanced\Blazor\Bindings.razor"
                                                                 Culture

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Time = __value, Time, format: "MMM-dd", culture: Culture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "class", "form-control my-1");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Euheni\Advanced\Blazor\Bindings.razor"
                                            Time

#line default
#line hidden
#nullable disable
            , culture: 
#nullable restore
#line 14 "C:\Users\Euheni\Advanced\Blazor\Bindings.razor"
                                                                 Culture

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Time = __value, Time, culture: Culture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "class", "form-control");
            __builder.AddAttribute(41, "type", "date");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Euheni\Advanced\Blazor\Bindings.razor"
                                                   Time

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Time = __value, Time, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "p-2 mb-2");
            __builder.AddContent(48, "Time Value: ");
            __builder.AddContent(49, 
#nullable restore
#line 17 "C:\Users\Euheni\Advanced\Blazor\Bindings.razor"
                                   Time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "form-group");
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.AddMarkupContent(54, "<label>Culture:</label>\r\n    ");
            __builder.OpenElement(55, "select");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Euheni\Advanced\Blazor\Bindings.razor"
                                        Culture

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Culture = __value, Culture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenElement(60, "option");
            __builder.AddAttribute(61, "value", 
#nullable restore
#line 21 "C:\Users\Euheni\Advanced\Blazor\Bindings.razor"
                        CultureInfo.GetCultureInfo("en-us")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(62, "en-US");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "option");
            __builder.AddAttribute(65, "value", 
#nullable restore
#line 22 "C:\Users\Euheni\Advanced\Blazor\Bindings.razor"
                        CultureInfo.GetCultureInfo("en-gb")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(66, "en-GB");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.OpenElement(68, "option");
            __builder.AddAttribute(69, "value", 
#nullable restore
#line 23 "C:\Users\Euheni\Advanced\Blazor\Bindings.razor"
                        CultureInfo.GetCultureInfo("fr-fr")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(70, "fr-FR");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\Euheni\Advanced\Blazor\Bindings.razor"
       
    public string City { get; set; } = "London";
    public DateTime Time { get; set; } = DateTime.Parse("2050/01/20 09:50");
    public CultureInfo Culture { get; set; } = CultureInfo.GetCultureInfo("en-us");

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
