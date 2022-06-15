using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using VideoRentDemoApp.Models;
using VideoRentDemoApp.Repos;

namespace VideoRentDemoApp.Controllers
{
	public class RentedMovieController : Controller
	{
		private readonly MovieRepository _movieRepository;

		public RentedMovieController(MovieRepository movieRepository)
		{
			_movieRepository = movieRepository;
		}

		//public IActionResult Index(int? id)
		//{
		//	var movies = _movieRepository.GetList();

		//	if (id != null)
		//	{
		//		movies = movies
		//			.Where(i => i.RenterId == id).ToList();
		//	}

		//	return View(movies);
		//}

		public ViewResult Index(string searchString, int? id)
		{
			var movies = _movieRepository.GetList();
			if (id != null)
			{
				movies = movies
					.Where(i => i.RenterId == id).ToList();
			}
			if (!String.IsNullOrEmpty(searchString))
			{
				movies = movies.Where(s => s.Title.ToLower().Contains(searchString.ToLower())).ToList();
			}
			return View(movies);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Movie movie)
		{
			_movieRepository.Create(movie);
			return RedirectToAction(nameof(Index));
		}
		[HttpGet]
		public IActionResult Update(int id)
		{
			var movie = _movieRepository.GetById(id);
			return View(movie);
		}
		[HttpPost]
		public IActionResult Update(Movie movie)
		{
			_movieRepository.Update(movie);
			return RedirectToAction(nameof(Index));
		}

		public IActionResult Details(int id)
		{
			var result = _movieRepository.GetById(id);
			return View(result);
		}

		[HttpGet]
		public IActionResult Delete(int id)
		{
			var movie = _movieRepository.GetById(id);
			return View(movie);
		}

		[HttpPost]
		public IActionResult Delete(Movie movie)
		{
			_movieRepository.Delete(movie);
			return RedirectToAction(nameof(Index));
		}
	}
}
