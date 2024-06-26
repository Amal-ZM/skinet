using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Specifications;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T: BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> GetEntityWithSpec(ISpecefication<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecefication<T> spec); 
         Task<int> CountAsync(ISpecefication<T> spec);
    }
}