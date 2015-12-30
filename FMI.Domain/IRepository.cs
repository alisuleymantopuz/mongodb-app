using System.Collections.Generic;

namespace FMI.Domain
{
    public interface IRepository<T> where T : IEntity
    {
        void Create(T entity);

        void Delete(string id);

        T GetById(string id);

        IList<T> GetAll(); 

        void Update(T entity);
    }
}
