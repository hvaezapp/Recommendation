namespace Recommendation.Infrastructure.Consumers.IntegrationEvents;

public record GetUserActionHistoryEvent(Guid userId);
