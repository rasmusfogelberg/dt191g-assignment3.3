﻿// <auto-generated />
using DiscoSaurusApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiscosaurusApi.Migrations
{
    [DbContext(typeof(DiscoSaurusApiDbContext))]
    [Migration("20220222194714_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DiscosaurusApi.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            Duration = 507,
                            GenreId = 1,
                            Title = "Thunderstruck"
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 2,
                            Duration = 731,
                            GenreId = 2,
                            Title = "Balls to the Wall"
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 3,
                            Duration = 441,
                            GenreId = 3,
                            Title = "The Number of the Beast"
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 4,
                            Duration = 955,
                            GenreId = 1,
                            Title = "We Like It Here"
                        },
                        new
                        {
                            Id = 5,
                            ArtistId = 5,
                            Duration = 456,
                            GenreId = 3,
                            Title = "Volume Rock"
                        });
                });

            modelBuilder.Entity("DiscosaurusApi.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artist");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "AC/DC"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Accept"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Iron Maiden"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Snarky Puppy"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Valley Of The Sun"
                        });
                });

            modelBuilder.Entity("DiscosaurusApi.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Rock"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Jazz"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Metal"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
