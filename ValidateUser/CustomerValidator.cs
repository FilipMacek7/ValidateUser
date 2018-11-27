using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;


namespace ValidateUser
{
    public class CustomerValidator : AbstractValidator<CustomerBuilder>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.Surname)
                .NotEmpty()
                .WithMessage("Surname can't be empty");

            RuleFor(customer => customer.Forename)
                .NotEmpty()
                .WithMessage("Forename can't be empty");
            RuleFor(customer => customer.BirthDate)
                .NotNull()
                 .NotEqual(DateTime.Now);
        }

    }
}
