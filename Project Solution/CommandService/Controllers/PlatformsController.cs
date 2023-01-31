using System;
using System.Collections.Generic;
using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using PlatformService.Data;
using PlatformService.Dtos;


namespace CommandsService.Controllers
{
	[Route("api/c/[controller]")]
	[ApiController]
	public class PlatformsController : ControllerBase
	{
		private readonly IPlatformRepo _repository;
		private readonly IMapper _mapper;

		public PlatformsController(IPlatformRepo repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		[HttpGet]
		public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
		{
			Console.WriteLine("--> Getting Platforms from CommandsService");

			var platformItems = _repository.GetAllPlatforms();

			return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(platformItems));
		}

		[HttpPost]
		public ActionResult TestInboundConnection()
		{
			Console.WriteLine("--> Inbound POST # Command Service");

			return Ok("Inbound test of from Platforms Controler");
		}
	}
}
