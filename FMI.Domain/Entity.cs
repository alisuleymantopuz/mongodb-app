using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace FMI.Domain
{
    public class Entity : IEntity
    {
        [BsonRepresentation(BsonType.String)]
        public ObjectId Id { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int UserInformation { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }
    }
}
