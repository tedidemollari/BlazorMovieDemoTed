using AutoMapper;
using BlazorMovies.Server.Helpers;
using BlazorMovies.Shared.DTOs;
using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;


        public LocationsController(ApplicationDbContext context, IFileStorageService fileStorageService, IMapper mapper)
        {
            this.context = context;
            this.fileStorageService = fileStorageService;
            this.mapper = mapper;
        }

        [HttpGet]   
        public async Task<ActionResult<List<Location>>> Get()
        {
            return await context.Locations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DetailsLocationDTO>> Get(int id)
        {
            var location = await context.Locations.Where(x => x.Id == id).Include(x => x.MoviesLocations).ThenInclude(x => x.Movie).FirstOrDefaultAsync();
            if (location == null) { return NotFound(); }  

            location.MoviesLocations = location.MoviesLocations.OrderBy(x => x.Movie.ReleaseDate).ToList();
            var model = new DetailsLocationDTO();
            model.Location = location;
            model.Movies = location.MoviesLocations.Select(x => x.Movie).ToList();
            model.Movies = location.MoviesLocations.Select(x =>
                new Movie
                {
                    Title = x.Movie.Title,
                    Summary = x.Movie.Summary,
                    ReleaseDate = x.Movie.ReleaseDate,
                    Poster = x.Movie.Poster,
                    Id = x.MovieId
                }).ToList();

            return model;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Location location)
        {
            if (!string.IsNullOrWhiteSpace(location.Poster))
            {
                var locationPoster = Convert.FromBase64String(location.Poster);
                location.Poster = await fileStorageService.SaveFile(locationPoster, "jpg", "location");
            }
            context.Add(location);
            await context.SaveChangesAsync();
            return location.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Location location)
        {
            var locationDB = await context.Locations.FirstOrDefaultAsync(x => x.Id == location.Id);

            if (locationDB == null) { return NotFound(); }

            locationDB = mapper.Map(location, locationDB);
            if (!string.IsNullOrWhiteSpace(location.Poster))
            {
                var locationPicture = Convert.FromBase64String(location.Poster);
                locationDB.Poster = await fileStorageService.EditFile(locationPicture,
                    "jpg", "location", locationDB.Poster);
            }
            context.Attach(location).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var location = await context.Locations.FirstOrDefaultAsync(x => x.Id == id);
            if (location == null)
            {
                return NotFound();
            }

            context.Remove(location);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
