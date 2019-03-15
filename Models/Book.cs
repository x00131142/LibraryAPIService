using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI
{
    public class Book
    {
        [Key]
        public string ISBN {get; set;}
        [Required]
        public string Title {get; set;}
        [Required]
        public string Author {get; set;}
        [Required]
        public string ReleaseDate {get; set;}
        public string Genre {get; set;}
    }
}
