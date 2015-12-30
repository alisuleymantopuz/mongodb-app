using FMI.Domain.EventAggregate;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FMI.Web.Api.Application.Controllers.Api
{
    public class EventLogController : ApiController
    {
        public ILoggingManager LoggingManager { get; private set; }

        public EventLogController(ILoggingManager loggingManager)
        {
            LoggingManager = loggingManager;
        }

        public IEnumerable<EventLog> Get()
        {
            this.LoggingManager.CreateEventLog(new EventLog()
            {
                CreationTime = DateTime.Now,
                EventLogType = EventLogType.ListOperation,
                IsActive = true,
                IsDeleted = false,
                Message = UIResources.GetEventLogMessage001,
                UserInformation = 0
            });

            return this.LoggingManager.GetAllEventLogs();
        }


    }
}