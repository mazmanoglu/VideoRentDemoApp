﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VideoRentDemoApp.Data;

namespace VideoRentDemoApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220609003309_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VideoRentDemoApp.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRelease")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImdbUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("MainActress")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("RenterId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.HasIndex("RenterId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            DateRelease = new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic",
                            Genre = "Romance",
                            ImageUrl = "Titanic.jpg",
                            ImdbUrl = "https://www.imdb.com/title/tt0120338/",
                            Length = 125,
                            MainActress = "Kate Winslet",
                            RenterId = 1,
                            Title = "Titanic"
                        },
                        new
                        {
                            MovieId = 2,
                            DateRelease = new DateTime(2009, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same",
                            Genre = "Action",
                            ImageUrl = "InBasterds.jpg",
                            ImdbUrl = "https://www.imdb.com/title/tt0361748/",
                            Length = 105,
                            MainActress = "Diane Kruger",
                            RenterId = 2,
                            Title = "Inglorious Basterds"
                        },
                        new
                        {
                            MovieId = 3,
                            DateRelease = new DateTime(2013, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction",
                            Genre = "Sci-Fi",
                            ImageUrl = "StarTrek.jpg",
                            ImdbUrl = "https://www.imdb.com/title/tt1408101/",
                            Length = 135,
                            MainActress = "Zoe Saldana",
                            RenterId = 2,
                            Title = "Star Trek - Into Darkness"
                        },
                        new
                        {
                            MovieId = 4,
                            DateRelease = new DateTime(1986, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.",
                            Genre = "Action-Drama",
                            ImageUrl = "topgun.jpg",
                            ImdbUrl = "https://www.imdb.com/title/tt0092099/",
                            Length = 110,
                            MainActress = "Kelly McGills",
                            Title = "Top Gun"
                        });
                });

            modelBuilder.Entity("VideoRentDemoApp.Models.Renter", b =>
                {
                    b.Property<int>("RenterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("RentedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RenterId");

                    b.ToTable("Renters");

                    b.HasData(
                        new
                        {
                            RenterId = 1,
                            FirstName = "Fatih",
                            LastName = "Ozer",
                            RentedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RenterId = 2,
                            FirstName = "Anass",
                            LastName = "Allamzi",
                            RentedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RenterId = 3,
                            FirstName = "Olga",
                            LastName = "Kharchuk",
                            RentedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("VideoRentDemoApp.Models.Movie", b =>
                {
                    b.HasOne("VideoRentDemoApp.Models.Renter", "Renter")
                        .WithMany("Movies")
                        .HasForeignKey("RenterId");
                });
#pragma warning restore 612, 618
        }
    }
}
