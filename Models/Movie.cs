using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MovieLab.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }

        public int SearchQuery { get; set; }

        public string ShowActor { get; set; }
        
        public List<Actor> Actors
        {
            get
            {
                return Actor.GetAllActors().Where(actor => ActorList.Contains(actor.Id)).ToList();
            }
        }
        
        public List<string> ActorList { get; set; }

        //Call this static function to get all movies
        public static List<Movie> GetAllMovies()
        {
            return JsonSerializer.Deserialize<List<Movie>>(File.ReadAllText(@"Data/Movies.json"));
        }
    }

}