#pragma checksum "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b842e6ac7fa09cfb878ed544e78a07dd59ac0b86"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor"
using Advanced.Services;

#line default
#line hidden
#nullable disable
    public partial class NavLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor"
 
    [Inject]
    public IJSRuntime JSRuntime { get; set; }
    [Inject]
    public ToggleService Toggler { get; set; }

    public Dictionary<string, string[]> NavLinks
        = new Dictionary<string, string[]> {
            {"People", new string[] {"/people", "/" } },
            {"Departments", new string[] {"/depts", "/departments" } },
            {"Details", new string[] { "/person" } }
          };
    public Dictionary<string, MultiNavLink> Refs
        = new Dictionary<string, MultiNavLink>();
    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            Toggler.EnrolComponents(Refs.Values);
            await JSRuntime.InvokeVoidAsync("createToggleButton",
                DotNetObjectReference.Create(Toggler));
        }
    }
    public void ToggleLinks()
    {
        Toggler.ToggleComponents();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
