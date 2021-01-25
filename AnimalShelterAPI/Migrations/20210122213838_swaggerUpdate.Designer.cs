﻿// <auto-generated />
using AnimalShelterAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterAPI.Migrations
{
    [DbContext(typeof(AnimalShelterAPIContext))]
    [Migration("20210122213838_swaggerUpdate")]
    partial class swaggerUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterAPI.Models.Cat", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("CatId");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            CatId = 1,
                            Age = 1,
                            Name = "Delirium",
                            Type = "British Shorthair"
                        },
                        new
                        {
                            CatId = 2,
                            Age = 3,
                            Name = "Sprite",
                            Type = "Bengal Cat"
                        },
                        new
                        {
                            CatId = 3,
                            Age = 7,
                            Name = "Castle",
                            Type = "Siamese"
                        },
                        new
                        {
                            CatId = 4,
                            Age = 5,
                            Name = "Cleo",
                            Type = "Turkish Angora"
                        },
                        new
                        {
                            CatId = 5,
                            Age = 4,
                            Name = "Frank",
                            Type = "Birman"
                        });
                });

            modelBuilder.Entity("AnimalShelterAPI.Models.Dog", b =>
                {
                    b.Property<int>("DogId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Breed");

                    b.Property<string>("Name");

                    b.HasKey("DogId");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogId = 1,
                            Age = 5,
                            Breed = "Shiba Inu",
                            Name = "Ragnar"
                        },
                        new
                        {
                            DogId = 2,
                            Age = 2,
                            Breed = "Miniature Pincher",
                            Name = "Gauge"
                        },
                        new
                        {
                            DogId = 3,
                            Age = 1,
                            Breed = "Doberman",
                            Name = "Ren"
                        },
                        new
                        {
                            DogId = 4,
                            Age = 10,
                            Breed = "Pit Bull",
                            Name = "Kratos"
                        },
                        new
                        {
                            DogId = 5,
                            Age = 6,
                            Breed = "Husky",
                            Name = "Odin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
