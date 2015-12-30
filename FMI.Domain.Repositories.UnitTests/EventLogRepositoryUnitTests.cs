using FMI.Domain.EventAggregate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;
using System;

namespace FMI.Domain.Repositories.UnitTests
{
    [TestClass]
    public class EventLogRepositoryUnitTests
    {

        public EventLogRepository EventLogRepository { get; set; }

        [TestInitialize]
        public void Init()
        {
            this.EventLogRepository = new EventLogRepository();
        }

        [TestMethod]
        public void EventLogRepository_Should_Create_A_EventLog_Data_Success()
        {
            EventLog eventLog = new EventLog();
            eventLog.Id = ObjectId.GenerateNewId();
            eventLog.CreationTime = DateTime.Now;
            eventLog.EventLogType = EventLogType.SaveOperation;
            eventLog.IsActive = true;
            eventLog.IsDeleted = false;
            eventLog.Message = "A test record was created..";
            eventLog.UserInformation = 0;

            this.EventLogRepository.Create(eventLog);

        }

        [TestMethod]
        public void EventLogRepository_Should_List_All_EventLog_Data_Success()
        {
            var items = this.EventLogRepository.GetAll();
        }

    }
}
