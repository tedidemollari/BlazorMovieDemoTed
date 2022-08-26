#pragma checksum "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "184f5beec3c2b2f0f57f7d289b0beb370e194d15"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.Movies
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/{MovieId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/movie/{MovieId:int}/{MovieName}")]
    public partial class DetailsMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
 if (model == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "Loading...");
#nullable restore
#line 7 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                           
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h2");
#nullable restore
#line 11 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
__builder.AddContent(2, model.Movie.Title);

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, " (");
#nullable restore
#line 11 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
__builder.AddContent(4, model.Movie.ReleaseDate.Value.ToString("yyyy"));

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, ")");
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
    for (int i = 0; i < model.Genres.Count; i++)
    {
        if (i < model.Genres.Count - 1)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
__builder.AddContent(6, linkGenre(model.Genres[i]));

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, ", ");
#nullable restore
#line 16 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                      
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
__builder.AddContent(8, linkGenre(model.Genres[i]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                       
        }
    }
    

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, " |  ");
            __builder.OpenElement(10, "span");
#nullable restore
#line 23 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
__builder.AddContent(11, model.Movie.ReleaseDate.Value.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "style", "display: flex");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "style", "display: inline-block; margin-right: 5px;");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "src", 
#nullable restore
#line 26 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                           model.Movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "style", "width: 225px; height: 315px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "iframe");
            __builder.AddAttribute(21, "width", "560");
            __builder.AddAttribute(22, "height", "315");
            __builder.AddAttribute(23, "src", "https://www.youtube.com/embed/" + (
#nullable restore
#line 27 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                             model.Movie.Trailer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "frameborder", "0");
            __builder.AddAttribute(25, "allow", "accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture");
            __builder.AddAttribute(26, "allowfullscreen");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "style", "margin-top: 10px;");
            __builder.AddMarkupContent(30, "<h3>Summary</h3>\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.OpenComponent<BlazorMovies.Client.Shared.RenderMarkdown>(32);
            __builder.AddAttribute(33, "MarkdownContent", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                              model.Movie.Summary

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "style", "margin-top: 10px;");
            __builder.AddMarkupContent(37, "<h3>Actors</h3>\r\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "style", "display: flex; flex-direction: column");
#nullable restore
#line 38 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
             foreach (var actor in model.Actors)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "style", "margin-bottom: 2px;");
            __builder.OpenElement(42, "img");
            __builder.AddAttribute(43, "style", "width: 50px;");
            __builder.AddAttribute(44, "src", 
#nullable restore
#line 41 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                actor.Picture

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "span");
            __builder.AddAttribute(47, "style", "display:inline-block;width: 200px;");
            __builder.OpenElement(48, "a");
            __builder.AddAttribute(49, "href", "/person/" + (
#nullable restore
#line 42 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                                   actor.Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 42 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                                             actor.Name.Replace(" ", "-")

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 42 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
__builder.AddContent(50, actor.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.AddMarkupContent(52, "<span style=\"display:inline-block; width: 45px;\">...</span>\r\n                ");
            __builder.OpenElement(53, "span");
#nullable restore
#line 44 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
__builder.AddContent(54, actor.Character);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.AddMarkupContent(56, "<h3>Locations</h3>\r\n        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "style", "display: flex; flex-direction: column");
#nullable restore
#line 50 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
             foreach (var location in model.Locations)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "style", "margin-bottom: 2px;");
            __builder.OpenElement(61, "img");
            __builder.AddAttribute(62, "style", "width: 50px;");
            __builder.AddAttribute(63, "src", 
#nullable restore
#line 53 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                    location.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "span");
            __builder.AddAttribute(66, "style", "display:inline-block;width: 200px;");
            __builder.OpenElement(67, "a");
            __builder.AddAttribute(68, "href", "/person/" + (
#nullable restore
#line 54 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                                       location.Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 54 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                                                    location.Name.Replace(" ", "-")

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 54 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
__builder.AddContent(69, location.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.AddMarkupContent(71, "<span style=\"display:inline-block; width: 45px;\">...</span>");
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
       
    [Parameter] public int MovieId { get; set; }
    [Parameter] public string MovieName { get; set; }
    private RenderFragment<Genre> linkGenre = (genre) =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(72, "a");
            __builder2.AddAttribute(73, "href", "movies/search?genreId=" + (
#nullable restore
#line 65 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                                         genre.Id

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 65 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
__builder2.AddContent(74, genre.Name);

#line default
#line hidden
#nullable disable
            __builder2.CloseElement();
        }
#nullable restore
#line 65 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\DetailsMovie.razor"
                                                                                                                  ;
    DetailsMovieDTO model;


    protected async override Task OnInitializedAsync()
    {
    model = await moviesRepository.GetDetailsMovieDTO(MovieId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMoviesRepository moviesRepository { get; set; }
    }
}
#pragma warning restore 1591
