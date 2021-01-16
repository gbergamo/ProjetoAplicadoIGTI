using ProjetoAplicadoIGTI.Data.Entity;
using ProjetoAplicadoIGTI.Repository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoAplicadoIGTI.Repository.Repository.Implementation
{
    public class ClientRepository : IClientRepository
    {
        public Task<bool> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll<T>() where T : EntityBase
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById<T>(int Id) where T : EntityBase
        {
            throw new NotImplementedException();
        }

        public Task<T> Insert<T>(T entity) where T : EntityBase
        {
            throw new NotImplementedException();
        }

        public Task<T> Update<T>(T entity) where T : EntityBase
        {
            throw new NotImplementedException();
        }
    }
}
