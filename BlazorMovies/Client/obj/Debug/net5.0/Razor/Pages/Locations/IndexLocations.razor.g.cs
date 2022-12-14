#pragma checksum "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Locations\IndexLocations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "327e3cf4c1f2ab0e2c2878e86b0a81d75a824b4a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.Locations
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Repository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/locations")]
    public partial class IndexLocations : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"form-group\"><a class=\"btn btn-info\" href=\"locations/create\">New Location</a></div>\r\n\r\n");
            __Blazor.BlazorMovies.Client.Pages.Locations.IndexLocations.TypeInference.CreateGenericList_0(__builder, 1, 2, 
#nullable restore
#line 10 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Locations\IndexLocations.razor"
                   Locations

#line default
#line hidden
#nullable disable
            , 3, (__builder2) => {
                __builder2.OpenElement(4, "table");
                __builder2.AddAttribute(5, "class", "table table-striped");
                __builder2.AddMarkupContent(6, "<thead><tr><th></th>\r\n                    <th>Name</th></tr></thead>\r\n            ");
                __builder2.OpenElement(7, "tbody");
#nullable restore
#line 20 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Locations\IndexLocations.razor"
                 foreach (var item in Locations)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(8, "tr");
                __builder2.OpenElement(9, "td");
                __builder2.OpenElement(10, "a");
                __builder2.AddAttribute(11, "class", "btn btn-success");
                __builder2.AddAttribute(12, "href", "/locations/edit/" + (
#nullable restore
#line 24 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Locations\IndexLocations.razor"
                                                                              item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(13, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                            ");
                __builder2.OpenElement(15, "button");
                __builder2.AddAttribute(16, "class", "btn btn-danger");
                __builder2.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Locations\IndexLocations.razor"
                                                                       () => DeleteLocations(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(18, "Delete");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                        ");
                __builder2.OpenElement(20, "td");
#nullable restore
#line 27 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Locations\IndexLocations.razor"
__builder2.AddContent(21, item.Name);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 29 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Locations\IndexLocations.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Locations\IndexLocations.razor"
       

    List<Location> Locations;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Locations = await locationRepository.GetLocations();
        }
        catch (Exception ex)
        {

        }
    }

    private async Task DeleteLocations(int Id)
    {
        await locationRepository.DeleteLocation(Id);
        Locations = await locationRepository.GetLocations();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocationRepository locationRepository { get; set; }
    }
}
namespace __Blazor.BlazorMovies.Client.Pages.Locations.IndexLocations
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::BlazorMovies.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "WholeListTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
