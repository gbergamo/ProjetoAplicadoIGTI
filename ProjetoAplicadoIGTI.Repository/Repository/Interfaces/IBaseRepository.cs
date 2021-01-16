using ProjetoAplicadoIGTI.Data.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoAplicadoIGTI.Repository.Repository.Interfaces
{
    public interface IBaseRepository
    {
        Task<IEnumerable<T>> GetAll<T>() where T : EntityBase;
        Task<T> GetById<T>(int Id) where T : EntityBase;
        Task<T> Insert<T>(T entity) where T : EntityBase;
        Task<bool> Delete(int Id);
        Task<T> Update<T>(T entity) where T : EntityBase;
    }
}
