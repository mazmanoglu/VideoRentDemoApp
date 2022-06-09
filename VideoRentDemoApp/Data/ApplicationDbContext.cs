using Microsoft.EntityFrameworkCore;
using System;
using VideoRentDemoApp.Models;


namespace VideoRentDemoApp.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Movie>()
				.HasData(
					new Movie { MovieId = 1, Length = 125, Title = "Titanic", Genre = "Romance", MainActress = "Kate Winslet", DateRelease = new DateTime(1997, 12, 19), Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic", ImageUrl = "Titanic.jpg", ImdbUrl = "https://www.imdb.com/title/tt0120338/", RenterId=1 },
					new Movie { MovieId = 2, Length = 105, Title = "Inglorious Basterds", Genre = "Action", MainActress = "Diane Kruger", DateRelease = new DateTime(2009, 08, 21), Description = "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same", ImageUrl = "InBasterds.jpg", ImdbUrl = "https://www.imdb.com/title/tt0361748/", RenterId=2 },
					new Movie { MovieId = 3, Length = 135, Title = "Star Trek - Into Darkness", Genre = "Sci-Fi", MainActress = "Zoe Saldana", DateRelease = new DateTime(2013, 05, 16), Description = "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction", ImageUrl = "StarTrek.jpg", ImdbUrl = "https://www.imdb.com/title/tt1408101/", RenterId=2 },
					new Movie { MovieId = 4, Length = 110, Title = "Top Gun", Genre = "Action-Drama", MainActress = "Kelly McGills", DateRelease = new DateTime(1986, 05, 16), Description = "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.", ImageUrl = "topgun.jpg", ImdbUrl = "https://www.imdb.com/title/tt0092099/" }

				);

			modelBuilder.Entity<Renter>()
				.HasData(
					new Renter { RenterId = 1, FirstName = "Fatih", LastName = "Ozer" },
					new Renter { RenterId = 2, FirstName = "Anass", LastName = "Allamzi" },
					new Renter { RenterId = 3, FirstName = "Olga", LastName = "Kharchuk" }
				);
		}

		public DbSet<Movie> Movies { get; set; }
		public DbSet<Renter> Renters { get; set; }
	}
}
