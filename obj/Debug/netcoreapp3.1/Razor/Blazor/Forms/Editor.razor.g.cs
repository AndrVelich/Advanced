#pragma checksum "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e9ff76bfdc0b9d7ce5a062dd17f9462cb899bd1"
// <auto-generated/>
#pragma warning disable 1591
namespace Advanced.Blazor.Forms
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/forms/edit/{id:long}")]
    public partial class Editor : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/blazorValidation.css\" rel=\"stylesheet\">\r\n");
            __builder.AddMarkupContent(1, "<h4 class=\"bg-primary text-center text-white p-2\">Edit</h4>\r\n");
            __builder.OpenElement(2, "h6");
            __builder.AddAttribute(3, "class", "bg-info text-center text-white p-2");
            __builder.AddContent(4, 
#nullable restore
#line 7 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                                                FormSubmitMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<Advanced.Blazor.Forms.FormSpy>(6);
            __builder.AddAttribute(7, "PersonData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Advanced.Models.Person>(
#nullable restore
#line 8 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                     PersonData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
                __builder2.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                     PersonData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                                                HandleValidSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(13, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                               HandleInvalidSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\r\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\r\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(18);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n        ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "form-group");
                    __builder3.AddMarkupContent(22, "\r\n            ");
                    __builder3.AddMarkupContent(23, "<label>Firstname</label>\r\n            ");
                    __Blazor.Advanced.Blazor.Forms.Editor.TypeInference.CreateValidationMessage_0(__builder3, 24, 25, 
#nullable restore
#line 15 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                                      () => PersonData.Firstname

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(26, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                    __builder3.AddAttribute(28, "class", "form-control");
                    __builder3.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                                                         PersonData.Firstname

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PersonData.Firstname = __value, PersonData.Firstname))));
                    __builder3.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => PersonData.Firstname));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(33, "\r\n        ");
                    __builder3.OpenElement(34, "div");
                    __builder3.AddAttribute(35, "class", "form-group");
                    __builder3.AddMarkupContent(36, "\r\n            ");
                    __builder3.AddMarkupContent(37, "<label>Surname</label>\r\n            ");
                    __Blazor.Advanced.Blazor.Forms.Editor.TypeInference.CreateValidationMessage_1(__builder3, 38, 39, 
#nullable restore
#line 20 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                                      () => PersonData.Surname

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(40, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(41);
                    __builder3.AddAttribute(42, "class", "form-control");
                    __builder3.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                                                         PersonData.Surname

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PersonData.Surname = __value, PersonData.Surname))));
                    __builder3.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => PersonData.Surname));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(47, "\r\n        ");
                    __builder3.OpenElement(48, "div");
                    __builder3.AddAttribute(49, "class", "form-group");
                    __builder3.AddMarkupContent(50, "\r\n            ");
                    __builder3.AddMarkupContent(51, "<label>Dept ID</label>\r\n            ");
                    __Blazor.Advanced.Blazor.Forms.Editor.TypeInference.CreateValidationMessage_2(__builder3, 52, 53, 
#nullable restore
#line 25 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                                      () => PersonData.DepartmentId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(54, "\r\n            ");
                    __builder3.OpenComponent<Advanced.Blazor.Forms.CustomSelect<long>>(55);
                    __builder3.AddAttribute(56, "Values", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IDictionary<System.String, long>>(
#nullable restore
#line 26 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                                                Departments

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "Parser", new System.Func<System.String, long>(
#nullable restore
#line 27 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                                    str => long.Parse(str)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<long>(
#nullable restore
#line 28 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                                       PersonData.DepartmentId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(59, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<long>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<long>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PersonData.DepartmentId = __value, PersonData.DepartmentId))));
                    __builder3.AddAttribute(60, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<long>>>(() => PersonData.DepartmentId));
                    __builder3.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(62, "\r\n                ");
                        __builder4.AddMarkupContent(63, "<option selected disabled value=\"0\">Choose a Department</option>\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\r\n        ");
                    __builder3.OpenElement(66, "div");
                    __builder3.AddAttribute(67, "class", "form-group");
                    __builder3.AddMarkupContent(68, "\r\n            ");
                    __builder3.AddMarkupContent(69, "<label>Location ID</label>\r\n            ");
                    __Blazor.Advanced.Blazor.Forms.Editor.TypeInference.CreateValidationMessage_3(__builder3, 70, 71, 
#nullable restore
#line 34 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                                      () => PersonData.LocationId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(72, "\r\n            ");
                    __builder3.OpenComponent<Advanced.Blazor.Forms.CustomSelect<long>>(73);
                    __builder3.AddAttribute(74, "Values", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IDictionary<System.String, long>>(
#nullable restore
#line 35 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                                                Locations

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(75, "Parser", new System.Func<System.String, long>(
#nullable restore
#line 36 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                                    str => long.Parse(str)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<long>(
#nullable restore
#line 37 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
                                       PersonData.LocationId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(77, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<long>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<long>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PersonData.LocationId = __value, PersonData.LocationId))));
                    __builder3.AddAttribute(78, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<long>>>(() => PersonData.LocationId));
                    __builder3.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(80, "\r\n                ");
                        __builder4.AddMarkupContent(81, "<option selected disabled value=\"0\">Choose a Location</option>\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(82, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\r\n        ");
                    __builder3.OpenElement(84, "div");
                    __builder3.AddAttribute(85, "class", "text-center");
                    __builder3.AddMarkupContent(86, "\r\n            ");
                    __builder3.AddMarkupContent(87, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(88);
                    __builder3.AddAttribute(89, "class", "btn btn-secondary");
                    __builder3.AddAttribute(90, "href", "/forms");
                    __builder3.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(92, "Back");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(94, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(95, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
 
    [Inject]
    public NavigationManager NavManager { get; set; }
    [Inject]
    DataContext Context { get; set; }
    [Parameter]
    public long Id { get; set; }
    public Person PersonData { get; set; } = new Person();
    public IDictionary<string, long> Departments { get; set; }
        = new Dictionary<string, long>();
    public IDictionary<string, long> Locations { get; set; }
        = new Dictionary<string, long>();
    protected async override Task OnParametersSetAsync()
    {
        PersonData = await Context.People.FindAsync(Id);
        Departments = await Context.Departments
        .ToDictionaryAsync(d => d.Name, d => d.Departmentid);
        Locations = await Context.Locations
        .ToDictionaryAsync(l => $"{l.City}, {l.State}", l => l.LocationId);
    }
    public string FormSubmitMessage { get; set; } = "Form Data Not Submitted";
    public void HandleValidSubmit() => FormSubmitMessage = "Valid Data Submitted";
    public void HandleInvalidSubmit() =>
    FormSubmitMessage = "Invalid Data Submitted";
    public void Dispose() => Context.Entry(PersonData).State = EntityState.Detached;

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Advanced.Blazor.Forms.Editor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
