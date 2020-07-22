using AggregatorMicroservice.Models;
using System.Threading.Tasks;

namespace AggregatorMicroservice.Services
{
    public interface IAggregratorService
    {
        public Task<Aggregrator> GetUserAndOrderDetailsAsync(int userId);
    }
}
