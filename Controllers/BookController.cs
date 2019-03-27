using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryAPIService.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPIService.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookContext _context;

        public BookController(BookContext context)
        {
            _context = context;

            //if (_context.Books.Count() == 0)
            //{
            //    // Creates intial Book collection
            //    _context.Books.Add(new Book
            //    {
            //        ISBN = "978-0131103627",
            //        Title = "The C Programming Language (2nd Edition)",
            //        Author = "Dennis Ritchie",
            //        Publisher = "Prentice Hall",
            //        Genre = "Programming",
            //        ReleaseDate = new DateTime(1988, 3, 22),
            //        PurchaseLink = "https://www.amazon.co.uk/C-Programming-Language-2nd/dp/0131103628/ref=sr_1_1?ie=UTF8&qid=1552676852&sr=8-1&keywords=The+C+Programming+Language"
            //    });

            //    _context.Books.Add(new Book
            //    {
            //        ISBN = "978-0139376818",
            //        Title = "The UNIX Programming Environment",
            //        Author = "Brian W. Kernighan",
            //        Publisher = "Prentice Hall",
            //        Genre = "Programming",
            //        ReleaseDate = new DateTime(1983, 11, 1),
            //        PurchaseLink = "https://www.amazon.co.uk/UNIX-Programming-Environment-Prentice-Hall-Software/dp/013937681X/ref=sr_1_4?ie=UTF8&qid=1552678713&sr=8-4&keywords=prentice+hall"
            //    });

            //    _context.Books.Add(new Book
            //    {
            //        ISBN = "978-0241969816",
            //        Title = "High Fidelity",
            //        Author = "Nick Hornby",
            //        Publisher = "Penguin",
            //        Genre = "Humour",
            //        ReleaseDate = new DateTime(2014, 1, 2),
            //        PurchaseLink = "https://www.amazon.co.uk/High-Fidelity-Nick-Hornby/dp/0241969816/ref=sr_1_2?ie=UTF8&qid=1552679752&sr=8-2&keywords=high+fidelity"
            //    });

            //    _context.Books.Add(new Book
            //    {
            //        ISBN = "0-13-937681-X",
            //        Title = "The Hitchhiker's Guide to the Galaxy",
            //        Author = "Douglas Adams",
            //        Publisher = "Pan Books",
            //        Genre = "Science Fiction",
            //        ReleaseDate = new DateTime(1979, 10, 12),
            //        PurchaseLink = "https://www.amazon.co.uk/Hitchhikers-Guide-Galaxy-Douglas-Adams/dp/1509808310/ref=pd_sbs_14_1/260-1998968-3552634?_encoding=UTF8&pd_rd_i=1509808310&pd_rd_r=405d2f6f-475d-11e9-917c-7de6dac306e9&pd_rd_w=Z1ncX&pd_rd_wg=6DoCz&pf_rd_p=18edf98b-139a-41ee-bb40-d725dd59d1d3&pf_rd_r=7SWZYDJFC2RN3EQ12GMS&psc=1&refRID=7SWZYDJFC2RN3EQ12GMS"
            //    });

            //    _context.SaveChanges();
        }

        // GET: api/book
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Book.ToListAsync();
        }

        // GET: api/book/ISBN/978-0131103627
        [HttpGet("ISBN/{ISBN:maxlength(13)}")]
        public async Task<ActionResult<Book>> GetBookByISBN(string ISBN)
        {
            var book = await _context.Book.FindAsync(ISBN);

            if (book == null)
                return NotFound();

            return book;
        }

        // GET: api/book/Author/Dennis Ritchie
        [HttpGet("Author/{Author:alpha}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByAuthor(string Author)
        {
            var books = await _context.Book.Where(b => b.Author.ToUpper().Contains(Author.ToUpper())).ToListAsync();

            if (books == null)
                return NotFound();

            return books;
        }

        // GET: api/book/Title/The C Programming Language (2nd Edition)
        [HttpGet("Title/{Title:alpha}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByTitle(string Title)
        {
            var books = await _context.Book.Where(b => b.Title.ToUpper().Contains(Title.ToUpper())).ToListAsync();

            if (books == null)
                return NotFound();

            return books;
        }

        // GET: api/book/Title/Programming
        [HttpGet("Genre/{Genre:alpha}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByGenre(string Genre)
        {
            var books = await _context.Book.Where(b => b.Genre.ToUpper().Contains(Genre.ToUpper())).ToListAsync();

            if (books == null)
                return NotFound();

            return books;
        }

        // GET: api/book/Title/Prentice Hall
        [HttpGet("Publisher/{Publisher:alpha}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByPublisher(string Publisher)
        {
            var books = await _context.Book.Where(b => b.Publisher.ToUpper().Contains(Publisher.ToUpper())).ToListAsync();

            if (books == null)
                return NotFound();

            return books;
        }

        // GET: api/book/Title/"1983-11-01
        [HttpGet("ReleaseDate/{ReleaseDate}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByReleaseDate(string ReleaseDate)
        {
            var books = await _context.Book.Where(b => b.Author.Contains(ReleaseDate)).ToListAsync();

            if (books == null)
                return NotFound();

            return books;
        }
    }
}