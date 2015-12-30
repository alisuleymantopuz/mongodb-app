using System.Collections.Generic;

namespace FMI.Domain.EventAggregate
{
    public interface ILoggingManager
    {
        void CreateEventLog(EventLog eventLog);

        IList<EventLog> GetAllEventLogs();
    }
}
