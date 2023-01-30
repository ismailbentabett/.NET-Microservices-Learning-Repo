using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PlatformService.Profiles
{
	public class PlatformsProfile : AutoMapper.Profile
	{

		public PlatformsProfile()
		{
			// Source -> Target
			CreateMap<Models.Platform, Dtos.PlatformReadDto>();
			CreateMap<Dtos.PlatformCreateDto, Models.Platform>();
		}

	}
}
