using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pets {get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Pet>()
            .HasData(
              new Pet {PetId=1, PetName= "Barkley", PetAdmissionDate = "44044", PetTaxonomy= "Dog", PetBreed = "German Shepherd", PetDescription = "loves to cuddle"},
              new Pet {PetId=2, PetName= "Max", PetAdmissionDate = "44035", PetTaxonomy= "Dog", PetBreed = "Bulldog", PetDescription = "very affectionate"},
              new Pet {PetId=3, PetName= "Charlie", PetAdmissionDate = "43954", PetTaxonomy= "Cat", PetBreed = "Calico", PetDescription = "good with kids"},
              new Pet {PetId=4, PetName= "Buddy", PetAdmissionDate = "44000", PetTaxonomy= "Cat", PetBreed = "Scottish Fold", PetDescription = "bad with kids"},
              new Pet {PetId=5, PetName= "Rocky", PetAdmissionDate = "43978", PetTaxonomy= "Cat", PetBreed = "Calico", PetDescription = "single pet home"},
              new Pet {PetId=6, PetName= "Jake", PetAdmissionDate = "43941", PetTaxonomy= "Dog", PetBreed = "Poodle", PetDescription = "loves long walks"},
              new Pet {PetId=7, PetName= "Jack", PetAdmissionDate = "43938", PetTaxonomy= "Dog", PetBreed = "Labrador Retriever", PetDescription = "loves to cuddle"},
              new Pet {PetId=8, PetName= "Toby", PetAdmissionDate = "43894", PetTaxonomy= "Cat", PetBreed = "Calico", PetDescription = "very affectionate"},
              new Pet {PetId=9, PetName= "Cody", PetAdmissionDate = "43965", PetTaxonomy= "Dog", PetBreed = "Beagle", PetDescription = "good with kids"},
              new Pet {PetId=10, PetName= "Buster", PetAdmissionDate = "43997", PetTaxonomy= "Cat", PetBreed = "Calico", PetDescription = "bad with kids"},
              new Pet {PetId=11, PetName= "Duke", PetAdmissionDate = "44044", PetTaxonomy= "Dog", PetBreed = "Daschund", PetDescription = "single pet home"},
              new Pet {PetId=12, PetName= "Cooper", PetAdmissionDate = "44035", PetTaxonomy= "Cat", PetBreed = "Calico", PetDescription = "loves long walks"},
              new Pet {PetId=13, PetName= "Riley", PetAdmissionDate = "43954", PetTaxonomy= "Dog", PetBreed = "Siberian Husky", PetDescription = "loves to cuddle"},
              new Pet {PetId=14, PetName= "Harley", PetAdmissionDate = "44000", PetTaxonomy= "Cat", PetBreed = "Scottish Fold", PetDescription = "very affectionate"},
              new Pet {PetId=15, PetName= "Bear", PetAdmissionDate = "43978", PetTaxonomy= "Dog", PetBreed = "French Bulldog", PetDescription = "good with kids"},
              new Pet {PetId=16, PetName= "Tucker", PetAdmissionDate = "43941", PetTaxonomy= "Cat", PetBreed = "Persian", PetDescription = "bad with kids"},
              new Pet {PetId=17, PetName= "Murphy", PetAdmissionDate = "43938", PetTaxonomy= "Dog", PetBreed = "Rottweiler", PetDescription = "single pet home"},
              new Pet {PetId=18, PetName= "Lucky", PetAdmissionDate = "43986", PetTaxonomy= "Cat", PetBreed = "Siamese", PetDescription = "loves long walks"},
              new Pet {PetId=19, PetName= "Oliver", PetAdmissionDate = "43935", PetTaxonomy= "Dog", PetBreed = "Rottweiler", PetDescription = "loves to cuddle"},
              new Pet {PetId=20, PetName= "Sam", PetAdmissionDate = "43905", PetTaxonomy= "Cat", PetBreed = "Bengal", PetDescription = "very affectionate"},
              new Pet {PetId=21, PetName= "Oscar", PetAdmissionDate = "44044", PetTaxonomy= "Cat", PetBreed = "Scottish Fold", PetDescription = "good with kids"},
              new Pet {PetId=22, PetName= "Teddy", PetAdmissionDate = "44035", PetTaxonomy= "Cat", PetBreed = "Maine Coon", PetDescription = "bad with kids"},
              new Pet {PetId=23, PetName= "Winston", PetAdmissionDate = "43954", PetTaxonomy= "Dog", PetBreed = "French Bulldog", PetDescription = "single pet home"},
              new Pet {PetId=24, PetName= "Sammy", PetAdmissionDate = "44000", PetTaxonomy= "Cat", PetBreed = "Bengal", PetDescription = "loves long walks"},
              new Pet {PetId=25, PetName= "Bella", PetAdmissionDate = "43978", PetTaxonomy= "Dog", PetBreed = "Daschund", PetDescription = "loves to cuddle"},
              new Pet {PetId=26, PetName= "Lucy", PetAdmissionDate = "43941", PetTaxonomy= "Dog", PetBreed = "Siberian Husky", PetDescription = "very affectionate"},
              new Pet {PetId=27, PetName= "Molly", PetAdmissionDate = "43938", PetTaxonomy= "Dog", PetBreed = "Siberian Husky", PetDescription = "good with kids"},
              new Pet {PetId=28, PetName= "Daisy", PetAdmissionDate = "43894", PetTaxonomy= "Cat", PetBreed = "Maine Coon", PetDescription = "bad with kids"},
              new Pet {PetId=29, PetName= "Maggie", PetAdmissionDate = "43965", PetTaxonomy= "Dog", PetBreed = "Rat Terrier", PetDescription = "single pet home"},
              new Pet {PetId=30, PetName= "Sophie", PetAdmissionDate = "43997", PetTaxonomy= "Cat", PetBreed = "Maine Coon", PetDescription = "loves long walks"},
              new Pet {PetId=31, PetName= "Sadie", PetAdmissionDate = "44044", PetTaxonomy= "Dog", PetBreed = "Rat Terrier", PetDescription = "loves to cuddle"},
              new Pet {PetId=32, PetName= "Chloe", PetAdmissionDate = "44035", PetTaxonomy= "Dog", PetBreed = "Bulldog", PetDescription = "very affectionate"},
              new Pet {PetId=33, PetName= "Bailey", PetAdmissionDate = "43954", PetTaxonomy= "Cat", PetBreed = "Maine Coon", PetDescription = "good with kids"},
              new Pet {PetId=34, PetName= "Lola", PetAdmissionDate = "44000", PetTaxonomy= "Cat", PetBreed = "Calico", PetDescription = "bad with kids"},
              new Pet {PetId=35, PetName= "Zoe", PetAdmissionDate = "43978", PetTaxonomy= "Cat", PetBreed = "Siamese", PetDescription = "single pet home"},
              new Pet {PetId=36, PetName= "Abby", PetAdmissionDate = "43941", PetTaxonomy= "Cat", PetBreed = "Siamese", PetDescription = "loves long walks"},
              new Pet {PetId=37, PetName= "Ginger", PetAdmissionDate = "43938", PetTaxonomy= "Cat", PetBreed = "Persian", PetDescription = "loves to cuddle"},
              new Pet {PetId=38, PetName= "Roxy", PetAdmissionDate = "43986", PetTaxonomy= "Dog", PetBreed = "Poodle", PetDescription = "very affectionate"},
              new Pet {PetId=39, PetName= "Gracie", PetAdmissionDate = "43935", PetTaxonomy= "Cat", PetBreed = "Persian", PetDescription = "good with kids"},
              new Pet {PetId=40, PetName= "Coco", PetAdmissionDate = "43905", PetTaxonomy= "Dog", PetBreed = "Golden Retriever", PetDescription = "bad with kids"},
              new Pet {PetId=41, PetName= "Sasha", PetAdmissionDate = "44044", PetTaxonomy= "Cat", PetBreed = "Bengal", PetDescription = "single pet home"},
              new Pet {PetId=42, PetName= "Lily", PetAdmissionDate = "44035", PetTaxonomy= "Cat", PetBreed = "Sphynx", PetDescription = "loves long walks"},
              new Pet {PetId=43, PetName= "Angel", PetAdmissionDate = "43954", PetTaxonomy= "Cat", PetBreed = "Sphynx", PetDescription = "loves to cuddle"},
              new Pet {PetId=44, PetName= "Princess", PetAdmissionDate = "44000", PetTaxonomy= "Dog", PetBreed = "Beagle", PetDescription = "very affectionate"},
              new Pet {PetId=45, PetName= "Emma", PetAdmissionDate = "43978", PetTaxonomy= "Dog", PetBreed = "Rottweiler", PetDescription = "good with kids"},
              new Pet {PetId=46, PetName= "Annie", PetAdmissionDate = "43941", PetTaxonomy= "Dog", PetBreed = "Doberman", PetDescription = "bad with kids"},
              new Pet {PetId=47, PetName= "Rosie", PetAdmissionDate = "43938", PetTaxonomy= "Cat", PetBreed = "Calico", PetDescription = "single pet home"},
              new Pet {PetId=48, PetName= "Ruby", PetAdmissionDate = "43894", PetTaxonomy= "Dog", PetBreed = "German Shepherd", PetDescription = "loves long walks"},
              new Pet {PetId=49, PetName= "Gladys", PetAdmissionDate = "43965", PetTaxonomy= "Dog", PetBreed = "Bulldog", PetDescription = "loves to cuddle"},
              new Pet {PetId=50, PetName= "Mark", PetAdmissionDate = "43967", PetTaxonomy= "Cat", PetBreed = "Persian", PetDescription = "very affectionate"}
            );
        }
    }
}