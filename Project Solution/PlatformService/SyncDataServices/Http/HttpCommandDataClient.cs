using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlatformService.Dtos;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using Microsoft.Extensions.Configuration;
namespace PlatformService.SyncDataServices.Http
{
	public class HttpCommandDataClient : ICommandDataClient
	{

		private readonly HttpClient _httpClient;
		private readonly IConfiguration _configiration;
		public HttpCommandDataClient(HttpClient httpClient, IConfiguration configiration)
		{
			_httpClient = httpClient;
			_configiration = configiration;

		}

		public async Task SendPlatformToCommand(PlatformReadDto plat)
		{
			var httpContent = new StringContent(
				JsonSerializer.Serialize(plat),
				Encoding.UTF8,
				"application/json"
			);

			var response = await _httpClient.PostAsync($"{_configiration["CommandService"]}", httpContent);

			if (response.IsSuccessStatusCode)
			{
				Console.WriteLine("--> Sync POST to Command Service was OK!");
			}
			else
			{
				Console.WriteLine("--> Sync POST to Command Service was NOT OK!");
			}
		}

	}
}
