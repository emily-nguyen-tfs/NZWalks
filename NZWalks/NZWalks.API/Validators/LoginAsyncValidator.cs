using FluentValidation;

namespace NZWalks.API.Validators
{
    public class LoginAsyncValidator : AbstractValidator<Models.DTO.LoginRequest>
    {
        public LoginAsyncValidator()
        {
            RuleFor(x => x.Username).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}
