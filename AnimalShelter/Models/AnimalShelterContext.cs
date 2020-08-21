using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Creatures {get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Pet>()
            .HasData(
                new Pet {PetId=1, PetName= "Mark", PetAdmissionDate = "8/13/2020", PetTaxonomy= "Cat", PetBreed = "Calico", PetDescription = "Don't look Mark straight in the eyes. He likes to get scratchy."}
            );
        }
    }
}