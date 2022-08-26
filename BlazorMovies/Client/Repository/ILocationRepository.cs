using BlazorMovies.Client.Pages.Locations;
using BlazorMovies.Shared.DTOs;
using BlazorMovies.Shared.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repository
{
    public interface ILocationRepository
    {
        Task<List<Location>> GetLocations();
        Task<Location> GetLocation(int Id);
        Task CreateLocation(Location location);
        Task UpdateLocation(Location location);
        Task DeleteLocation(int Id);
        Task<DetailsLocationDTO> GetDetailsLocationDTO(int id);
    }
}
