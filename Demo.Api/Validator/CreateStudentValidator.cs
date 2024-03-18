using Demo.Api.DTO.Requests;
using FastEndpoints;
using FluentValidation;

namespace Demo.Api.Validator;

public class CreateStudentValidator : Validator<CreateStudentRequest>
{
    public CreateStudentValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty")
            .MinimumLength(2).WithMessage("Length should be at leat 2 characters long");
        
    }
}