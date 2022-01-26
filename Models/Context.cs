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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //seeding
            mb.Entity<AddResponse>().HasData(

                new AddResponse
                {
                    id = 1,
                    Title = "The Big Lebowski",
                    Category = "Comedy/Crime",
                    Year = 1998,
                    Director = "The Coen Brothers",
                    Rating = "R",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },


                new AddResponse
                {
                    id = 2,
                    Title = "Joker",
                    Category = "Crime/Drama/Thriller",
                    Year = 2019,
                    Director = "Todd Phillips",
                    Rating = "R",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },


            new AddResponse
            {
                id = 3,
                Title = "Tenet",
                Category = "Action/Thriller",
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
