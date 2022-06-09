using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using VideoRentDemoApp.Data;
using VideoRentDemoApp.Interface;
using VideoRentDemoApp.Models;

namespace VideoRentDemoApp.Repos
{
	public class RenterRepository : IRepository<Renter>
	{
		private readonly ApplicationDbContext _context;
		public RenterRepository(ApplicationDbContext context)
		{
			_context = context;
		}
		public void Create(Renter renter)
		{
			_context.Renters.Add(renter);
			_context.SaveChanges();
		}

		public void Delete(Renter renter)
		{
			_context.Renters.Remove(renter);
			_context.SaveChanges();
		}

		public Renter GetById(int id)
		{
			var renter = _context.Renters
				.FirstOrDefault(m => m.RenterId == id);
			return renter;
		}

		public IEnumerable<Renter> GetList()
		{
			var renters = _context.Renters.ToList();
			return renters;
		}

		public void Update(Renter renter)
		{
			_context.Renters.Update(renter);
			_context.SaveChanges();
		}
	}
}
