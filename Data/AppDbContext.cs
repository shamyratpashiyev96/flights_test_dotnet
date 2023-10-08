using Microsoft.EntityFrameworkCore;
using testApp.Models;

namespace testApp.Data;

public class AppDbContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //  #warning To protect potentially sensitive information in your connection string, 
        //  you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 
        //  for guidance on storing connection strings.
        
        optionsBuilder.UseMySQL("server=localhost;database=dummy_db;user=dummy_user;password=PASSword123$%");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        List<Airport> airports = new(){
            new Airport { City = "New York", Code = "JFK" },
            new Airport { City = "London", Code = "HTR" },
            new Airport { City = "Paris", Code = "CDH" },
            new Airport { City = "Rome", Code = "RMA" },
            new Airport { City = "Shanghai", Code = "SHA" },
        };

        int airport_id = 0;
        foreach(var airport in airports){
            airport_id++;
            airport.Id = airport_id;
            modelBuilder.Entity<Airport>().HasData(airport);
        }
    }

    public DbSet<Airport> Airports { get; set; }
}