using FluentValidation;
using MovieCentral.Shared.Dtos.Parameters;

namespace MovieCentral.Application.Validators;

public class PagedMovieListValidator : AbstractValidator<PagedMovieListParameters>
{
    public PagedMovieListValidator()
    {
        RuleFor(x => x.PageNumber)
            .GreaterThan(0)
            .WithMessage("The page number must be greater than zero.");

        RuleFor(x => x.PageSize)
            .InclusiveBetween(1, 20)
            .WithMessage("Page size must be between 1 and 20.");
    }
}
