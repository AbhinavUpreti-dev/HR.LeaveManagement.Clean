using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Contracts.Persistence
{
    public interface IGenericRepositor<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
    }
}
