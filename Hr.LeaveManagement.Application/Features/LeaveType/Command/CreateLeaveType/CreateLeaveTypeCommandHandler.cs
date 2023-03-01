using AutoMapper;
using Hr.LeaveManagement.Application.Contracts.Logging;
using Hr.LeaveManagement.Application.Contracts.Persistence;
using Hr.LeaveManagement.Application.Exceptions;
using MediatR;

namespace Hr.LeaveManagement.Application.Features.LeaveType.Command.CreateLeaveType
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _ILeaveTypeRepository;
        private readonly IAppLogger<CreateLeaveTypeCommandHandler> _applogger;
        public CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository ILeaveTypeRepository, IAppLogger<CreateLeaveTypeCommandHandler> appLogger)
        {
            _mapper = mapper;
            _ILeaveTypeRepository = ILeaveTypeRepository;
            appLogger = _applogger;
        }
        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveTypeToCreate = _mapper.Map<Domain.LeaveType>(request);
            var validator = new CreateLeaveTypeCommandValidator(_ILeaveTypeRepository);
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Any())
            {
                _applogger.LogWarning("Validation Errors in the create request", nameof(LeaveType), request.Id);
                throw new BadRequestException("Invalid input", validationResult);
            }
            await _ILeaveTypeRepository.CreateAsync(leaveTypeToCreate);
            return leaveTypeToCreate.Id;
        }
    }
}
