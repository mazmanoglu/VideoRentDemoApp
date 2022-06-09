using Microsoft.AspNetCore.Mvc;
using VideoRentDemoApp.Repos;

namespace VideoRentDemoApp.ViewComponents
{
	public class RenterMenuViewComponent : ViewComponent
	{
		private readonly RenterRepository _renterRepository;
		public RenterMenuViewComponent(RenterRepository renterRepository)
		{
			_renterRepository = renterRepository;
		}
		public IViewComponentResult Invoke()
		{
			if (RouteData.Values["action"].ToString() == "Index")
			{
				ViewBag.SelectedRenter = RouteData?.Values["id"];
			}
			var result = _renterRepository.GetList();
			return View(result);

		}
	}
}

// {controller}/{action}/{id?}
// /home/index/3
// /movie/index/3

// RouteData.Values["controller"] ==> Controller/Movie
// RouteData.Values["action"] ==> Action/Index
// RouteData.Values["id"] ==> Id/3

// Movie/Index sayfasina girdigimizde basta id girili olmadigi icin, yani herhangi bir renter secmedigimiz icin 
// routedata herhangi bir id degeri almamis olacak. bu hatayi gidermek icin de routedata'nin sonuna '?' ekliyoruz

// viewbag = gecici alan
