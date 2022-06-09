using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using VideoRentDemoApp.Data;
using VideoRentDemoApp.Interface;
using VideoRentDemoApp.Models;

namespace VideoRentDemoApp.Repos
{
	public class MovieRepository : IRepository<Movie>
	{
		private readonly ApplicationDbContext _context;
		public MovieRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public void Delete(Movie movie)
		{
			_context.Movies.Remove(movie);
			_context.SaveChanges();
		}

		public void Create(Movie movie)
		{
			_context.Movies.Add(movie);
			_context.SaveChanges();
		}

		public void Update(Movie movie)
		{
			_context.Movies.Update(movie);
			_context.SaveChanges();
		}

		public Movie GetById(int id)
		{
			var movie = _context.Movies
				.Include(i => i.Renter)
				.FirstOrDefault(m => m.MovieId == id);

			return movie;
		}

		public IEnumerable<Movie> GetList()
		{
			var movies = _context.Movies.ToList();
			return movies;
		}
	}
}
