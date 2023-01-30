using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Data;
using PlatformService.Profiles;
using PlatformService.Dtos;


namespace PlatformService.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class PlatformsController : ControllerBase
	{
		private readonly IPlatformRepo _repository;

		private readonly AutoMapper.IMapper _mapper;

		public PlatformsController(IPlatformRepo repo, AutoMapper.IMapper mapper)
		{
			_repository = repo;
			_mapper = mapper;
		}

		[HttpGet]
		public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
		{
			Console.WriteLine("--> Getting Platforms...");

			var platformItems = _repository.GetAllPlatforms();

			return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(platformItems));
		}

		[HttpGet("{id}", Name = "GetPlatformById")]
		public ActionResult<PlatformReadDto> GetPlatformById(int id)
		{
			var platformItem = _repository.GetPlatformById(id);
			if (platformItem != null)
			{
				return Ok(_mapper.Map<PlatformReadDto>(platformItem));
			}
			return NotFound();
		}

		[HttpPost]
		public ActionResult<PlatformReadDto> CreatePlatform(PlatformCreateDto platformCreateDto)
		{
			var platformModel = _mapper.Map<Models.Platform>(platformCreateDto);
			_repository.CreatePlatform(platformModel);
			_repository.SaveChanges();

			var platformReadDto = _mapper.Map<PlatformReadDto>(platformModel);

			return CreatedAtRoute(nameof(GetPlatformById), new { Id = platformReadDto.Id }, platformReadDto);
		}

	}
}
