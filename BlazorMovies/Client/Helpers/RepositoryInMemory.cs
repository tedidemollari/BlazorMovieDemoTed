using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie(){Title = "Spider-Man: Far From Home",
                    ReleaseDate = new DateTime(2019, 7, 2),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMGZlNTY1ZWUtYTMzNC00ZjUyLWE0MjQtMTMxN2E3ODYxMWVmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_SY1000_CR0,0,674,1000_AL_.jpg"
                },
                new Movie(){Title = "Moana",
                    ReleaseDate = new DateTime(2016, 11, 23),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjI4MzU5NTExNF5BMl5BanBnXkFtZTgwNzY1MTEwMDI@._V1_SY1000_CR0,0,674,1000_AL_.jpg"
                },
                new Movie(){Title = "Inception",
                    ReleaseDate = new DateTime(2010, 7, 16),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_SY1000_CR0,0,675,1000_AL_.jpg"
                }
            };
        }
        public List<Location> GetLocations()
        {
            return new List<Location>()
    {
                new Location(){
                    Name = "Tirane",
                    Poster = "https://th.bing.com/th/id/OIP.yxzh1RWh9I-Fm9oM3UopOgHaEs?w=268&h=180&c=7&r=0&o=5&pid=1.7"
                },
                new Location(){Name = "Durres",
                    Poster = "https://th.bing.com/th/id/OIP.PnFAjdZ1ZUFX6nNeTcWOKwHaE8?w=258&h=180&c=7&r=0&o=5&pid=1.7"
                },
                new Location(){Name = "Vlore",
                    Poster = "https://th.bing.com/th/id/OIP.fFdlJh37KzwIULLVKzjnfwHaEp?w=273&h=180&c=7&r=0&o=5&dpr=1.25&pid=1.7"
                }
            };
        }
    }
}

