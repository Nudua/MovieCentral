using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace MovieCentral.Shared.Utils;

/// <summary>
/// Provides utility methods to guard against common parameter validation errors such as null values or values that are out of range.
/// </summary>
public static class Guard
{
    /// <summary>
    /// Throws an <see cref="ArgumentNullException"/> if <paramref name="argument"/> is null.
    /// </summary>
    /// <typeparam name="T">The type of the <paramref name="argument"/>.</typeparam>
    /// <param name="argument">The reference type argument to validate.</param>
    /// <param name="paramName">The name of the <paramref name="argument"/>.</param>
    /// <returns>The non-null <paramref name="argument"/>.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static T ThrowIfNull<T>([NotNull] T argument, [CallerArgumentExpression("argument")] string paramName = null)
    {
        if (argument is null)
        {
            throw new ArgumentNullException(paramName);
        }

        return argument;
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> if <paramref name="argument"/> is empty or null.
    /// </summary>
    /// <param name="argument">The <see cref="string"/> argument to validate.</param>
    /// <param name="paramName">The name of the <paramref name="argument"/>.</param>
    /// <returns>The non-empty <see cref="string"/> argument.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static string ThrowIfEmpty([NotNull] string argument, [CallerArgumentExpression("argument")] string paramName = null)
    {
        if (string.IsNullOrEmpty(argument))
        {
            throw new ArgumentException(paramName);
        }

        return argument;
    }

    /// <summary>
    /// Throws an <see cref="ArgumentException"/> if <paramref name="argument"/> is equal to the default value of the struct.
    /// </summary>
    /// <typeparam name="T">The type of the <paramref name="argument"/>.</typeparam>
    /// <param name="argument">The <see cref="string"/> argument to validate.</param>
    /// <param name="paramName">The name of the <paramref name="argument"/>.</param>
    /// <exception cref="ArgumentException"></exception>
    public static void ThrowIfDefault<T>([NotNull] T argument, [CallerArgumentExpression("argument")] string paramName = null) where T : struct
    {
        if (argument.Equals(default))
        {
            throw new ArgumentException(paramName);
        }
    }

    public static void ThrowIfLessThan(int argument, int value, [CallerArgumentExpression("argument")] string paramName = null)
    {
        if (argument < value)
        {
            throw new ArgumentException($"Input {paramName} was out of range.", paramName);
        }
    }

    public static void ThrowIfZeroOrLess(int argument, [CallerArgumentExpression("argument")] string paramName = null)
    {
        if (argument <= 0)
        {
            throw new ArgumentException($"Input {paramName} was out of range.", paramName);
        }
    }
}
