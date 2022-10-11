using ExamenTech.Application.Contracts;
using ExamenTech.Application.DTOs;
using ExamenTech.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamenTech.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChuckNorriseController : ControllerBase
    {

        private readonly ILogger<ChuckNorriseController> _logger;

        private readonly IChuckNorrisRepository _chuckNorrisRepository;

        public ChuckNorriseController(ILogger<ChuckNorriseController> logger, IChuckNorrisRepository chuckNorrisRepository)
        {
            _logger = logger;
            _chuckNorrisRepository = chuckNorrisRepository;
        }

        [HttpGet(Name = "Search")]
        public async Task<ActionResult> Get(string query)
        {

            var response = await _chuckNorrisRepository.SearchObject(query);

            var listNew = new List<ItemSearch>();

            int count = 1;
            foreach (var item in response.Result)
            {
                if (count > 25)
                {
                    break;
                }

                listNew.Add(item);

                count++;
            }

            response.Result = listNew;
            response.Total = listNew.Count;

            var responseAPi = new ApiResponse<CuckNorriseJokeResponse>() { Data = response, Status = "Success" };
            return Ok(responseAPi);
        }
    }
}