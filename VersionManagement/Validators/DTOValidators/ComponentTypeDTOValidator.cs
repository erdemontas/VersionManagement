﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.DTOs;

namespace VersionManagement.Validators
{
    public class ComponentTypeDTOValidator : AbstractValidator<ComponentTypeDTO>
    {
        public ComponentTypeDTOValidator()
        {
            RuleFor(x => x.ModifiedDate).GreaterThanOrEqualTo(x => x.CreatedDate);
            RuleFor(x => x.Name).Length(1, 40);
            RuleFor(x => x.Description).Length(1, 600);
        }
    }
}
