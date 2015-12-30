using FMI.Domain.EventAggregate;
using System;
using System.Linq;

namespace FMI.Domain.Validators
{
    public class LoggingValidator : ILoggingValidator
    {
        public void ValidateLogAddition(EventLog eventLog)
        {
            var eventLogValidator = new EventLogValidator();
            eventLogValidator.SetupEventLogCreateRules();

            var validationResult = eventLogValidator.Validate(eventLog);

            if (!validationResult.IsValid && validationResult.Errors.Count >= 0)
            {
                throw new Exception(validationResult.Errors.First().ErrorMessage);
            }
        }
    }
}
