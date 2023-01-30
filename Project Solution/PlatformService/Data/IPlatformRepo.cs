using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Data
{
	public interface IPlatformRepo
	{
		bool SaveChanges();
		IEnumerable<Models.Platform> GetAllPlatforms();
		Models.Platform GetPlatformById(int id);
		void CreatePlatform(Models.Platform plat);
	}
}
