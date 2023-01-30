using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace PlatformService.Models
{
	public class Platform
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "Name is required")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Publisher is required")]
		public string Publisher { get; set; }
		[Required(ErrorMessage = "Cost is required")]
		public string Cost { get; set; }
	}
}
