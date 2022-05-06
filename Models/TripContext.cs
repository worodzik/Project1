using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Project1.Models
{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext> options)
            : base(options)
        { }

        public DbSet<Trip> Trips { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>().HasData(
                new Trip
                {
                    Destination = "Boise",
                    StartDate = Convert.ToDateTime("2020-06-06"),
                    EndDate = Convert.ToDateTime("2020-06-14"),
                    ThingToDo1= "Visit Tammy"

                },
                new Trip
                {
                    Destination = "Portland",
                    StartDate = Convert.ToDateTime("2021-01-01"),
                    EndDate = Convert.ToDateTime("2021-01-07"),
                    Accomodation = "The Benson Hotel",
                    AccomodationPhone= "505-555-1234",
                    AccomodationEmail = "staff@bensonhotel.com",
                    ThingToDo1 = "Go to Voodoo Doughnuts",
                    ThingToDo2= "walk in the rain",
                    ThingToDo3 = "Go to Powell's"
                }
                
            );
            
        }
    }
}
