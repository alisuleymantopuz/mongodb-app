using MongoDB.Driver;

namespace FMI.Domain.Repositories.Factory
{
    public class MongoConnectionHandler<T> where T : IEntity
    {
        public MongoCollection<T> MongoCollection { get; private set; }

        public MongoConnectionHandler()
        {
            string connectionString = DomainConfiguration.LocalMongoDbConnectionString;

            var mongoClient = new MongoClient(connectionString);

            var mongoServer = mongoClient.GetServer();

            const string databaseName = "<db_name>";

            var db = mongoServer.GetDatabase(databaseName);

            MongoCollection = db.GetCollection<T>(typeof(T).Name.ToLower() + "s");
        }
    }
}
