using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace MovieLab.Models
{
    public class Actor
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }

        public List<Movie> Movies
        {
            get
            {
                return Movie.GetAllMovies().Where(movie => MovieList.Contains(movie.Id)).ToList();
            }
        }
        
        public List<int> MovieList { get; set;}
        
        //Call this static function to get all actors
        public static List<Actor> GetAllActors(){
            return JsonSerializer.Deserialize<List<Actor>>(File.ReadAllText(@"Data/Actors.json"));
        }
    }
}