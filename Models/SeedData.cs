using Books.Data;
using Microsoft.EntityFrameworkCore;

namespace Books.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new BooksContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BooksContext>>()))
            {
                // Look for any books.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.AddRange(
                    new User
                    {
                        Fullname = "Test",
                        Username = "user",
                        Password = "password",
                        Role = "admin"
                    }
                );
                context.SaveChanges();

                context.Book.AddRange(
                    new Book
                    {
                        Title = "When Harry Met Sally",
                        EditionYear = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 12,
                        Userid = 1
                    },

                    new Book
                    {
                        Title = "Ghostbusters ",
                        EditionYear = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8,
                        Userid = 1
                    },

                    new Book
                    {
                        Title = "Ghostbusters 2",
                        EditionYear = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9,
                        Userid = 1
                    },

                    new Book
                    {
                        Title = "Rio Bravo",
                        EditionYear = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3,
                        Userid = 1
                    }
                );
                context.SaveChanges();
            }
        }
    }
}