using BookStore.Models.Models;
using FluentValidation;

namespace BookStore.Validators
{
    public class AddBookRequestValidator : AbstractValidator<Book>
    {
        public AddBookRequestValidator()
        {
            RuleFor(x => x.AuthorId)
                .NotEmpty()
             ;

            RuleFor(x => x.Title)
                .NotEmpty();

            RuleFor(x => x.Title.Length)
                .GreaterThan(5).WithMessage("Book title must have at least 5 chars")
                .LessThan(20).WithMessage("Book title has to have less than 20 chars");

           
        }
    }
}
