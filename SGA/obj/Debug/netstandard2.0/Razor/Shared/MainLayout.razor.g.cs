#pragma checksum "C:\Users\jhon.bejarano\Desktop\GCO\JB\CURSO_UCALDAS\Programacion_3\Entrega_SGA_Ciclo_3\Proyecto_SGA_UCaldas\sga\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd6d20d95fdaaf0db83a6a3154434357438fcf15"
// <auto-generated/>
#pragma warning disable 1591
namespace SGA.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\jhon.bejarano\Desktop\GCO\JB\CURSO_UCALDAS\Programacion_3\Entrega_SGA_Ciclo_3\Proyecto_SGA_UCaldas\sga\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\jhon.bejarano\Desktop\GCO\JB\CURSO_UCALDAS\Programacion_3\Entrega_SGA_Ciclo_3\Proyecto_SGA_UCaldas\sga\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\jhon.bejarano\Desktop\GCO\JB\CURSO_UCALDAS\Programacion_3\Entrega_SGA_Ciclo_3\Proyecto_SGA_UCaldas\sga\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\jhon.bejarano\Desktop\GCO\JB\CURSO_UCALDAS\Programacion_3\Entrega_SGA_Ciclo_3\Proyecto_SGA_UCaldas\sga\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\jhon.bejarano\Desktop\GCO\JB\CURSO_UCALDAS\Programacion_3\Entrega_SGA_Ciclo_3\Proyecto_SGA_UCaldas\sga\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\jhon.bejarano\Desktop\GCO\JB\CURSO_UCALDAS\Programacion_3\Entrega_SGA_Ciclo_3\Proyecto_SGA_UCaldas\sga\_Imports.razor"
using SGA;

#line default
#line hidden
#line 7 "C:\Users\jhon.bejarano\Desktop\GCO\JB\CURSO_UCALDAS\Programacion_3\Entrega_SGA_Ciclo_3\Proyecto_SGA_UCaldas\sga\_Imports.razor"
using SGA.Shared;

#line default
#line hidden
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<SGA.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\r\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddContent(13, 
#line 13 "C:\Users\jhon.bejarano\Desktop\GCO\JB\CURSO_UCALDAS\Programacion_3\Entrega_SGA_Ciclo_3\Proyecto_SGA_UCaldas\sga\Shared\MainLayout.razor"
         Body

#line default
#line hidden
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
