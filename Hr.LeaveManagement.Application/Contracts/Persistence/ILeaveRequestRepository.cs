using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hr.LeaveManagement.Domain;
using HR.LeaveManagement.Domain;

namespace Hr.LeaveManagement.Application.Contracts.Persistence
{
    internal interface ILeaveRequestRepository : IGenericRepositor<LeaveRequest>
    {
    }
}
