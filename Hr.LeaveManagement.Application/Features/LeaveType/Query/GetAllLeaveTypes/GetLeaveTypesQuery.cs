﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Features.LeaveType.Query.GetAllLeaveTypes
{
    public class GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>
    {
    }
}
