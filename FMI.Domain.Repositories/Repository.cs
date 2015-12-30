using FMI.Domain.Repositories.Factory;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Collections.Generic;
using System.Linq;

namespace FMI.Domain.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : IEntity
    {
        protected readonly MongoConnectionHandler<T> MongoConnectionHandler;

        protected Repository()
        {
            MongoConnectionHandler = new MongoConnectionHandler<T>();
        }

        public virtual void Create(T entity)
        {
            //// Save the entity with safe mode (WriteConcern.Acknowledged)
            var result = this.MongoConnectionHandler.MongoCollection.Save(
                entity,
                new MongoInsertOptions
                {
                    WriteConcern = WriteConcern.Acknowledged
                });

            if (result.HasLastErrorMessage)
            {
                //// Something went wrong
            }
        }

        public virtual void Delete(string id)
        {
            var result = this.MongoConnectionHandler.MongoCollection.Remove(
                Query<T>.EQ(e => e.Id,
                new ObjectId(id)),
                RemoveFlags.None,
                WriteConcern.Acknowledged);

            if (result.HasLastErrorMessage)
            {
                //// Something went wrong
            }
        }

        public virtual T GetById(string id)
        {
            var entityQuery = Query<T>.EQ(e => e.Id, new ObjectId(id));
            return this.MongoConnectionHandler.MongoCollection.FindOne(entityQuery);
        }

        public abstract void Update(T entity);

        public virtual IList<T> GetAll()
        {
            return this.MongoConnectionHandler.MongoCollection.FindAll().ToList();
        }
    }
}
