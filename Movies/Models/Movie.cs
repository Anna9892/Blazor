using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]  //обязательное поле
        [StringLength(50, MinimumLength =2)]
        [RegularExpression(@"^[A-ZА-Я0-9][a-zA-Za-zа-яА-Я0-9\s\-,.:!?«»""]*$")]
        public string Title {  get; set; }

        [RangeAttribute(typeof(DateOnly), "1895-12-28", "2030-12-31")]
        public DateOnly ReleaseDate { get; set; }
        public string Genre {  get; set; }
        public string? URL { get; set; }
        public string? Poster {  get; set; }
    }
}
