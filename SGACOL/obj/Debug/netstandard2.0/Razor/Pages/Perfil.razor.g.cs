#pragma checksum "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\Proyecto_SGA_UCaldas\SGACOL\Pages\Perfil.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9367925e127bab2a658e4881b185552408ede868"
// <auto-generated/>
#pragma warning disable 1591
namespace SGACOL.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\Proyecto_SGA_UCaldas\SGACOL\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\Proyecto_SGA_UCaldas\SGACOL\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\Proyecto_SGA_UCaldas\SGACOL\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\Proyecto_SGA_UCaldas\SGACOL\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\Proyecto_SGA_UCaldas\SGACOL\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\Proyecto_SGA_UCaldas\SGACOL\_Imports.razor"
using SGACOL;

#line default
#line hidden
#line 7 "G:\Mi unidad\misiontic\Desarrollo de Software\PROYECTO\Proyecto_SGA_UCaldas\SGACOL\_Imports.razor"
using SGACOL.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/perfil")]
    public partial class Perfil : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<form>
<table style=""width:100%"">
  <tr>
    <td><label for=""Nombres"">Nombres:</label></td>
    <td><label for=""Apellidos"">Apellidos:</label></td>
    <td><label for=""Id"">No. Identificacion:</label></td>
  </tr>
  <tr>
    <td><input type=""text"" id=""Nombres"" name=""Nombres"" value></td>
    <td><input type=""text"" id=""Apellidos"" name=""Apellidos"" value></td>
    <td><input type=""text"" id=""Id"" name=""Identificacion"" value></td>
  </tr>
  <tr></tr>
  <tr>
     <td><label for=""Telefono"">Telefono:</label></td>
    <td><label for=""Correo"">Correo electronico:</label></td>
     <td><label for=""Direccion"">Direccion Residencial:</label></td>
  </tr>
  <tr>
    <td><input type=""text"" id=""Telefono"" name=""Telefono"" value></td>
    <td><input type=""email"" id=""Correo"" name=""Correo"" value></td>
    <td><input type=""text"" id=""Direccion"" name=""Direccion"" value> </td>
  </tr> 
   
</table>
</form>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
