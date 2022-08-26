#pragma checksum "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3b733890c3e1c9816bfb5cb1265fbf485e24d47"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/search")]
    public partial class MovieFilter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Search Movies</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                 filterMoviesDTO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-inline");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group mb-2");
                __builder2.AddMarkupContent(8, "<label for=\"title\" class=\"sr-only\">Title</label>\r\n            ");
                __builder2.OpenElement(9, "input");
                __builder2.AddAttribute(10, "type", "text");
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "id", "title");
                __builder2.AddAttribute(13, "placeholder", "Movie Title");
                __builder2.AddAttribute(14, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                                  (KeyboardEventArgs e) => TitleKeyPress(e)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                                filterMoviesDTO.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filterMoviesDTO.Title = __value, filterMoviesDTO.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group mx-sm-3 mb-2");
                __builder2.OpenElement(20, "select");
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                                                filterMoviesDTO.GenreId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filterMoviesDTO.GenreId = __value, filterMoviesDTO.GenreId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(24, "option");
                __builder2.AddAttribute(25, "value", "0");
                __builder2.AddMarkupContent(26, "\r\n                    --Select a Genre--\r\n                ");
                __builder2.CloseElement();
#nullable restore
#line 21 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                 foreach (var genre in Genres)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(27, "option");
                __builder2.AddAttribute(28, "value", 
#nullable restore
#line 23 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                                    genre.Id

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 23 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
__builder2.AddContent(29, genre.Name);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 24 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group mx-sm-3 mb-2");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "type", "checkbox");
                __builder2.AddAttribute(35, "class", "form-check-input");
                __builder2.AddAttribute(36, "id", "upcomingReleases");
                __builder2.AddAttribute(37, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                          filterMoviesDTO.UpcomingReleases

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filterMoviesDTO.UpcomingReleases = __value, filterMoviesDTO.UpcomingReleases));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.AddMarkupContent(40, "<label class=\"form-check-label\" for=\"upcomingReleases\">\r\n                Upcoming Releases\r\n            </label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group mx-sm-3 mb-2");
                __builder2.OpenElement(44, "input");
                __builder2.AddAttribute(45, "type", "checkbox");
                __builder2.AddAttribute(46, "class", "form-check-input");
                __builder2.AddAttribute(47, "id", "upcomingReleases");
                __builder2.AddAttribute(48, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                          filterMoviesDTO.InTheaters

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filterMoviesDTO.InTheaters = __value, filterMoviesDTO.InTheaters));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.AddMarkupContent(51, "<label class=\"form-check-label\" for=\"inTheaters\">\r\n                In Theaters\r\n            </label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n        ");
                __builder2.OpenElement(53, "button");
                __builder2.AddAttribute(54, "type", "button");
                __builder2.AddAttribute(55, "class", "btn btn-primary mb-2 mx-sm-3");
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                                                                             SearchForMovies

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(57, "Filter");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.OpenElement(59, "button");
                __builder2.AddAttribute(60, "type", "button");
                __builder2.AddAttribute(61, "class", "btn btn-danger mb-2");
                __builder2.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                                                                    Clear

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(63, "Clear");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n");
            __builder.OpenComponent<BlazorMovies.Client.Shared.MoviesList>(65);
            __builder.AddAttribute(66, "Movies", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Shared.Entities.Movie>>(
#nullable restore
#line 46 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                    Movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(67, "\r\n\r\n");
            __builder.OpenComponent<BlazorMovies.Client.Shared.Pagination>(68);
            __builder.AddAttribute(69, "CurrentPage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 48 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                         filterMoviesDTO.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "TotalAmountPages", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 48 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                                                                 totalAmountPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "SelectedPage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 49 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\Lenovo\RiderProjects\BlazorMovieDemo\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
       
    private List<Movie> Movies;
    private FilterMoviesDTO filterMoviesDTO = new FilterMoviesDTO();
    private int totalAmountPages;
    private List<Genre> Genres = new List<Genre>();

    protected async override Task OnInitializedAsync()
    {
        var queryStrings = navigationManager.GetQueryStrings(navigationManager.Uri);
        Genres = await genreRepository.GetGenres();
        if (queryStrings != null)
        {
            FillFilterWithQueryStrings(queryStrings);
        }
        await LoadMovies();
    }

    private void FillFilterWithQueryStrings(Dictionary<string, string> queryStrings)
    {
        if (queryStrings.ContainsKey("genreId"))
        {
            filterMoviesDTO.GenreId = int.Parse(queryStrings["genreId"]);
        }
        if (queryStrings.ContainsKey("locationId"))
        {
            filterMoviesDTO.LocationId = int.Parse(queryStrings["locationId"]);
        }

        if (queryStrings.ContainsKey("title"))
        {
            filterMoviesDTO.Title = queryStrings["title"];
        }

        if (queryStrings.ContainsKey("intheaters"))
        {
            filterMoviesDTO.UpcomingReleases = bool.Parse(queryStrings["intheaters"]);
        }

        if (queryStrings.ContainsKey("upcomingReleases"))
        {
            filterMoviesDTO.UpcomingReleases = bool.Parse(queryStrings["upcomingReleases"]);
        }

        if (queryStrings.ContainsKey("page"))
        {
            filterMoviesDTO.Page = int.Parse(queryStrings["page"]);
        }
    }

    private async Task SelectedPage(int page)
    {
        filterMoviesDTO.Page = page;
        await LoadMovies();
    }

    private async Task LoadMovies()
    {
        var queryString = GenerateQueryString();
        if (!string.IsNullOrWhiteSpace(queryString))
        {
            queryString = $"?{queryString}";
            navigationManager.NavigateTo("movies/search" + queryString);
        }

        var paginatedResponse = await moviesRepository.GetMoviesFiltered(filterMoviesDTO);
        Movies = paginatedResponse.Response;
        totalAmountPages = paginatedResponse.TotalAmountPages;
    }

    private string GenerateQueryString()
    {
        var queryStringsDict = new Dictionary<string, string>();
        queryStringsDict["genreId"] = filterMoviesDTO.GenreId.ToString();
        queryStringsDict["locationId"] = filterMoviesDTO.LocationId.ToString();
        queryStringsDict["title"] = filterMoviesDTO.Title ?? "";
        queryStringsDict["intheaters"] = filterMoviesDTO.InTheaters.ToString();
        queryStringsDict["upcomingReleases"] = filterMoviesDTO.UpcomingReleases.ToString();
        queryStringsDict["page"] = filterMoviesDTO.Page.ToString();

        var defaultValue = new List<string>() { "false", "", "0" };

        // genreId=4&title=spider....

        return string.Join("&", queryStringsDict
            .Where(x => !defaultValue.Contains(x.Value.ToLower()))
            .Select(x => $"{x.Key}={System.Web.HttpUtility.UrlEncode(x.Value)}").ToArray());

    }

    private async Task SearchForMovies()
    {
        await LoadMovies();
    }

    private async Task Clear()
    {
        filterMoviesDTO.Title = "";
        filterMoviesDTO.GenreId = 0;
        filterMoviesDTO.LocationId = 0;
        filterMoviesDTO.UpcomingReleases = false;
        filterMoviesDTO.InTheaters = false;
        await LoadMovies();
    }

    private async Task TitleKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            await SearchForMovies();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenreRepository genreRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMoviesRepository moviesRepository { get; set; }
    }
}
#pragma warning restore 1591
