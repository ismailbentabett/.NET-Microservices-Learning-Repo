using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers
{
	[ApiController]
	[Route("api/c/[controller]")]
	public class PlatformsController : ControllerBase
	{
		public PlatformsController()
		{
		}

		[HttpGet]
		public ActionResult<IEnumerable<string>> GetPlatforms()
		{
			return new string[] { "DotNet", "SQL Server", "Kubernetes" };
		}

		[HttpPost]
		public ActionResult testInboundConnection()
		{
			Console.WriteLine("--> Inbound POST # Command Service");
			return Ok("Inbound test of from Platforms Controller");
		}

	}
}
