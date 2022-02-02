using BookStore.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Utility.ModelsValidation
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(b => b.ISBN).NotEmpty();
            RuleFor(b => b.Author).NotEmpty();
            RuleFor(b => b.CategoryId).NotEmpty().WithMessage("'Category' must not be empty.");
            RuleFor(b => b.Description).NotEmpty();
            RuleFor(b => b.Edition).NotEmpty();
            RuleFor(b => b.ISBN).NotEmpty();
            RuleFor(b => b.Title).NotEmpty();
            RuleFor(b => b.PublicationYear).NotEmpty().GreaterThan(0);
            RuleFor(b => b.Price).NotEmpty().WithMessage("'Price' must be greater than {PropertyValue}.");
            RuleFor(b => b.Publisher).NotEmpty();
            RuleFor(b => b.Quantity).NotEmpty().GreaterThan(0);
            RuleFor(b => b.Status).NotEmpty();
        }
    }
}
