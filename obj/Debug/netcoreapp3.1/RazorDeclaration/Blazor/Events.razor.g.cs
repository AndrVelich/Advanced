#pragma checksum "C:\Users\Euheni\Advanced\Blazor\Events.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fcdf7b6fca472f0d539b6026189d1369b1c9ff6"
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
    public partial class Events : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\Euheni\Advanced\Blazor\Events.razor"
       
    public int ElementCount { get; set; } = 4;
    public Dictionary<int, int> Counters { get; } = new Dictionary<int, int>();
    public int GetCounter(int index) =>
    Counters.ContainsKey(index) ? Counters[index] : 0;
    public void IncrementCounter(int index) =>
    Counters[index] = GetCounter(index) + 1;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
