using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.DTOs;

namespace VersionManagement.Validators
{
    public class LiteVersionDTOValidator : AbstractValidator<LiteVersionDTO>
    {
        public LiteVersionDTOValidator()
        {
            RuleFor(x => x.ModifiedDate).GreaterThanOrEqualTo(x => x.CreatedDate);
            RuleFor(x => x.Comment).Length(1, 600);
            RuleFor(x => x.ReleaseNumber).Length(1, 40);
        }
    }
    class VersionDTOValidator : LiteVersionDTOValidator
    {
        public VersionDTOValidator() : base()
        {

        }
    }
}
