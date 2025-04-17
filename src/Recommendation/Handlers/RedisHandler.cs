using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using Recommendation.Dtos;

namespace Recommendation.Handlers
{
    public class RedisHandler : IRedisHandler
    {
        private readonly IDistributedCache _redisCache;

        public RedisHandler(IDistributedCache redisCache)
        {
            _redisCache = redisCache;
        }

        public async Task<IEnumerable<GetUserActionHistoryDto>> GetUserActionHistory(string userId)
        {
            var userActionHistory = await _redisCache.GetStringAsync(userId);

            if (string.IsNullOrEmpty(userActionHistory))
                return Enumerable.Empty<GetUserActionHistoryDto>();

            return JsonConvert.DeserializeObject<IEnumerable<GetUserActionHistoryDto>>(userActionHistory);
        }

      
    }

}
