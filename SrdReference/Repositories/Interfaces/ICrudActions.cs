using System.Linq;

namespace SrdReference.Repositories.Interfaces
{
    public interface ICrudActions<T> where T : class
    {
        IQueryable<T> GetAll();

        T GetById(int id);

        T Add(T entity);

        T Update(T entity);

        void Delete(T entity);

        void Delete(int id);
    }
}
