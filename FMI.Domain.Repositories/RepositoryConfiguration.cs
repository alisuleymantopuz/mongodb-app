using System;
using System.Configuration;

namespace FMI.Domain.Repositories
{
    public class RepositoryConfiguration
    {
        public static string LocalMongoDbConnectionString
        {
            get
            {
                if (ConfigurationManager.AppSettings["LocalMongoDBConnectionString"] == null)
                {
                    throw new Exception("LocalMongoDBConnectionString can not be null!");
                }

                return ConfigurationManager.AppSettings["LocalMongoDBConnectionString"].ToString();
            }
        }
    }
}
