using Hr.LeaveManagement.Domain;

namespace Hr.LeaveManagement.Application.Contracts.Persistence
{
    public interface ILeaveTypeRepository : IGenericRepositor<LeaveType>
    {
        public Task<bool> IsLeaveTypeUnique(string name);
    }
}
