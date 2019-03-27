using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace LibraryAPIService.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BookContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                  new Book
                  {
                      ISBN = "978-0131103627",
                      Title = "The C Programming Language (2nd Edition)",
                      Author = "Dennis Ritchie",
                      Publisher = "Prentice Hall",
                      Genre = "Programming",
                      ReleaseDate = new DateTime(1988, 3, 22),
                      PurchaseLink = "https://www.amazon.co.uk/C-Programming-Language-2nd/dp/0131103628/ref=sr_1_1?ie=UTF8&qid=1552676852&sr=8-1&keywords=The+C+Programming+Language"
                  },

                    new Book
                    {
                        ISBN = "978-0139376818",
                        Title = "The UNIX Programming Environment",
                        Author = "Brian W. Kernighan",
                        Publisher = "Prentice Hall",
                        Genre = "Programming",
                        ReleaseDate = new DateTime(1983, 11, 1),
                        PurchaseLink = "https://www.amazon.co.uk/UNIX-Programming-Environment-Prentice-Hall-Software/dp/013937681X/ref=sr_1_4?ie=UTF8&qid=1552678713&sr=8-4&keywords=prentice+hall"
                    },

                   new Book
                   {
                       ISBN = "978-0241969816",
                       Title = "High Fidelity",
                       Author = "Nick Hornby",
                       Publisher = "Penguin",
                       Genre = "Humour",
                       ReleaseDate = new DateTime(2014, 1, 2),
                       PurchaseLink = "https://www.amazon.co.uk/High-Fidelity-Nick-Hornby/dp/0241969816/ref=sr_1_2?ie=UTF8&qid=1552679752&sr=8-2&keywords=high+fidelity"
                   },

                    new Book
                    {
                        ISBN = "0-13-937681-X",
                        Title = "The Hitchhiker's Guide to the Galaxy",
                        Author = "Douglas Adams",
                        Publisher = "Pan Books",
                        Genre = "Science Fiction",
                        ReleaseDate = new DateTime(1979, 10, 12),
                        PurchaseLink = "https://www.amazon.co.uk/Hitchhikers-Guide-Galaxy-Douglas-Adams/dp/1509808310/ref=pd_sbs_14_1/260-1998968-3552634?_encoding=UTF8&pd_rd_i=1509808310&pd_rd_r=405d2f6f-475d-11e9-917c-7de6dac306e9&pd_rd_w=Z1ncX&pd_rd_wg=6DoCz&pf_rd_p=18edf98b-139a-41ee-bb40-d725dd59d1d3&pf_rd_r=7SWZYDJFC2RN3EQ12GMS&psc=1&refRID=7SWZYDJFC2RN3EQ12GMS"
                    });
                context.SaveChanges();
            }
        }
    }
}
