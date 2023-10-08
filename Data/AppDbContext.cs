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

    public DbSet<Airport> Airports { get; set; }
}