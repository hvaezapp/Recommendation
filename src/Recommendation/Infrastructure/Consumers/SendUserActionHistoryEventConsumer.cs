using MassTransit;
using UserAction.Infrastructure.Consumers.IntegrationEvents;

namespace Recommendation.Infrastructure.Consumers
{
    public class SendUserActionHistoryEventConsumer : IConsumer<SendUserActionHistoryEvent>
    {
        public async Task Consume(ConsumeContext<SendUserActionHistoryEvent> context)
        {
           

            throw new NotImplementedException();
        }
    }
}
