using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Dtos
{
	public class PlatformCreateDto
	{
		public string Name { get; set; }
		public string Publisher { get; set; }
		public string Cost { get; set; }
	}
}
