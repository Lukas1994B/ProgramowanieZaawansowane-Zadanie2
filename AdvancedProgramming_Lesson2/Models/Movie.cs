using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson2.Models
{
    public class Movie
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Genre")]
        public string Genre { get; set; }
        [Display(Name = "Price")]
        public decimal Price { get; set; }
    }
}
