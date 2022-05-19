using System.Text.RegularExpressions;
using FluentValidation;
using MovieCentral.Shared.Dtos.User;

namespace MovieCentral.Application.Validators;

public class UserNickNameForUpdateValidator : AbstractValidator<UserNickNameForUpdateDto>
{
    public UserNickNameForUpdateValidator()
    {
        RuleFor(x => x.NewNickName)
            .NotEmpty()
            .Matches("^\\w+$", RegexOptions.Compiled)
            .WithMessage("Your NickName may only contain the characters A to Z (case-insensitive) or numbers. The maximum length is 20.");
    }
}
