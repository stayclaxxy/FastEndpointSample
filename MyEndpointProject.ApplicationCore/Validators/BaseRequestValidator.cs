using FastEndpoints;
using FluentValidation;
using MyEndpointProject.ApplicationCore.Models.Request;

namespace MyEndpointProject.ApplicationCore.Validators;

public class BaseRequestValidator : Validator<BaseRequest>
{
    public BaseRequestValidator()
    {
        RuleFor(x => x.Skip)
            .NotEmpty()
            .When(x => x.Take > 0);
        
        RuleFor(x => x.Take)
            .NotEmpty()
            .When(x => x.Skip > 0);
    }
}