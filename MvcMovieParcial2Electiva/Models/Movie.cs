﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovieParcial2Electiva.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public string? Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public String? Genre { get; set; }

        [Column(TypeName = "decimal (18,2)")]
        public decimal Price { get; set; }


    }
}
