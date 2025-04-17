namespace Recommendation.Dtos;

public class GetUserActionHistoryDto
{
    public string? CatalogSlug { get; set; }
    public string? CategoryName { get; set; }
    public ActionType ActionType { get; set; }
}

#region enums
public enum ActionType
{
    Like,
    View,
    Bookmark,
    Comment
}
#endregion
