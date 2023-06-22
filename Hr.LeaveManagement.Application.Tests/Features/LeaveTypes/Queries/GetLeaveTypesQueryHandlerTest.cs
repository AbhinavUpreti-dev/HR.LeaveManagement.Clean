using AutoMapper;
using FluentAssertions;
using Hr.LeaveManagement.Application.Contracts.Persistence;
using Hr.LeaveManagement.Application.Features.LeaveType.Query.GetAllLeaveTypes;
using Hr.LeaveManagement.Application.MappingProfiles;
using Hr.LeaveManagement.Application.Tests.Mocks;
using Hr.LeaveManagement.Domain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Tests.Features.LeaveTypes.Queries
{
    public class GetLeaveTypesQueryHandlerTest
    {
        private readonly Mock<ILeaveTypeRepository> _mockRepo;
        private readonly IMapper _mapper;

        public GetLeaveTypesQueryHandlerTest()
        {
            _mockRepo = MockLeaveTypeRepository.GetLeaveTypeRepository();
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<LeaveTypeProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]  
        public async Task GetLeaveTypeListTest()
        {
            var handler = new GetLeaveTypesQueryHandler(_mapper, _mockRepo.Object);

            var result = await handler.Handle(new GetLeaveTypesQuery(), CancellationToken.None);

            result.Should().BeOfType<List<LeaveTypeDto>>();
            result.Should().HaveCount(4);
        }
    }
}
