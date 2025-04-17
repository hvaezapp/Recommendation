namespace UserAction.Infrastructure.Consumers.IntegrationEvents;

public record SendUserActionHistoryEvent(IEnumerable<GetUserActionHistoryDto> userActionHistories);

public class GetUserActionHistoryDto
{
    public Guid UserId { get; set; }
    public string? CatalogSlug { get; set; }
    public string? CategoryName { get; set; }
    public ActionType ActionType { get; set; }
}

public enum ActionType
{
    Like,
    View,
    Bookmark,
    Comment
}