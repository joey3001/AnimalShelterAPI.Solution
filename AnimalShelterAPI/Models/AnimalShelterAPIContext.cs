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
          new Dog { DogId = 1, Age = 5, Name = "Ragnar", Breed = "Shiba Inu" },
          new Dog { DogId = 2, Age = 2, Name = "Gauge", Breed = "Miniature Pincher" },
          new Dog { DogId = 3, Age = 1, Name = "Ren", Breed = "Doberman" },
          new Dog { DogId = 4, Age = 10, Name = "Kratos", Breed = "Pit Bull" },
          new Dog { DogId = 5, Age = 6, Name = "Odin", Breed = "Husky" }
        );
        

      builder.Entity<Cat>()

        .HasData(
            
        );
    }
  }
}