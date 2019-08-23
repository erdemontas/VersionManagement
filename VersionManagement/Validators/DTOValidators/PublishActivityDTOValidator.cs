using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.DTOs;

namespace VersionManagement.Validators
{
    public class PublishActivityDTOValidator : AbstractValidator<PublishActivityDTO>
    {
        public PublishActivityDTOValidator()
        {
            RuleFor(x => x.ModifiedDate).GreaterThanOrEqualTo(x => x.CreatedDate);
        }
    }
}
