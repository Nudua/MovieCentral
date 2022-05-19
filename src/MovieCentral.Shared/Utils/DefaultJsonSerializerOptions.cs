using System.Text.Json;
using System.Text.Json.Serialization;

namespace MovieCentral.Shared.Utils;

public static class DefaultJsonSerializerOptions
{
    private static JsonSerializerOptions _instance;
    public static JsonSerializerOptions Instance => _instance ??= CreateDefaultOptions();

    private static JsonSerializerOptions CreateDefaultOptions()
    {
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        options.Converters.Add(new JsonStringEnumConverter());
        return options;
    }
}
