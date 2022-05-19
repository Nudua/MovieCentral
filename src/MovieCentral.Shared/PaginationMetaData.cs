using System.Text.Json;
using System.Text.Json.Serialization;

namespace MovieCentral.Shared;

public record PaginationMetaData(int TotalCount, int PageSize, int CurrentPage, int TotalPages)
{
    public string ToJson() => JsonSerializer.Serialize(this);

    [JsonIgnore]
    public bool HasPrevious => CurrentPage > 1;

    [JsonIgnore]
    public bool HasNext => CurrentPage < TotalPages;
}
