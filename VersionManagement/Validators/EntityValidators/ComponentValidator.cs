using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Validators.EntityValidators
{
    public class ComponentValidator : AbstractValidator<Models.Component>
    {
        public ComponentValidator()
        {
            RuleFor(x => x.ModifiedDate).GreaterThanOrEqualTo(x => x.CreatedDate);
            RuleFor(x => x.Name).Length(1, 40);
            RuleFor(x => x.Type).Length(1, 40);
        }
    }
}
