#pragma checksum "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Pages/Home/HomeContent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0617dafd241c21cbdd52239049c2ae92441aaa6"
// <auto-generated/>
#pragma warning disable 1591
namespace Pinion.Pages.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Pinion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Pinion.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using Pinion.Pages.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Pages/Home/HomeContent.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class HomeContent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Pinion.Shared.PageHeader>(0);
            __builder.AddAttribute(1, "Title", "Home");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Pages/Home/HomeContent.razor"
                  pinionModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Pages/Home/HomeContent.razor"
                                               HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "class", "pinion-form");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n\n    ");
                __Blazor.Pinion.Pages.Home.HomeContent.TypeInference.CreateMatTextField_0(__builder2, 12, 13, "Up to 255 characters", 14, 
#nullable restore
#line 10 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Pages/Home/HomeContent.razor"
                                                                                               true

#line default
#line hidden
#nullable disable
                , 15, 
#nullable restore
#line 10 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Pages/Home/HomeContent.razor"
                                                                                                                true

#line default
#line hidden
#nullable disable
                , 16, 
#nullable restore
#line 10 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Pages/Home/HomeContent.razor"
                                pinionModel.PinionText

#line default
#line hidden
#nullable disable
                , 17, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pinionModel.PinionText = __value, pinionModel.PinionText)), 18, () => pinionModel.PinionText);
                __builder2.AddMarkupContent(19, "\n\n    ");
                __builder2.OpenComponent<MatBlazor.MatButton>(20);
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(22, "Submit");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\n\n");
            __builder.AddMarkupContent(24, "<h2 b-98j0xme6y6>Greg</h2>");
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Pinion.Pages.Home.HomeContent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "TextArea", __arg1);
        __builder.AddAttribute(__seq2, "FullWidth", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
