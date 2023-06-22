
using Hr.LeaveManagement.Application.Contracts.Persistence;
using Hr.LeaveManagement.Domain;
using HR.LeaveManagement.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        public LeaveAllocationRepository(HrDatabaseContext context) : base(context)
        {
        }

        public Task AddAllocations(List<LeaveAllocation> allocations)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AllocationExists(string userId, int leaveTypeId, int period)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails()
        {
            throw new NotImplementedException();
        }

        public Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveAllocation> GetUserAllocation(string userId, int leaveTypeId)
        {
            throw new NotImplementedException();
        }
    }
}