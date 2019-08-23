using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.DTOs;

namespace VersionManagement.Validators
{
    public class LiteComponentDTOValidator : AbstractValidator<LiteComponentDTO>
    {
        public LiteComponentDTOValidator()
        {
            RuleFor(x => x.ModifiedDate).GreaterThanOrEqualTo(x => x.CreatedDate);
            RuleFor(x => x.Name).Length(1, 40);
            RuleFor(x => x.Type).Length(1, 40);
        }
    }
    public class ComponentDTOValidator : LiteComponentDTOValidator
    {
        public ComponentDTOValidator() : base() { }
    }
    class DetailedComponentDTOValidator : ComponentDTOValidator
    {
        public DetailedComponentDTOValidator() : base() { }
    }
}
