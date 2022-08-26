using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovies.Shared.Entities
{
    public class MoviesLocations
    {
        public int MovieId { get; set; }
        public int LocationId { get; set; }
        public Movie Movie { get; set; }
        public Location Location { get; set; }
    }
}
