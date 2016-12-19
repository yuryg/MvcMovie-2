using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Display(Name = "Название")]
        [StringLength(60,MinimumLength =3,ErrorMessage ="Длина должна быть между 3 и 60")]
        public string Title { get; set; }

        [Display(Name="Дата выхода")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}", ApplyFormatInEditMode =true)]
        public DateTime ReleasedDate { get; set; }

        [Display(Name ="Жанр")]
        [StringLength(30)]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Genre { get; set; }

        [Display(Name = "Цена")]
        [Range(0,200)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        [Display(Name ="Рейтинг")]
        public string Rating { get; set; }
    }

    public class MovieDbContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}