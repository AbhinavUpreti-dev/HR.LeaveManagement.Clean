using AutoMapper;
using Hr.LeaveManagement.Application.Contracts.Persistence;
using Hr.LeaveManagement.Application.Features.LeaveType.Query.GetAllLeaveTypes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Features.LeaveType.Query.GetLeaveTypeDetails
{   
    internal class GetLeaveTypeDetailsQueryHandler : IRequestHandler<GetLeaveTypeDetailsQuery, List<LeaveTypeDetailsDto>>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _ILeaveTypeRepository;
        public GetLeaveTypeDetailsQueryHandler(IMapper mapper, ILeaveTypeRepository ILeaveTypeRepository)
        {
            _mapper = mapper;
            _ILeaveTypeRepository = ILeaveTypeRepository;
        }
        public async Task<List<LeaveTypeDetailsDto>> Handle(GetLeaveTypeDetailsQuery request, CancellationToken cancellationToken)
        {
            var leaveTypes = await _ILeaveTypeRepository.GetByIdAsync(request.id);
            var leaveTypesDto = _mapper.Map<List<LeaveTypeDetailsDto>>(leaveTypes);
            return leaveTypesDto;
        }
    }
}
