using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VideoRentDemoApp.Models;
using VideoRentDemoApp.Repos;

namespace VideoRentDemoApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly MovieRepository _movieRepository;

		public HomeController(MovieRepository movieRepository)
		{
			_movieRepository = movieRepository;
		}

		//public IActionResult Index()
		//{
		//	var movies = _movieRepository.GetList();
		//	return View(movies);
		//}
		public ViewResult Index(string searchString)
		{
			var movies = _movieRepository.GetList();
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
	}
}
