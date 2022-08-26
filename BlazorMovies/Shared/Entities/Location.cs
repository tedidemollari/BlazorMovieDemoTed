using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorMovies.Shared.Entities
{
    public class Location
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }
        public string Poster { get; set; }
        public List<MoviesLocations> MoviesLocations { get; set; } = new List<MoviesLocations>();


    }
}
