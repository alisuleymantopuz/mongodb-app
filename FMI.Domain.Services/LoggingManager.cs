using FMI.Domain.EventAggregate;
using FMI.Domain.Repositories;
using System.Collections.Generic;

namespace FMI.Domain.Services
{
    public class LoggingManager : ILoggingManager
    {
        public ILoggingValidator LoggingValidator { get; private set; }

        public EventLogRepository EventLogRepository { get; private set; }

        public LoggingManager(ILoggingValidator loggingValidator, EventLogRepository eventLogRepository)
        {
            EventLogRepository = eventLogRepository;
            LoggingValidator = loggingValidator;
        }

        public void CreateEventLog(EventLog eventLog)
        {
            this.LoggingValidator.ValidateLogAddition(eventLog);

            this.EventLogRepository.Create(eventLog);
        }

        public IList<EventLog> GetAllEventLogs()
        {
            return this.EventLogRepository.GetAll();
        }
    }
}
