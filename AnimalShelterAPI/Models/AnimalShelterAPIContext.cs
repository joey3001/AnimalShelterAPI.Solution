using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;

namespace AnimalShelterAPI.Models
{
  public class AnimalShelterAPIContext : DbContext
  {
    public AnimalShelterAPIContext(DbContextOptions<AnimalShelterAPIContext> options) : base(options)
    {
    }

    public DbSet<Dog> Dogs { get; set; }
    public DbSet<Cat> Cats { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Dog>()

        .HasData(
            
        );

      builder.Entity<Cat>()

        .HasData(
            
        );
    }
  }
}