using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlatformService.Models;

namespace PlatformService.Data
{
	public class PlatformRepo : IPlatformRepo
	{
		private readonly AppDbContext _context;

		public PlatformRepo(AppDbContext context)
		{
			_context = context;
		}

		public void CreatePlatform(Models.Platform plat)
		{
			if (plat == null)
			{
				throw new ArgumentNullException(nameof(plat));
			}
			_context.Platforms.Add(plat);
		}

		public IEnumerable<Models.Platform> GetAllPlatforms()
		{
			return _context.Platforms.ToList();
		}

		public Models.Platform GetPlatformById(int id)
		{
			return _context.Platforms.FirstOrDefault(p => p.Id == id);
		}

		public bool SaveChanges()
		{
			return (_context.SaveChanges() >= 0);
		}
	}

}
