using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.Data
{
    [Table("Movie")]
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public int Year { get; set; }

        public string Summary { get; set; }
        [MaxLength(3)]

        public List<Actor> Actors { get; set; }
    }
  
}
