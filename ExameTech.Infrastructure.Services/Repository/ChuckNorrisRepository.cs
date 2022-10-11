using ExamenTech.Application.Contracts;
using ExamenTech.Application.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTech.Infrastructure.Services.Repository
{
    public class ChuckNorrisRepository : IChuckNorrisRepository
    {
        private readonly ServiceChuckNorrisSettings _serviceChuckNorrisSettings;

        public ChuckNorrisRepository(IOptions<ServiceChuckNorrisSettings> serviceChuckNorrisSettings)
        {
            _serviceChuckNorrisSettings = serviceChuckNorrisSettings.Value;
        }


        public async Task<CuckNorriseJokeResponse> SearchObject(string query)
        {
            try
            {
                using (var client = new HttpClient())
                {
                
                    var responseContent = await client.GetFromJsonAsync<CuckNorriseJokeResponse>($"https://api.chucknorris.io/jokes/search?query={query}");


                    return responseContent ?? new CuckNorriseJokeResponse();
                }
            }
            catch (Exception ex)
            {

                return new CuckNorriseJokeResponse();
            }
        }
    }
}
