#pragma checksum "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2afdc9a2c0d10c637ca28d1de229fe541d3e609e"
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
    public partial class NavLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-3");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 5 "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor"
             foreach (string key in NavLinks.Keys)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "            ");
            __builder.OpenComponent<Advanced.Blazor.MultiNavLink>(10);
            __builder.AddAttribute(11, "class", "btn btn-outline-primary btn-block");
            __builder.AddAttribute(12, "href", 
#nullable restore
#line 8 "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor"
                                 NavLinks[key]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.AddContent(16, 
#nullable restore
#line 9 "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor"
                 key

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(17, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 11 "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.AddContent(24, 
#nullable restore
#line 14 "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor"
       
    public Dictionary<string, string[]> NavLinks
    = new Dictionary<string, string[]> {
        {"People", new string[] {"/people", "/" } },
        {"Departments", new string[] {"/depts", "/departments" } },
        {"Details", new string[] { "/person" } }    
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591