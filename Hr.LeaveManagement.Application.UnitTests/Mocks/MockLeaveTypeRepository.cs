using Hr.LeaveManagement.Application.Contracts.Persistence;
using Hr.LeaveManagement.Domain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.UnitTests.Mocks
{
    public static class MockLeaveTypeRepository
    {
        public static Mock<ILeaveTypeRepository> GetLeaveTypes()
        {
            var leaveTypes = new List<LeaveType>
            {
                new LeaveType { Id=1, Name="Test1",DefaultDays=10},
                new LeaveType { Id=2, Name="Test2",DefaultDays=11},
                new LeaveType { Id=3, Name="Test3",DefaultDays=12},
                new LeaveType { Id=4, Name="Test4",DefaultDays=13}
            };
            var mockRepo = new Mock<ILeaveTypeRepository>();
            mockRepo.Setup(r=>r.GetAllAsync()).ReturnsAsync(leaveTypes);
            return mockRepo;
        }
    }
}
