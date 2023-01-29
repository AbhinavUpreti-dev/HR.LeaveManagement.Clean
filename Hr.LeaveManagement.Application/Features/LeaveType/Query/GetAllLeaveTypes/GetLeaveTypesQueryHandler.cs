using AutoMapper;
using Hr.LeaveManagement.Application.Contracts.Persistence;
using Hr.LeaveManagement.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Features.LeaveType.Query.GetAllLeaveTypes
{
    public class GetLeaveTypesQueryHandler : IRequestHandler<GetLeaveTypesQuery, List<LeaveTypeDto>>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _ILeaveTypeRepository;
        public GetLeaveTypesQueryHandler(IMapper mapper, ILeaveTypeRepository ILeaveTypeRepository)
        {
            _mapper = mapper;
            _ILeaveTypeRepository = ILeaveTypeRepository;
        }
        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypesQuery request, CancellationToken cancellationToken)
        {
            var leaveTypes = await _ILeaveTypeRepository.GetAllAsync();
            var leaveTypesDto =  _mapper.Map<List<LeaveTypeDto>>(leaveTypes);
            return leaveTypesDto;
        }
    }
}
