using AutoMapper;
using Hr.LeaveManagement.Application.Features.LeaveType.Command.CreateLeaveType;
using Hr.LeaveManagement.Application.Features.LeaveType.Query.GetAllLeaveTypes;
using Hr.LeaveManagement.Application.Features.LeaveType.Query.GetLeaveTypeDetails;
using Hr.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.MappingProfiles
{
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDetailsDto>();
            CreateMap<CreateLeaveTypeCommand,LeaveType>();
        }
    }
}
