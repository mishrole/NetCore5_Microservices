using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
    public class CommandDataClient : ICommandDataClient
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

    public CommandDataClient(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task SendPlatformToCommand(PlatformReadDto platformReadDto)
        {
            // Payload
            var httpContent = new StringContent(
                JsonSerializer.Serialize(platformReadDto),
                Encoding.UTF8,
                "application/json"
            );

            // Request
            var response = await _httpClient.PostAsync(
                $"{_configuration["CommandService"]}",
                httpContent
            );

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Sync POST to CommandService successful");
            }
            else 
            {
                Console.WriteLine("Sync POST to CommandService failed");
            }
        }
    }
}