using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Cat> Cats { get; set; }
    public DbSet<Dog> Dogs { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Cat>()
        .HasData(
          new Cat { CatId = 1, Name = "Jeremy", Breed = "Siamese", Age = 7 },
          new Cat { CatId = 2, Name = "Matilda", Breed = "Sphynx", Age = 4 },
          new Cat { CatId = 3, Name = "Sarah", Breed = "Persian", Age = 9 },
          new Cat { CatId = 4, Name = "Jake", Breed = "Burmese", Age = 3 },
          new Cat { CatId = 5, Name = "Bartholomeow", Breed = "Siberian", Age = 2 }
         );

         builder.Entity<Dog>()
        .HasData(
          new Dog { DogId = 1, Name = "Garfield", Breed = "Golden Retriever", Age = 2 },
          new Dog { DogId = 2, Name = "Bazinga", Breed = "Bulldog", Age = 5 },
          new Dog { DogId = 3, Name = "Rigby", Breed = "Poodle", Age = 8 },
          new Dog { DogId = 4, Name = "Clarence", Breed = "German Sheperd", Age = 1 },
          new Dog { DogId = 5, Name = "Stitch", Breed = "Border Collie", Age = 6 }
        );
    }
  }
}