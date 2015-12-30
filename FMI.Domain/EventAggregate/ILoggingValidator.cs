
namespace FMI.Domain.EventAggregate
{
    public interface ILoggingValidator
    {
        void ValidateLogAddition(EventLog eventLog);
    }
}
