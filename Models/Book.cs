using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace LibraryAPIService.Models
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }

        [Required]
        public string Title { get; set; }

        public string Author { get; set;}
        //public List<BookAuthor> BookAuthors { get; set; }

        public string Publisher { get; set; }

        [Required]
        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string PurchaseLink { get; set; }
    }
/*
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }

        public List<BookAuthor> BookAuthors { get; set; }

        
    }

    public class BookAuthor
    {
        public string ISBN { get; set;}

        public Book Book { get; set;}

        public string AuthorID { get; set; }

        public Author Author { get; set;}
    }
*/
}