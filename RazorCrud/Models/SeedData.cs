using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RazorCrud.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context =
                new RazorCrudBookContext(serviceProvider.GetRequiredService<DbContextOptions<RazorCrudBookContext>>());
            if (context.Book.Any())
            {
                return;
            }

            context.Book.AddRange(
                new Book
                {
                    Title = "Spinning Silver",
                    Author = "Naomi Novik",
                    ReleaseDate = DateTime.Parse("07-10-2018"),
                    Genre = "Fairy Tale",
                    Price = 17
                },
                new Book
                {
                    Title = "Wuthering Heights",
                    Author = "Emily Bronte",
                    ReleaseDate = DateTime.Parse("01-20-1978"),
                    Genre = "Romance",
                    Price = new decimal(5.99)
                },
                new Book
                {
                    Title = "The Five People You Meet in Heaven",
                    Author = "Mitch Albom",
                    ReleaseDate = DateTime.Parse("09-23-2003"),
                    Genre = "Psychological Fiction",
                    Price = new decimal(12.7)
                },
                new Book
                {
                    Title = "The Da Vinci Code",
                    Author = "Dan Brown",
                    ReleaseDate = DateTime.Parse("04-01-2003"),
                    Genre = "Mystery Thriller",
                    Price = 9
                });
            context.SaveChanges();
        }
    }
}