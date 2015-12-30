using MongoDB.Bson;
using System;

namespace FMI.Domain
{
    public interface IEntity
    {
        ObjectId Id { get; set; }

        DateTime CreationTime { get; set; }

        DateTime LastUpdateTime { get; set; }

        int UserInformation { get; set; }

        bool IsActive { get; set; }

        bool IsDeleted { get; set; }
    }
}
