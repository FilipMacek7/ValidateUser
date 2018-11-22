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
                .NotNull()
                .NotEqual("foo");

            RuleFor(customer => customer.Forename)
                 .NotNull()
                 .NotEqual("foo");
            RuleFor(customer => customer.BirthYear)
                 .NotNull()
                 .LessThan(2018);
        }

    }
}
