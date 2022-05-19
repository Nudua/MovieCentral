using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MovieCentral.Shared.Utils;

public static class EnumExtensions
{
    /// <summary>
    /// If the enum value has a <see cref="DisplayAttribute"/> then the Name value of the attribute is returned.
    /// If it does not have a <see cref="DisplayAttribute"/> then the string literal is returned.
    /// </summary>
    /// <param name="value">The <see cref="Enum"/> constant value to get the display name of.</param>
    /// <returns>The display name of the enum value.</returns>
    public static string GetDisplayName(this Enum value)
    {
        var displayName = value.GetType()
                               .GetMember(value.ToString())
                               .FirstOrDefault()?.GetCustomAttribute<DisplayAttribute>()?.Name;

        return displayName ?? value.ToString();
    }
}
