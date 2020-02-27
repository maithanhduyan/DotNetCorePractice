using DatabaseConnectionPool.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabaseConnectionPool.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T item);
        void Remove(int id);
        void Update(T item);
        T FindByID(int id);
        Task<IEnumerable<T>> FindAll();
    }
}
