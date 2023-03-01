using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hr.LeaveManagement.Domain;
using HR.LeaveManagement.Domain;

namespace Hr.LeaveManagement.Application.Contracts.Persistence
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveRequestWithDetails();

        Task<List<LeaveRequest>> GetLeaveRequestWithDetails(string userId);

    }
}
