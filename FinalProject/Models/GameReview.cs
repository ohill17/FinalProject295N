
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class GameReview
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Body { get; set; }
        public int Rating { get; set; }
        public string ImageUrl { get; set; } 
        public List<GameRating> Ratings { get; set; } = new List<GameRating>();
    }
}
