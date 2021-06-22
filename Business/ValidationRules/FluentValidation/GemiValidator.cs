using FluentValidation;

public class GemiValidator:AbstractValidator<Gemiler>
{
    public GemiValidator()
    {
        RuleFor(p => p.IMONo).NotEmpty();
        
        
    }

    
}