using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FMI.Domain.EventAggregate
{
    public class EventLog : Entity
    {
        public string Message { get; set; }

        [BsonRepresentation(BsonType.String)]
        public EventLogType EventLogType { get; set; }
    }
}
