using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;
using System.Runtime.Intrinsics.X86;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {

                    Poster = "17-miracles.jpg",
                    Title = "17 Miracles",
                    ReleaseDate = DateTime.Parse("2011-6-3"),
                    Genre = "Adventure-Drama",
                    Rating = "PG",
                    Price = 9.99M
                },
                new Movie
                {
                    Poster = "ephraims-rescue.jpg",
                    Title = "Ephraim's Rescue",
                    ReleaseDate = DateTime.Parse("2013-5-31"),
                    Genre = "Adventure-Drama",
                    Rating = "PG",
                    Price = 19.99M
                },
                new Movie
                {
                    Poster = "otle.jpg",
                    Title = "On the Lord's Errand: The Life of Thomas S. Monson",
           
                    ReleaseDate = DateTime.Parse("2009-9-1"),
                    Genre = "Documentary",
                    Rating = "PG",
                    Price = 0.00M
                },
                new Movie
                {
                    Poster = "the-rm.jpg",
                    Title = "The RM",
                    ReleaseDate = DateTime.Parse("2003-1-31"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 15.99M
                }
            );
            context.SaveChanges();
        }
    }
}