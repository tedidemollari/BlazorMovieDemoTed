using BlazorMovies.Client.Helpers;
using BlazorMovies.Shared.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using BlazorMovies.Shared.DTOs;

namespace BlazorMovies.Client.Repository
{
    public class LocationRepository : ILocationRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/locations";

        public LocationRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Location>> GetLocations()
        {
            var response = await httpService.Get<List<Location>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<Location> GetLocation(int Id)
        {
            var response = await httpService.Get<Location>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreateLocation(Location location)
        {
            var response = await httpService.Post(url, location);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateLocation(Location location)
        {
            var response = await httpService.Put(url, location);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

       public async Task DeleteLocation(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
       public async Task<DetailsLocationDTO> GetDetailsLocationDTO(int id)
        {
            return await httpService.GetHelper<DetailsLocationDTO>($"{url}/{id}");
        }
    }
}
