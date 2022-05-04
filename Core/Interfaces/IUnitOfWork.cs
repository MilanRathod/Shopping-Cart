using System;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Interfaces;

namespace Core.Entities.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity:BaseEntities;
        Task<int> Complete();
    }   
}