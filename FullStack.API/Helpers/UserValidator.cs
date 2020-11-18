using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullStack.ViewModels;
using FullStack.Data;

namespace FullStack.API.Helpers
{
    public class UserValidator: AbstractValidator<RegisterModel>
    {
        public UserValidator()
        {
            RuleFor(user => user.Surname).NotEmpty().MinimumLength(3).MaximumLength(100);
            RuleFor(user => user.Forenames).NotEmpty().MinimumLength(1).MaximumLength(100);
            RuleFor(user => user.Email).NotEmpty().EmailAddress().MinimumLength(6).MaximumLength(100);
            RuleFor(user => user.Password).NotEmpty().MinimumLength(8).MaximumLength(100);
            //RuleFor(user => user.Email).Equal()
        }
    }
}