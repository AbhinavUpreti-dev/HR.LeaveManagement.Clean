using Hr.LeaveManagement.Application.Contracts.Persistence;
using Hr.LeaveManagement.Domain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Tests.Mocks
{
    public static class MockLeaveTypeRepository
    {
        public static Mock<ILeaveTypeRepository> GetLeaveTypeRepository()
        {
            var leaveTypes = new List<LeaveType>
            {
                new LeaveType{Id=1,Name="test1",DefaultDays=20},
                new LeaveType{Id=2,Name="test2",DefaultDays=20},
                new LeaveType{Id=3,Name="test3",DefaultDays=20},
                new LeaveType{Id=4,Name="test4",DefaultDays=20}
            };
            var mockRepository = new Mock<ILeaveTypeRepository>();
            mockRepository.Setup(r => r.GetAllAsync()).ReturnsAsync(leaveTypes);
            return mockRepository;
        }
    }
}
