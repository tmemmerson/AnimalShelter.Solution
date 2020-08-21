﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20200821213416_Secondary")]
    partial class Secondary
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PetAdmissionDate");

                    b.Property<string>("PetBreed");

                    b.Property<string>("PetDescription");

                    b.Property<string>("PetName");

                    b.Property<string>("PetTaxonomy");

                    b.HasKey("PetId");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            PetId = 1,
                            PetAdmissionDate = "44044",
                            PetBreed = "German Shepherd",
                            PetDescription = "loves to cuddle",
                            PetName = "Barkley",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 2,
                            PetAdmissionDate = "44035",
                            PetBreed = "Bulldog",
                            PetDescription = "very affectionate",
                            PetName = "Max",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 3,
                            PetAdmissionDate = "43954",
                            PetBreed = "Calico",
                            PetDescription = "good with kids",
                            PetName = "Charlie",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 4,
                            PetAdmissionDate = "44000",
                            PetBreed = "Scottish Fold",
                            PetDescription = "bad with kids",
                            PetName = "Buddy",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 5,
                            PetAdmissionDate = "43978",
                            PetBreed = "Calico",
                            PetDescription = "single pet home",
                            PetName = "Rocky",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 6,
                            PetAdmissionDate = "43941",
                            PetBreed = "Poodle",
                            PetDescription = "loves long walks",
                            PetName = "Jake",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 7,
                            PetAdmissionDate = "43938",
                            PetBreed = "Labrador Retriever",
                            PetDescription = "loves to cuddle",
                            PetName = "Jack",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 8,
                            PetAdmissionDate = "43894",
                            PetBreed = "Calico",
                            PetDescription = "very affectionate",
                            PetName = "Toby",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 9,
                            PetAdmissionDate = "43965",
                            PetBreed = "Beagle",
                            PetDescription = "good with kids",
                            PetName = "Cody",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 10,
                            PetAdmissionDate = "43997",
                            PetBreed = "Calico",
                            PetDescription = "bad with kids",
                            PetName = "Buster",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 11,
                            PetAdmissionDate = "44044",
                            PetBreed = "Daschund",
                            PetDescription = "single pet home",
                            PetName = "Duke",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 12,
                            PetAdmissionDate = "44035",
                            PetBreed = "Calico",
                            PetDescription = "loves long walks",
                            PetName = "Cooper",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 13,
                            PetAdmissionDate = "43954",
                            PetBreed = "Siberian Husky",
                            PetDescription = "loves to cuddle",
                            PetName = "Riley",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 14,
                            PetAdmissionDate = "44000",
                            PetBreed = "Scottish Fold",
                            PetDescription = "very affectionate",
                            PetName = "Harley",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 15,
                            PetAdmissionDate = "43978",
                            PetBreed = "French Bulldog",
                            PetDescription = "good with kids",
                            PetName = "Bear",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 16,
                            PetAdmissionDate = "43941",
                            PetBreed = "Persian",
                            PetDescription = "bad with kids",
                            PetName = "Tucker",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 17,
                            PetAdmissionDate = "43938",
                            PetBreed = "Rottweiler",
                            PetDescription = "single pet home",
                            PetName = "Murphy",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 18,
                            PetAdmissionDate = "43986",
                            PetBreed = "Siamese",
                            PetDescription = "loves long walks",
                            PetName = "Lucky",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 19,
                            PetAdmissionDate = "43935",
                            PetBreed = "Rottweiler",
                            PetDescription = "loves to cuddle",
                            PetName = "Oliver",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 20,
                            PetAdmissionDate = "43905",
                            PetBreed = "Bengal",
                            PetDescription = "very affectionate",
                            PetName = "Sam",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 21,
                            PetAdmissionDate = "44044",
                            PetBreed = "Scottish Fold",
                            PetDescription = "good with kids",
                            PetName = "Oscar",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 22,
                            PetAdmissionDate = "44035",
                            PetBreed = "Maine Coon",
                            PetDescription = "bad with kids",
                            PetName = "Teddy",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 23,
                            PetAdmissionDate = "43954",
                            PetBreed = "French Bulldog",
                            PetDescription = "single pet home",
                            PetName = "Winston",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 24,
                            PetAdmissionDate = "44000",
                            PetBreed = "Bengal",
                            PetDescription = "loves long walks",
                            PetName = "Sammy",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 25,
                            PetAdmissionDate = "43978",
                            PetBreed = "Daschund",
                            PetDescription = "loves to cuddle",
                            PetName = "Bella",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 26,
                            PetAdmissionDate = "43941",
                            PetBreed = "Siberian Husky",
                            PetDescription = "very affectionate",
                            PetName = "Lucy",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 27,
                            PetAdmissionDate = "43938",
                            PetBreed = "Siberian Husky",
                            PetDescription = "good with kids",
                            PetName = "Molly",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 28,
                            PetAdmissionDate = "43894",
                            PetBreed = "Maine Coon",
                            PetDescription = "bad with kids",
                            PetName = "Daisy",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 29,
                            PetAdmissionDate = "43965",
                            PetBreed = "Rat Terrier",
                            PetDescription = "single pet home",
                            PetName = "Maggie",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 30,
                            PetAdmissionDate = "43997",
                            PetBreed = "Maine Coon",
                            PetDescription = "loves long walks",
                            PetName = "Sophie",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 31,
                            PetAdmissionDate = "44044",
                            PetBreed = "Rat Terrier",
                            PetDescription = "loves to cuddle",
                            PetName = "Sadie",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 32,
                            PetAdmissionDate = "44035",
                            PetBreed = "Bulldog",
                            PetDescription = "very affectionate",
                            PetName = "Chloe",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 33,
                            PetAdmissionDate = "43954",
                            PetBreed = "Maine Coon",
                            PetDescription = "good with kids",
                            PetName = "Bailey",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 34,
                            PetAdmissionDate = "44000",
                            PetBreed = "Calico",
                            PetDescription = "bad with kids",
                            PetName = "Lola",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 35,
                            PetAdmissionDate = "43978",
                            PetBreed = "Siamese",
                            PetDescription = "single pet home",
                            PetName = "Zoe",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 36,
                            PetAdmissionDate = "43941",
                            PetBreed = "Siamese",
                            PetDescription = "loves long walks",
                            PetName = "Abby",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 37,
                            PetAdmissionDate = "43938",
                            PetBreed = "Persian",
                            PetDescription = "loves to cuddle",
                            PetName = "Ginger",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 38,
                            PetAdmissionDate = "43986",
                            PetBreed = "Poodle",
                            PetDescription = "very affectionate",
                            PetName = "Roxy",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 39,
                            PetAdmissionDate = "43935",
                            PetBreed = "Persian",
                            PetDescription = "good with kids",
                            PetName = "Gracie",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 40,
                            PetAdmissionDate = "43905",
                            PetBreed = "Golden Retriever",
                            PetDescription = "bad with kids",
                            PetName = "Coco",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 41,
                            PetAdmissionDate = "44044",
                            PetBreed = "Bengal",
                            PetDescription = "single pet home",
                            PetName = "Sasha",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 42,
                            PetAdmissionDate = "44035",
                            PetBreed = "Sphynx",
                            PetDescription = "loves long walks",
                            PetName = "Lily",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 43,
                            PetAdmissionDate = "43954",
                            PetBreed = "Sphynx",
                            PetDescription = "loves to cuddle",
                            PetName = "Angel",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 44,
                            PetAdmissionDate = "44000",
                            PetBreed = "Beagle",
                            PetDescription = "very affectionate",
                            PetName = "Princess",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 45,
                            PetAdmissionDate = "43978",
                            PetBreed = "Rottweiler",
                            PetDescription = "good with kids",
                            PetName = "Emma",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 46,
                            PetAdmissionDate = "43941",
                            PetBreed = "Doberman",
                            PetDescription = "bad with kids",
                            PetName = "Annie",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 47,
                            PetAdmissionDate = "43938",
                            PetBreed = "Calico",
                            PetDescription = "single pet home",
                            PetName = "Rosie",
                            PetTaxonomy = "Cat"
                        },
                        new
                        {
                            PetId = 48,
                            PetAdmissionDate = "43894",
                            PetBreed = "German Shepherd",
                            PetDescription = "loves long walks",
                            PetName = "Ruby",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 49,
                            PetAdmissionDate = "43965",
                            PetBreed = "Bulldog",
                            PetDescription = "loves to cuddle",
                            PetName = "Gladys",
                            PetTaxonomy = "Dog"
                        },
                        new
                        {
                            PetId = 50,
                            PetAdmissionDate = "43967",
                            PetBreed = "Persian",
                            PetDescription = "very affectionate",
                            PetName = "Mark",
                            PetTaxonomy = "Cat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
