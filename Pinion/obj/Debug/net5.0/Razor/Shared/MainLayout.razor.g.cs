#pragma checksum "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "787dc8a51bab90044594dfd78890274698edca51"
// <auto-generated/>
#pragma warning disable 1591
namespace Pinion.Shared
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
#line 12 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "home-grid");
            __builder.AddAttribute(2, "b-ad269jif9l");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", "nav-bar");
            __builder.AddAttribute(5, "class", "layout");
            __builder.AddAttribute(6, "b-ad269jif9l");
            __builder.OpenComponent<Pinion.Shared.NavMenu>(7);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "id", "content");
            __builder.AddAttribute(11, "class", "layout");
            __builder.AddAttribute(12, "b-ad269jif9l");
#nullable restore
#line 8 "/Users/School/Documents/Non-School-Repos/Pinion/Pinion/Shared/MainLayout.razor"
__builder.AddContent(13, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n    <div id=\"right-bar\" class=\"layout\" b-ad269jif9l></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
