using System.ComponentModel.DataAnnotations;

namespace VidlyAuth.Models
{

        public class Genre
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public string GenreType { get; set; }
        }
    }
