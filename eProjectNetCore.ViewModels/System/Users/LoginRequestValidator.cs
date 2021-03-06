﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eProjectNetCore.ViewModels.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required").
                MaximumLength(6).WithMessage("Password is at least 6 characters");
        }
    }
}