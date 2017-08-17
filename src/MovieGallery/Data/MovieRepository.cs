using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieGallery.Models;

namespace MovieGallery.Data
{
    public class MovieRepository
    {
        private static Movie[] _movies = new Movie[]
        {
            new Movie()
            {
                Title = "Rogue One, A Star Wars Trilogy",
                Id = 1,
                Rated = "PG-13",
                Length = "2h 13m",
                PlotHtml = "<p><b>Plot</b>: In a time of conflict, a group of unlikely heroes band together on a mission to steal the plans to the Death Star, the Empire’s ultimate weapon of destruction. This key event in the Star Wars timeline brings together ordinary people who choose to do extraordinary things, and in doing so, become part of something greater than themselves.</p>",
                Actors = new string[]
                    {
                        "Felicity Jones",
                        "Diego Luna",
                        "Alan Tudyk",
                        "Donnie Yen",
                        "Wen Jiang"
                    }
            },

            new Movie()
            {
                Title = "Beerfest",
                Id = 2,
                Rated = "PG-13",
                Length = "2h 10m",
                PlotHtml = "<p><b>Plot</b>: In a time of conflict, a group of unlikely heroes band together on a mission to steal the plans to the Death Star, the Empire’s ultimate weapon of destruction. This key event in the Star Wars timeline brings together ordinary people who choose to do extraordinary things, and in doing so, become part of something greater than themselves.</p>",
                Actors = new string[]
                    {
                        "Felicity Jones",
                        "Diego Luna",
                        "Alan Tudyk",
                        "Donnie Yen",
                        "Wen Jiang"
                    }
            },

            new Movie()
            {
                Title = "Jumanji",
                Id = 3,
                Rated = "PG-13",
                Length = "2h 10m",
                PlotHtml = "<p><b>Plot</b>: In a time of conflict, a group of unlikely heroes band together on a mission to steal the plans to the Death Star, the Empire’s ultimate weapon of destruction. This key event in the Star Wars timeline brings together ordinary people who choose to do extraordinary things, and in doing so, become part of something greater than themselves.</p>",
                Actors = new string[]
                    {
                        "Felicity Jones",
                        "Diego Luna",
                        "Alan Tudyk",
                        "Donnie Yen",
                        "Wen Jiang"
                    }
            }


        };

        public Movie GetMovie(int id)
        {
            Movie movieToReturn = null;

            foreach (var movie in _movies)
            {
                if(movie.Id == id)
                {
                    movieToReturn = movie;
                    break;
                }
            }
            return movieToReturn;
        }

        public Movie[] GetMovies()
        {
            return _movies;
        }
    }
}