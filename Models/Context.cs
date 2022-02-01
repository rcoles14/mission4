using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission4.Models
{
    public class Context : DbContext
    {
        //constructor
        public Context (DbContextOptions<Context> options) : base(options)
        {
            //blank for now
        }
        public DbSet<AddResponse> responses { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            //seeding
            mb.Entity<Category>().HasData(
                new Category { CategoryID=1, CategoryName = "Action / Adventure"},
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Family" },
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryID = 7, CategoryName = "Television" },
                new Category { CategoryID = 8, CategoryName = "VHS" }
                );

            mb.Entity<AddResponse>().HasData(

                new AddResponse
                {
                    id = 10001,
                    Title = "The Big Lebowski",
                    CategoryID = 2,
                    Year = 1998,
                    Director = "The Coen Brothers",
                    Rating = "R",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },


                new AddResponse
                {
                    id = 10002,
                    Title = "Joker",
                    CategoryID = 3,
                    Year = 2019,
                    Director = "Todd Phillips",
                    Rating = "R",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },


            new AddResponse
            {
                id = 10003,
                Title = "Tenet",
                CategoryID = 1,
                Year = 2020,
                Director = "Christopher Nolan",
                Rating = "PG-13",
                Edited = false,
                LentTo = null,
                Notes = null
            }
                );
        }
    }
}
