using FluentValidation;
using FMI.Domain.EventAggregate;
using FMI.Exceptions;

namespace FMI.Domain.Validators
{
    public class EventLogValidator : AbstractValidator<EventLog>
    {
        public void SetupEventLogCreateRules()
        {
            this.RuleFor(x => x.Message)
                .NotNull()
                .WithMessage(((int)BusinessExceptionCodes.InvalidLogData).ToString());

            this.RuleFor(x => x.EventLogType)
               .NotNull()
               .WithMessage(((int)BusinessExceptionCodes.InvalidLogData).ToString());

        }
    }
}
