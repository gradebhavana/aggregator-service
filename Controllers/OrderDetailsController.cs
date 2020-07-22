
using AggregatorMicroservice.Models;
using AggregatorMicroservice.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AggregatorMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IAggregratorService _aggregratorService;

        public OrderDetailsController(IAggregratorService aggregratorService)
        {
            _aggregratorService = aggregratorService;
        }

        [HttpGet("{id:int}")]
        public async Task<Aggregrator> GetAsync(int id)
        {
            return await _aggregratorService.GetUserAndOrderDetailsAsync(id);
        }
    }
}