using Recommendation.Dtos;

namespace Recommendation.Handlers;

public interface IRedisHandler
{
    Task<IEnumerable<GetUserActionHistoryDto>> GetUserActionHistory(string userId);
}
